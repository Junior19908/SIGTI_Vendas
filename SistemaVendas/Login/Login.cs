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

namespace CadastroClientes
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();

        }
        public bool FMP = false;
        int CounErro = 0;
        public void Logar()
        {
            
            try
            {
                if(ClassConexao.DBSCV().State == ConnectionState.Open)
                {
                    //Conexão do formulário com o Banco de Dados
                    string tb_usuario = "SELECT * FROM TB_LoginDBSCV WHERE col_usuario = @usuario";
                    OleDbCommand oleDbCommand = new OleDbCommand(tb_usuario, ClassConexao.DBSCV());
                    oleDbCommand.Parameters.Add(new OleDbParameter("@usuario", txtUsuarioLogin.Text));
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.CloseConnection);

                    //Coleta as informações e armazena para futuras consultas
                    while (oleDbDataReader.Read())
                    {
                        ClassDadosGEt.Usuario = Convert.ToString(oleDbDataReader["col_usuario"]);
                        ClassDadosGEt.Senha = Convert.ToString(oleDbDataReader["col_senha"]);
                        ClassDadosGEt.Status = Convert.ToInt32(oleDbDataReader["col_status"]);
                        ClassDadosGEt.Nivel = Convert.ToInt32(oleDbDataReader["col_nivel"]);
                        ClassDadosGEt.IDUsuario = Convert.ToInt32(oleDbDataReader["col_id"]);
                    }

                    //Verifica se a senha está correta
                    if (ClassDadosGEt.Senha == txtSenhaLogin.Text)
                    {
                        //Verifica se o status do usuário é Ativo(1) ou Desativado(2)
                        if (ClassDadosGEt.Status == 1)
                        {
                            FMP = true;
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Usuário não Ativado!","<- Aviso ->");
                        }
                    }
                    //Caso esteja errada a senha ele cai nesse else
                    else
                    {
                        MessageBox.Show("Usuário Não Logado!");
                        CounErro++;
                        label2.Visible = true;
                        lblErroSenha.Visible = true;
                        if (CounErro > 1)
                        {
                            label2.Text = CounErro + " Tentativas!";
                        }
                        else
                        {
                            label2.Text = CounErro + " Tentativa!";
                        }

                        if (CounErro == 4)
                        {
                            MessageBox.Show("Em breve, o programa será fechado! n/ Última tantativa");
                        }

                        if(CounErro >= 5)
                        {
                            MessageBox.Show("Muitas tentativas, o programa será fechado!");
                            Application.Exit();
                        }
                    }
                }
                //Else caso a conexão esteja fechada
                else
                {
                    MessageBox.Show("Erro ao Conectar ao Banco de Dados");
                }
            }
            //Tratamento do Erro no Banco de Dados
            catch (OleDbException DBError)
            {
                MessageBox.Show("Erro com o Banco de Dados! " + DBError.Message +"","<- Banco de Dados ->",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                if (ClassConexao.DBSCV().State == ConnectionState.Open)
                {
                    
                }
            }
            catch (OleDbException)
            {
                ConfigConexao configConexao = new ConfigConexao();
                configConexao.ShowDialog();
                //this.Dispose();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }
    }
}
