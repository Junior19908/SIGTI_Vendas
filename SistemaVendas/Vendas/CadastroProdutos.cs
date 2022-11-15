using CadastroClientes;
using SistemaVendas.Classes;
using SistemaVendas.Vendas.Estoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class CadastroProdutos : MetroFramework.Forms.MetroForm
    {
        public CadastroProdutos()
        {
            InitializeComponent();
            CarregarComboBox();
        }
        private void btnCriarCodigo_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            byte[] buf = new byte[8];
            rnd.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            long result = (Math.Abs(longRand % (2000000000000000 - 1000000000000000)) + 1000000000000000);

            long random_seed = (long)rnd.Next(1000, 5000);
            random_seed = random_seed * result + rnd.Next(1000, 5000);

            this.txtCodBarras.Text = ((long)(random_seed / 655) % 10000000000000001).ToString();
        }
        private void CarregarComboBox()
        {
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT Código, col_descricaoGrupo FROM TB_GrupoDBSCV", ClassConexao.DBSCV());
                OleDbDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                DataRow row = dt.NewRow();

                this.cmbGrupo.DataSource = dt;
                this.cmbGrupo.ValueMember = "Código";
                this.cmbGrupo.DisplayMember = "col_descricaoGrupo";

                reader.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro ao preencher o BoxCliente! - Contate o Desenvolvedor\r\n" + Error.Message, "<- Banco de Dados ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                ClassConexao.DBSCV().Close();
            }

            try
            {
                OleDbCommand command = new OleDbCommand("SELECT Código, col_descricaoSubGrupo FROM TB_SubGrupoDBSCV", ClassConexao.DBSCV());
                OleDbDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                DataRow row = dt.NewRow();

                this.cmbSubGrupo.DataSource = dt;
                this.cmbSubGrupo.ValueMember = "Código";
                this.cmbSubGrupo.DisplayMember = "col_descricaoSubGrupo";

                reader.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro ao preencher o BoxCliente! - Contate o Desenvolvedor\r\n" + Error.Message, "<- Banco de Dados ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                ClassConexao.DBSCV().Close();
            }

            try
            {
                OleDbCommand command = new OleDbCommand("SELECT Código, col_descricaoFornecedor FROM TB_FornecedorDBSCV", ClassConexao.DBSCV());
                OleDbDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                DataRow row = dt.NewRow();

                this.cmbFornecedor.DataSource = dt;
                this.cmbFornecedor.ValueMember = "Código";
                this.cmbFornecedor.DisplayMember = "col_descricaoFornecedor";

                reader.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro ao preencher o BoxCliente! - Contate o Desenvolvedor\r\n" + Error.Message, "<- Banco de Dados ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                ClassConexao.DBSCV().Close();
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicio menu = new TelaInicio();
            menu.Show();
            this.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var cadastroGrupoSub = new CadastroGrupoSub();
            cadastroGrupoSub.Show();
        }
        double estoqueAtual;
        private void button4_Click(object sender, EventArgs e)
        {
            int codGrupo = Convert.ToInt32(cmbGrupo.SelectedValue);
            int codSubGrupo = Convert.ToInt32(cmbSubGrupo.SelectedValue);
            int codFornecedor = Convert.ToInt32(cmbFornecedor.SelectedValue);
            try
            {
                OleDbParameter paramFoto;
                OleDbCommand command = ClassConexao.DBSCV().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO TB_ProdutosDBSCV (col_codigoProduto, col_descricaoItem, col_unidadeMedida, col_margemLucro, col_lucroValor, col_precoVenda, col_estoqueMinimo, col_estoqueAtual, col_fornecedorProduto, col_marcaProduto, col_referenciaProduto, col_grupoProduto, col_subGrupoProduto, col_validadeProduto, col_depositoLocalizacaoProduto, col_observacaoProduto, col_fotoAnexo, col_dataCriacao) VALUES" +
                    "('" + txtCodBarras.Text + "','" + txtDescricaoItem.Text + "','" + cmbUnidadeMedida.Text + "','" + txtMargemLucro.Text + "','" + txtLucroValor.Text + "', '" + txtPrecoVenda.Text + "', '" + txtEstoqueMinimo.Text + "', '" + estoqueAtual + "', " + codFornecedor + ", '" + txtMarca.Text + "', '" + txtReferencia.Text + "', " + codGrupo + ", " + codSubGrupo + ", '"+ this.dateVencimento.Text +"', '" + txtLocalizacaoDeposito.Text + "', '"+ richTextObeservacao.Text + "', @foto, NOW())";
                paramFoto = new OleDbParameter("@foto", OleDbType.Binary);
                paramFoto.Value = foto;
                command.Parameters.Add(paramFoto);
                command.ExecuteNonQuery();
                MessageBox.Show("Cadastro " + txtCodBarras.Text + " " + txtDescricaoItem.Text + "Realizado com sucesso!");
                LimparText();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao preencher o BoxCliente! - Contate o Desenvolvedor\r\n" + Erro.Message, "<- Banco de Dados ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LimparText()
        {
            txtCodBarras.Clear();
            txtDescricaoItem.Clear();
            cmbFornecedor.Items.Clear();
            cmbUnidadeMedida.Items.Clear();
            txtMargemLucro.Clear();
            txtLucroValor.Clear();
            txtPrecoVenda.Clear();
            txtEstoqueMinimo.Clear();
            txtMarca.Clear();
            txtReferencia.Clear();
            txtLocalizacaoDeposito.Clear();
            richTextObeservacao.Clear();

        }
        byte[] foto;
        string caminhoArquivo;
        private void ConfigurarParametros(OleDbCommand comm, string caminhoArquivo)
        {
            comm.Parameters.Add(new OleDbParameter("@NomeArquivo", Path.GetFileName(caminhoArquivo)));
            comm.Parameters.Add(new OleDbParameter("@Arquivo", File.ReadAllBytes(caminhoArquivo)));
        }

        private void btnAdicionarFoto_Click(object sender, EventArgs e)
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
    }
}
