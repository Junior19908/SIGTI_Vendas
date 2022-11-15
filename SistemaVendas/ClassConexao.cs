using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CadastroClientes
{
    internal class ClassConexao
    {
        public static OleDbConnection DBSCV()
        {
            string sql = System.Configuration.ConfigurationManager.ConnectionStrings["DBSCVCaminho"].ConnectionString;
            OleDbConnection CONEX = new OleDbConnection(sql);
            CONEX.Open();
            return CONEX;
        }
    }
}
