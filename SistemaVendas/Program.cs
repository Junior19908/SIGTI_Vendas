using CadastroClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //CadastroClientes.CadastroClientes formlogin = new CadastroClientes.CadastroClientes();
            //formlogin.ShowDialog();

            CadastroClientes.Login formlogin = new CadastroClientes.Login();
            formlogin.ShowDialog();


            if (formlogin.FMP == true)
            {
                Application.Run(new CadastroClientes.TelaInicio());
            }
        }
    }
}
