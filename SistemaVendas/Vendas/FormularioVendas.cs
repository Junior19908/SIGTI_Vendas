using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class FormularioVendas : MetroFramework.Forms.MetroForm
    {
        public FormularioVendas()
        {
            InitializeComponent();
            //CarregarComboBoxProduto();
            CarregarComboBoxCliente();
            CarregarComboBoxVendedor();
        }
        OleDbCommand command;
        

        private void CarregarComboBoxProduto()
        {
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT col_IdProduto, col_descricaoProduto FROM TB_EstoqueDBSCV", ClassConexao.DBSCV());
                OleDbDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                DataRow row = dt.NewRow();
                row["col_IdProduto"] = 0;
                dt.Rows.InsertAt(row, 0);

                //this.cmbProduto.DataSource = dt;
                //this.cmbProduto.ValueMember = "col_IdProduto";
                //this.cmbProduto.DisplayMember = "col_descricaoProduto";

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
        private void CarregarComboBoxCliente()
        {
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT Código, col_nomeCompleto FROM TB_ClienteDBSCV", ClassConexao.DBSCV());
                OleDbDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                DataRow row = dt.NewRow();
                row["Código"] = 0;
                dt.Rows.InsertAt(row, 0);

                this.cbCliente.DataSource = dt;
                this.cbCliente.ValueMember = "Código";
                this.cbCliente.DisplayMember = "col_nomeCompleto";

                reader.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro ao preencher o BoxCliente! - Contate o Desenvolvedor\r\n"+ Error.Message, "<- Banco de Dados ->",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            finally
            {
                ClassConexao.DBSCV().Close();
            }
        }
        private void CarregarComboBoxVendedor()
        {
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT col_id, col_usuario FROM TB_LoginDBSCV WHERE col_id="+ ClassDadosGEt.IDUsuario.ToString() +"", ClassConexao.DBSCV());
                OleDbDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                DataRow row = dt.NewRow();
                //row["col_id"] = 0;
                //dt.Rows.InsertAt(row, 0);
            
                this.cbVendedor.DataSource = dt;
                this.cbVendedor.ValueMember = "col_id";
                this.cbVendedor.DisplayMember = "col_usuario";
            
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
                "WHERE TB_VendaDBSCV.col_codCliente='"+ClassDadosGEt.IDUsuario+"' " +
                "LEFT JOIN TB_EstoqueDBSCV ON TB_VendaDBSCV.col_codProduto = TB_EstoqueDBSCV.col_IdProduto " +
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

        private void btnClienteNovo_Click(object sender, EventArgs e)
        {
            string novaJanela = "1";
            //var clientes = new CadastroClientes(novaJanela);
            //clientes.Show();

            CadastroClientes cadastro = new CadastroClientes(novaJanela);
            cadastro.Show();

        }

        private void btnVender_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicio menu = new TelaInicio();
            menu.Show();
            this.Dispose();
        }

        private void datagridVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        double valorProdutoUnidade;
        double valorProdutoTotal;
        double valorDescontoProduto;
        string valorPorcentagem;
        double valorLiquidoVenda;

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                double result;
                result = Convert.ToDouble(txtVendaCod.Text);
                result += 1;
                command = ClassConexao.DBSCV().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO TB_VendasDBSCV (col_codVendaProduto, col_codProduto, col_quantidadeVendaProduto, col_valorProdutoUnidade, col_valorTotalProduto, col_porcentagemProduto, col_valorDesconto, col_valorLiquidoProduto) VALUES" +
                    "(" + result + ",'" + txtCodBarras.Text + "','" + txtQtde.Text + "','" + valorProdutoUnidade + "','" + valorProdutoTotal + "', '" + valorPorcentagem + "', '" + valorDescontoProduto + "', '" + valorLiquidoVenda + "')";
                command.ExecuteNonQuery();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao preencher o BoxCliente! - Contate o Desenvolvedor\r\n" + Erro.Message, "<- Banco de Dados ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //OleDbCommand command = new OleDbCommand("SELECT col_precoAtual FROM TB_EstoqueDBSCV WHERE col_IdProduto = "+ cmbProduto.SelectedValue + "",ClassConexao.DBSCV());
                //OleDbDataReader reader = command.ExecuteReader();
                //while (reader.Read())
                //{
                //    //txtResultValor.Text = reader.GetValue(0).ToString();
                //    //double vlTotal = Convert.ToDouble(txtResultValor.Text) * Convert.ToDouble(txtQuantidade.Text);
                //    //txtResultValor.Text = vlTotal.ToString();
                //}
            }
        }
        private void btnCriarCodBarras_Click(object sender, EventArgs e)
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
    }
}
