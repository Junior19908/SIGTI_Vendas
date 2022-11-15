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
                MessageBox.Show("Arquivo de Usuário não, encontrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Arquivo de Usuário não, encontrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
