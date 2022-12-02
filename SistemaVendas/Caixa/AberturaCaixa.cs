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
            txtUser.Text = System.Environment.MachineName;
            consultaCaixa();
            movimentacoesVendas();
        }
        private void consultaCaixa()
        {
            OleDbCommand command = new OleDbCommand("SELECT * FROM TB_AberturaFechamentoCaixa WHERE col_nomeCaixa = '" + txtCaixa.Text.Trim() + "' AND col_status = 0 ORDER BY Código DESC", ClassConexao.DBSCV());
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtCaixaInicial.Text = reader.GetValue(2).ToString();
                txtRecebimentoCheques.Text = reader.GetValue(3).ToString();
                txtrecebimentoDiversos.Text = reader.GetValue(4).ToString();
                txtDespesas.Text = reader.GetValue(5).ToString();
                txtsangrias.Text = reader.GetValue(6).ToString();
                
                break;
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
        }
    }
}
