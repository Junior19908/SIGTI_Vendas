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
    public partial class AdicionarChequesPagos : MetroFramework.Forms.MetroForm
    {
        public AdicionarChequesPagos()
        {
            InitializeComponent();
            nomeMaquina = System.Environment.MachineName;
        }
        string nomeMaquina;
        private void btnGravarDespesa_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = ClassConexao.DBSCV().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO TB_AberturaFechamentoCaixaDBSCV (col_nomeCaixa,col_chequesPagos, col_descricaoChequesPagos) VALUES" +
                    "('"+ nomeMaquina + "','" + txtValorCheques.Text + "','" + txtDescricaoCheques.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com sucesso!");
                txtDescricaoCheques.Clear();
                txtValorCheques.Clear();
            }
            catch (OleDbException ErroBanco)
            {
                MessageBox.Show("Erro com o banco de dados, " + ErroBanco.Message, "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro" + Error.Message, "Informação",MessageBoxButtons.OK);
            }
        }
    }
}
