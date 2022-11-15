using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class TelaInicio : MetroFramework.Forms.MetroForm
    {
        public TelaInicio()
        {
            InitializeComponent();
            lblUsuario.Text = ClassDadosGEt.Usuario;
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioVendas vendas = new FormularioVendas();
            vendas.Show();
            this.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroClientes form1 = new CadastroClientes();
            form1.Show();
            this.Visible = false;
        }

        private void usuárioDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ClassDadosGEt.Nivel == 1)
            {
                CadastroUsuario cadastroUsuario = new CadastroUsuario();
                cadastroUsuario.Show();
                this.Visible=false;
            }
            else
            {
                MessageBox.Show("Usuário sem permissão.", "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você realmente deseja fechar o programa?","Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FormularioVendas vendas = new FormularioVendas();
            vendas.Show();
            this.Visible = false;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadastroClientes form1 = new CadastroClientes();
            form1.Show();
            this.Visible = false;
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F8)
            {
                FormularioVendas vendas = new FormularioVendas();
                vendas.Show();
                this.Visible = false;
            }
            else if(e.KeyCode == Keys.F3)
            {
                CadastroProdutos vendas = new CadastroProdutos();
                vendas.Show();
                this.Visible = false;
            }
        }

        private void btnVendas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnEstoque_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {

        }
    }
}
