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

namespace SistemaVendas.Vendas.Estoque
{
    public partial class CadastroGrupoSub : MetroFramework.Forms.MetroForm
    {
        public CadastroGrupoSub()
        {
            InitializeComponent();
            CarregarGridGrupos();
        }
        private void CarregarGridGrupos()
        {
            try
            {
                if (ClassConexao.DBSCV().State == ConnectionState.Open)
                {
                    OleDbCommand selectCMD = new OleDbCommand("SELECT * FROM TB_GrupoDBSCV", ClassConexao.DBSCV());
                    OleDbDataAdapter daAdapter = new OleDbDataAdapter(selectCMD);
                    DataSet table = new DataSet();
                    daAdapter.Fill(table);
                    dtGridViewGrupo.DataSource = table.Tables[0];
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
                if (ClassConexao.DBSCV().State == ConnectionState.Open)
                {
                    OleDbCommand selectCMD = new OleDbCommand("SELECT * FROM TB_SubGrupoDBSCV", ClassConexao.DBSCV());
                    OleDbDataAdapter daAdapter = new OleDbDataAdapter(selectCMD);
                    DataSet table = new DataSet();
                    daAdapter.Fill(table);
                    dtGridViewSubGrupo.DataSource = table.Tables[0];
                }
                else
                {
                    MessageBox.Show("Erro ao Conectar!");
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro relacionado ao banco de dados "+ ex.Message +" !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbParameter paramFoto;
                OleDbCommand command = ClassConexao.DBSCV().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO TB_GrupoDBSCV (col_descricaoGrupo) VALUES" +
                    "('" + txtGrupo.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Cadastro " + txtGrupo.Text + " Realizado com sucesso!");
                txtGrupo.Clear();
                CarregarGridGrupos();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro! - Contate o Desenvolvedor\r\n" + Erro.Message, "<- Banco de Dados ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnGravarSubGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbParameter paramFoto;
                OleDbCommand command = ClassConexao.DBSCV().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO TB_SubGrupoDBSCV (col_descricaoSubGrupo) VALUES" +
                    "('" + txtSubGrupo.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Cadastro " + txtSubGrupo.Text + " Realizado com sucesso!");
                txtGrupo.Clear();
                CarregarGridGrupos();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro! - Contate o Desenvolvedor\r\n" + Erro.Message, "<- Banco de Dados ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
