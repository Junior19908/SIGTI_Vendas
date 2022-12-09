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
    public partial class AdicionarDespesas : MetroFramework.Forms.MetroForm
    {
        public AdicionarDespesas()
        {
            InitializeComponent();
        }

        private void btnGravarDespesa_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = ClassConexao.DBSCV().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO TB_FormaPagamentoDBSCV (col_despesas, col_descricaoDespesas) VALUES" +
                    "('" + txtValorDespesa.Text + "','" + txtDescricaoDespesa.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com sucesso!");
                txtDescricaoDespesa.Clear();
                txtValorDespesa.Clear();
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro" + Error.Message, "Informação",MessageBoxButtons.OK);
            }
        }
    }
}
