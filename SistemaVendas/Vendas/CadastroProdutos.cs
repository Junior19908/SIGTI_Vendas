using CadastroClientes;
using SistemaVendas.Classes;
using SistemaVendas.Vendas.Estoque;
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
    public partial class CadastroProdutos : MetroFramework.Forms.MetroForm
    {
        public CadastroProdutos()
        {
            InitializeComponent();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicio menu = new TelaInicio();
            menu.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CadastroGrupoSub cadastroGrupoSub = new CadastroGrupoSub();
            //cadastroGrupoSub.ShowDialog();
            //this.Dispose();

            var cadastroGrupoSub = new CadastroGrupoSub();
            cadastroGrupoSub.Show();
        }
    }
}
