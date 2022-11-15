using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class CadastroUsuario : MetroFramework.Forms.MetroForm
    {
        //Variável
        int Nivel = 0;
        int Status = 0;
        string caminhoArquivo;
        byte[] foto;

        public CadastroUsuario()
        {
            InitializeComponent();
            ConsultarDataGrid();
        }
        private void ConsultarDataGrid()
        {
            if (ClassConexao.DBSCV().State == ConnectionState.Open)
            {
                DataTable dtLista = new DataTable();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM TB_LoginDBSCV ORDER BY col_id ASC");
                cmd.Connection = ClassConexao.DBSCV();
                OleDbDataReader reader = cmd.ExecuteReader();
                dtLista.Load(reader);
                dtGridUsuarios.DataSource = dtLista;
                ClassConexao.DBSCV().Close();
            }
        }
        private void LimparTxtBox()
        {
            txtCodigoUsuario.Clear();
            txtNomeCompleto.Clear();
            txtEmailUsuario.Clear();
            txtSenhaUsuario.Clear();
            txtUsuario.Clear();
            cmbNivel.Text = "";
            cmbStatus.Text = "";
            //picFoto.ImageLocation = @"C:\Users\junio\OneDrive\Imagens\59-594018_krabs-babby-pc-guy-griz-pretty-girl-and.png";
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbStatus.Text == "Ativado") { Status = 1; } else{ Status = 2; }
                if (cmbNivel.Text == "Administrador"){ Nivel = 1; } else { Nivel = 2; }
                OleDbCommand command = ClassConexao.DBSCV().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO TB_LoginDBSCV (col_nome,col_usuario,col_senha,col_email,col_nivel,col_status,col_cadastro,col_imagem) VALUES('" + txtNomeCompleto.Text + "','" + txtUsuario.Text + "','" + txtSenhaUsuario.Text + "','" + txtEmailUsuario.Text + "','" + Nivel + "','" + Status + "', NOW(), @foto)";
               
                OleDbParameter paramFoto = new OleDbParameter("@foto", OleDbType.Binary);
                paramFoto.Value = foto;
                command.Parameters.Add(paramFoto);
                command.ExecuteNonQuery();

                if (MessageBox.Show("Usuário Inserido!","Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                {
                    LimparTxtBox();
                    ConsultarDataGrid();
                    ClassConexao.DBSCV().Close();
                }
            }
            catch (OleDbException ErroDB)
            {
                MessageBox.Show(ErroDB.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos imagem (*.BMP;*.JPG;*.GIF;.*JPEG)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = openFileDialog.FileName;
                Bitmap bitmap = new Bitmap(caminhoArquivo);
                picFoto.Image = bitmap;

                MemoryStream ms = new MemoryStream();
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                foto = ms.ToArray();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            picFoto.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparTxtBox();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicio menu = new TelaInicio();
            menu.Show();
            this.Dispose();
        }
    }
}
