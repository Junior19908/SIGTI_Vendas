using CadastroClientes;
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

namespace SistemaVendas.Caixa
{
    public partial class AberturaCaixa : MetroFramework.Forms.MetroForm
    {
        public AberturaCaixa()
        {
            InitializeComponent();
            txtCaixa.Text = System.Environment.MachineName;
            txtUser.Text = ClassDadosGEt.Usuario.ToString();
            consultaCaixa();
            movimentacoesVendas();
        }
        /*
         * Configurar textBox's de entradas e saídas
         */
        int statusCaixa;
        private void consultaCaixa()
        {
            OleDbCommand command = new OleDbCommand("SELECT SUM(col_inicial) AS col_inicial,SUM(col_recebimentoCheques) AS col_recebimentoCheques FROM TB_AberturaFechamentoCaixaDBSCV WHERE col_nomeCaixa = '" + txtCaixa.Text.Trim() + "' AND col_status = 0 AND col_IdCaixa = 4001", ClassConexao.DBSCV());
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtCaixaInicial.Text = reader.GetValue(0).ToString();
                txtRecebimentoCheques.Text = reader.GetValue(1).ToString();
                break;
            }
            OleDbCommand command2 = new OleDbCommand("SELECT * FROM TB_AberturaFechamentoCaixaDBSCV WHERE col_nomeCaixa = '" + txtCaixa.Text.Trim() + "' AND col_status = 0 AND col_IdCaixa = 4001", ClassConexao.DBSCV());
            OleDbDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                dateAbertura.Text = reader2.GetValue(10).ToString();
                statusCaixa = (int)reader2.GetValue(13);
                break;
            }



            if(statusCaixa == 1)
            {
                txtStatusCaixa.Text = "Fechado";
                txtCaixaInicial.Enabled = false; 
                txtRecebimentoCheques.Enabled = false; 
                txtrecebimentoDiversos.Enabled = false;
            }
            else
            {
                txtStatusCaixa.Text = "Aberto";
                txtCaixaInicial.Enabled = true;
                txtRecebimentoCheques.Enabled = true;
                txtrecebimentoDiversos.Enabled = true;
            }
        }
        private void movimentacoesVendas()
        {
            try
            {
                if (ClassConexao.DBSCV().State == ConnectionState.Open)
                {
                    OleDbCommand selectCMD = new OleDbCommand("SELECT * FROM TB_FormaPagamentoDBSCV WHERE col_statusCaixa = 1 AND col_maquinaCaixa = '" + txtCaixa.Text.Trim() + "'", ClassConexao.DBSCV());
                    OleDbDataAdapter daAdapter = new OleDbDataAdapter(selectCMD);
                    DataSet tableGridVendas = new DataSet();
                    daAdapter.Fill(tableGridVendas);
                    dtGridVendasAberturaFechamentoCaixa.DataSource = tableGridVendas.Tables[0];
                }
                else
                {
                    MessageBox.Show("Erro ao Conectar!");
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro relacionado ao banco de dados " + ex.Message + " !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message);
            }
            finally
            {
                ClassConexao.DBSCV().Close();
            }

            try
            {
                decimal valorTotal = 0;
                string valor = "";
                for (int i = 0; i <= dtGridVendasAberturaFechamentoCaixa.RowCount - 1; i++)
                {
                    if (dtGridVendasAberturaFechamentoCaixa.Rows[i].Cells[8].Value != null)
                        valorTotal += Convert.ToDecimal(dtGridVendasAberturaFechamentoCaixa.Rows[i].Cells[8].Value);
                }
                if (valorTotal == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                txtEntradasTotal.Text = valorTotal.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Calcular, Verifique os Valores Texto_1\n'" + ex.Message + "'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnAddDespesas_Click(object sender, EventArgs e)
        {
            AdicionarDespesas adicionarDespesas = new AdicionarDespesas();
            adicionarDespesas.ShowDialog();
        }

        private void btnReloadDespesas_Click(object sender, EventArgs e)
        {
            consultaCaixa();
            movimentacoesVendas();
        }

        private void btnAddSangria_Click(object sender, EventArgs e)
        {
            AdicionarSangria adicionarSangria = new AdicionarSangria();
            adicionarSangria.ShowDialog();
        }

        private void btnAddRetornoCaixa_Click(object sender, EventArgs e)
        {
            AdicionarRetornoCaixa ad = new AdicionarRetornoCaixa();
            ad.ShowDialog();
        }

        private void btnAddChequesPagos_Click(object sender, EventArgs e)
        {
            AdicionarChequesPagos adicionarChequesPagos = new AdicionarChequesPagos();
            adicionarChequesPagos.ShowDialog();
        }
    }
}
