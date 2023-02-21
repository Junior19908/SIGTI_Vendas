using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class CadastroClientes : MetroFramework.Forms.MetroForm
    {
        public CadastroClientes()
        {
            InitializeComponent();
            carregarCodigo();
            CarregarGrid();
            //carregarGridVendas();
            
        }

        public CadastroClientes(string novaJanela)
        {
            this.novaJanela = novaJanela;
        }

        //Variavéis Declaradas
        OleDbCommand command, cmdSelect;
        OleDbDataReader oleDbData;
        OleDbParameter paramFoto;
        int codClientID;
        byte[] foto;
        string caminhoArquivo;
        private string novaJanela;
        int Nulo;

        private void cmbEstado_TextChanged(object sender, EventArgs e)
        {

        }
        private void carregarCodigo()
        {
            OleDbCommand commandCodCliente = new OleDbCommand("SELECT Código FROM TB_ClienteDBSCV ORDER BY Código DESC", ClassConexao.DBSCV());
            commandCodCliente.ExecuteNonQuery();
            int consultcodCliente = Convert.ToInt32(commandCodCliente.ExecuteScalar());
            if (consultcodCliente > 0)
            {
                txtCodigoCliente.Text = consultcodCliente.ToString();
            }
            int aCodCliente = Convert.ToInt32(txtCodigoCliente.Text);
            int bCodCliente = aCodCliente + 1;
            int cCodCliente = bCodCliente;
            txtCodigoCliente.Text = cCodCliente.ToString();
        }
        private void carregarGridVendas()
        {
            try
            {
                OleDbCommand selectCMD = new OleDbCommand("" +
                "SELECT " +
                "TB_VendaDBSCV.*," +
                "TB_EstoqueDBSCV.col_IdProduto," +
                "TB_EstoqueDBSCV.col_descricaoProduto," +
                "TB_EstoqueDBSCV.col_precoAtual " +
                "FROM TB_VendaDBSCV " +
                "LEFT JOIN TB_EstoqueDBSCV ON TB_VendaDBSCV.col_codProduto = TB_EstoqueDBSCV.col_IdProduto " +
                "WHERE TB_VendaDBSCV.col_codCliente = " + txtCodigoCliente.Text.ToString() + " " +
                "ORDER BY TB_VendaDBSCV.col_codVendaIDitem ASC", ClassConexao.DBSCV());
                OleDbDataAdapter daAdapter = new OleDbDataAdapter(selectCMD);
                DataSet table = new DataSet();
                daAdapter.Fill(table);
                datagridVenda.DataSource = table.Tables[0];
                //datagridVenda.Columns["col_UsuarioVenda"].Visible = false;
                //datagridVenda.Columns["col_codVendaIDitem"].Visible = false;
                //datagridVenda.Columns["col_codProduto"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CarregarGrid()
        {
            try
            {
                //codClientID = 2;
                if (ClassConexao.DBSCV().State == ConnectionState.Open)
                {
                    //codClientID++;
                    //txtCodigoCliente.Text = codClientID.ToString();
                    DataTable dtLista = new DataTable();
                    cmdSelect = new OleDbCommand("SELECT * FROM TB_ArquivoDBSCV WHERE col_IDCliente=" + txtCodigoCliente.Text + " ORDER BY col_IdArquivo ASC");
                    cmdSelect.Connection = ClassConexao.DBSCV();
                    oleDbData = cmdSelect.ExecuteReader();
                    dtLista.Load(oleDbData);
                    dtGridArquivos.DataSource = dtLista;
                    dtGridArquivos.Columns["col_IDCliente"].Visible = false;
                    dtGridArquivos.Columns["col_arquivo"].Visible = false;
                    ClassConexao.DBSCV().Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Conectar!");
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Arquivo de Usuário não, encontrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message);
            }
        }
        private void LimparTxtBox()
        {
            txtInfo.Clear();
            txtEstado.Text = "";
            txtEndereco.Clear();
            txtComplemento.Clear();
            txtCNPJ.Clear();
            txtCPF.Clear();
            txtemail.Clear();
            txtInscricaoEstadual.Clear();
            txtBairro.Clear();
            txtCaminho.Clear();
            txtCelPessoal.Clear();
            txtCelSecundario.Clear();
            txtCep.Clear();
            txtCidade.Text = "";
            txtemail.Clear();
            txtNomeCompleto.Clear();
            txtNumEnd.Clear();
            txtRG.Clear();
            txtSite.Clear();
            picFoto.Image = null;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                //Consulta no Banco de Dados se Existe Aquele Código(ID) caso tenha,
                //será feito um Update se não, ele cria um novo registro.
                OleDbCommand prompt = new OleDbCommand("SELECT COUNT(*) FROM TB_ClienteDBSCV WHERE Código = " + txtCodigoCliente.Text + " ", ClassConexao.DBSCV());//Seleção da tabela no Banco de Dados.
                prompt.ExecuteNonQuery();//Executa o comando.
                int consultDB = Convert.ToInt32(prompt.ExecuteScalar());//Converte o resultado para números inteiros.
                if (consultDB > 0)
                {
                    MessageBox.Show("Exite Registro, Com esse Código!");



                }
                else
                {
                    OleDbCommand oleDb = new OleDbCommand("SELECT COUNT(*) FROM TB_ClienteDBSCV WHERE col_Cpf = '" + txtCPF.Text + "' ", ClassConexao.DBSCV());//Seleção da tabela no Banco de Dados.
                    //Executa o comando.
                    oleDb.ExecuteNonQuery();
                    //Converte o resultado para números inteiros.
                    int cons = Convert.ToInt32(oleDb.ExecuteScalar());
                    if (cons > 0)
                    {
                        MessageBox.Show("Exite Registro, Com esse CPF!");
                    }
                    else
                    {
                        command = ClassConexao.DBSCV().CreateCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT INTO TB_ClienteDBSCV (Código,col_nomeCompleto,col_Cpf,col_rg,col_cnpj,col_inscricao,col_celular1,col_celular2,col_endereco,col_estado,col_cidade,col_bairro,col_cep,col_numero,col_complemento,col_site,col_email,col_info,col_dataCadastro,col_usuarioCadastro,col_imagem) VALUES" +
                            "(" + txtCodigoCliente.Text.ToString() + ",'" + txtNomeCompleto.Text + "','" + txtCPF.Text + "','" + txtRG.Text + "','" + txtCNPJ.Text + "','" + txtInscricaoEstadual.Text + "','" + txtCelPessoal.Text + "','" + txtCelSecundario.Text + "','" + txtEndereco.Text + "','" + txtEstado.Text + "','" + txtCidade.Text + "','" + txtBairro.Text + "','" + txtCep.Text + "','" + txtNumEnd.Text + "','" + txtComplemento.Text + "'" +
                            ",'" + txtSite.Text + "','" + txtemail.Text + "','" + txtInfo.Text + "', NOW(), '" + ClassDadosGEt.IDUsuario.ToString() + "',@foto)";

                        paramFoto = new OleDbParameter("@foto", OleDbType.Binary);
                        paramFoto.Value = foto;
                        command.Parameters.Add(paramFoto);
                        command.ExecuteNonQuery();

                        if (MessageBox.Show("Cliente Cadastrado com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                        {
                            LimparTxtBox();
                            //ConsultarDataGrid();
                            ClassConexao.DBSCV().Close();
                        }
                    }
                }
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message);
            }
        }

        private void dtGridArquivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtGridArquivos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //StreamReader sr = new StreamReader(dtGridArquivos.SelectedRows[0].Cells["col_arquivo"].Value.ToString());
            //sr.Read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos imagem (*.BMP;*.JPG;*.GIF;.*JPEG)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = openFileDialog.FileName;
                Bitmap bitmap = new Bitmap(caminhoArquivo);
                picFoto.Image = bitmap;

                MemoryStream ms = new MemoryStream();
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                foto = ms.ToArray();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picFoto.Image = null;
        }

        private void txtCodigoCliente_DoubleClick(object sender, EventArgs e)
        {
            txtCodigoCliente.Enabled = true;
        }

        private void CadastroClientes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                txtCodigoCliente.Enabled = true;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                //Process.Start(@"C:\\Users\\junio\\AppData\\Local\\Temp\\tmpB78C.pdf");
                using (var comm = ClassConexao.DBSCV().CreateCommand())
                {
                    comm.CommandText = "SELECT * FROM TB_ArquivoDBSCV WHERE col_idArquivo=@ID";
                    comm.Parameters.Add(new OleDbParameter("@ID", dtGridArquivos.CurrentRow.Cells["col_idArquivo"].Value));
                    var bytes = comm.ExecuteScalar() as byte[];
                    if (bytes != null)
                    {
                        var nomeArquivo = dtGridArquivos.CurrentRow.Cells["col_nomeArquivo"].Value.ToString();
                        var arquivoTemp = Path.GetTempFileName();
                        arquivoTemp = Path.ChangeExtension(arquivoTemp, Path.GetExtension(nomeArquivo));
                        File.WriteAllBytes(arquivoTemp, bytes);
                        //Process.Start("C:\\Users\\junio\\AppData\\Local\\Temp\\tmpB78C.pdf");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnArquivo_Click(object sender, EventArgs e)
        {
            //txtCodigoCliente.Text = codClientID.ToString();
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Arquivos para Anexar (*.PDF;*.DOC;*.XLS;*.XLSX)|*.PDF;*.DOC;*.XLS;*.XLSX| Todos os Arquivos (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    using (var comm = ClassConexao.DBSCV().CreateCommand())
                    {
                        txtCaminho.Enabled = false;
                        txtCaminho.Text = caminhoArquivo = open.FileName;
                        if (MessageBox.Show("Deseja Enviar?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            comm.CommandText = "INSERT INTO TB_ArquivoDBSCV(col_IDCliente, col_nomeArquivo, col_arquivo) VALUES ('" + txtCodigoCliente.Text + "', @NomeArquivo, @Arquivo)";
                            ConfigurarParametros(comm, caminhoArquivo);
                            comm.ExecuteNonQuery();
                            txtCaminho.Clear();
                            txtCaminho.Enabled = true;
                            CarregarGrid();
                        }
                        else
                        {
                            txtCaminho.Clear();
                            txtCaminho.Enabled = true;
                        }
                    }
                }
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ConfigurarParametros(OleDbCommand comm, string caminhoArquivo)
        {
            comm.Parameters.Add(new OleDbParameter("@NomeArquivo", Path.GetFileName(caminhoArquivo)));
            comm.Parameters.Add(new OleDbParameter("@Arquivo", File.ReadAllBytes(caminhoArquivo)));
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicio menu = new TelaInicio();
            menu.Show();
            this.Visible = false;
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {

        }

        private void CarregarInfoCliente()
        {
            OleDbCommand command = new OleDbCommand("SELECT * FROM TB_ClienteDBSCV WHERE Código = @ID ", ClassConexao.DBSCV());
            command.Parameters.AddWithValue("@ID", int.Parse(txtCodigoCliente.Text));
            OleDbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txtNomeCompleto.Text = dataReader.GetValue(1).ToString();
                txtCPF.Text = dataReader.GetValue(2).ToString();
                txtRG.Text = dataReader.GetValue(3).ToString();
                txtCNPJ.Text = dataReader.GetValue(4).ToString();
                txtInscricaoEstadual.Text = dataReader.GetValue(5).ToString();
                txtCelPessoal.Text = dataReader.GetValue(6).ToString();
                txtCelSecundario.Text = dataReader.GetValue(7).ToString();
                txtEndereco.Text = dataReader.GetValue(8).ToString();
                txtEstado.Text = dataReader[9].ToString();
                txtCidade.Text = dataReader[10].ToString();
                txtBairro.Text = dataReader[11].ToString();
                txtCep.Text = dataReader[12].ToString();
                txtNumEnd.Text = dataReader[13].ToString();
                txtComplemento.Text = dataReader[14].ToString();
                txtSite.Text = dataReader[15].ToString();
                txtemail.Text = dataReader[16].ToString();
                txtInfo.Text = dataReader[17].ToString();

                int statusDes = Convert.ToInt16(dataReader["col_status"].ToString());

                if(statusDes == 0)
                {
                    ckboxDesativar.Checked = true;
                }
                else if(statusDes == 1){
                    ckboxDesativar.Checked = false;
                }

                try
                {
                    byte[] images = ((byte[])dataReader[20]);
                    if (images == null)
                    {
                        picFoto.Image = null;
                    }
                    else
                    {
                        MemoryStream memory = new MemoryStream(images);
                        picFoto.Image = Image.FromStream(memory);
                    }
                }
                catch (InvalidCastException Erxr)
                {
                    MessageBox.Show("Cliente sem imagem, cadastrada!");
                }
                catch (Exception ErroR)
                {
                    MessageBox.Show(ErroR.Message);
                }
            }
            if (dataReader.HasRows == false)
            {
                Nulo = 1;
            }
        }

        private void txtCodigoCliente_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //carregarGridVendas();
            CarregarGrid();
            CarregarInfoCliente();
            ckboxDesativar.Visible = true;
            if (Nulo == 1)
            {
                LimparTxtBox();
                Nulo = 0;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTxtBox();
        }

        private void ckboxDesativar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(ckboxDesativar.Checked) {
                    command = ClassConexao.DBSCV().CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE TB_ClienteDBSCV SET col_status = 0 WHERE Código = " + txtCodigoCliente.Text + " ";
                    command.ExecuteNonQuery();
                }
                else
                {
                    command = ClassConexao.DBSCV().CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE TB_ClienteDBSCV SET col_status = 1 WHERE Código = " + txtCodigoCliente.Text + " ";
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}