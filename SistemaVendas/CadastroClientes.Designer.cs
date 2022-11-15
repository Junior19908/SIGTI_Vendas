using System.Windows.Forms;

namespace CadastroClientes
{
    partial class CadastroClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.ComboBox();
            this.btnFichaCadastro = new MetroFramework.Controls.MetroButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumEnd = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtInscricaoEstadual = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemoverFoto = new System.Windows.Forms.Button();
            this.btnAdicionarFoto = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.txtCelSecundario = new System.Windows.Forms.MaskedTextBox();
            this.txtCelPessoal = new System.Windows.Forms.MaskedTextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.dtGridArquivos = new System.Windows.Forms.DataGridView();
            this.IDArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nomeArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.datagridVenda = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridArquivos)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVenda)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(17, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 543);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1049, 486);
            this.panel3.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Controls.Add(this.btnPesquisar);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.txtCodigoCliente);
            this.tabPage1.Controls.Add(this.txtCidade);
            this.tabPage1.Controls.Add(this.btnFichaCadastro);
            this.tabPage1.Controls.Add(this.btnLimpar);
            this.tabPage1.Controls.Add(this.btnGravar);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.txtInfo);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.txtSite);
            this.tabPage1.Controls.Add(this.txtComplemento);
            this.tabPage1.Controls.Add(this.txtNumEnd);
            this.tabPage1.Controls.Add(this.txtBairro);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(this.txtInscricaoEstadual);
            this.tabPage1.Controls.Add(this.txtRG);
            this.tabPage1.Controls.Add(this.txtNomeCompleto);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtEstado);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtCep);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnRemoverFoto);
            this.tabPage1.Controls.Add(this.btnAdicionarFoto);
            this.tabPage1.Controls.Add(this.picFoto);
            this.tabPage1.Controls.Add(this.txtCelSecundario);
            this.tabPage1.Controls.Add(this.txtCelPessoal);
            this.tabPage1.Controls.Add(this.txtCNPJ);
            this.tabPage1.Controls.Add(this.txtCPF);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1033, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro/Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.Location = new System.Drawing.Point(3, 429);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(64, 20);
            this.btnVoltar.TabIndex = 44;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(936, 49);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(64, 20);
            this.btnPesquisar.TabIndex = 43;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(924, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Código do Cliente";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(906, 24);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(123, 20);
            this.txtCodigoCliente.TabIndex = 41;
            this.txtCodigoCliente.Text = "0";
            this.txtCodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoCliente.DoubleClick += new System.EventHandler(this.txtCodigoCliente_DoubleClick);
            this.txtCodigoCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoCliente_KeyUp);
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidade.FormattingEnabled = true;
            this.txtCidade.Location = new System.Drawing.Point(321, 150);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(511, 21);
            this.txtCidade.TabIndex = 40;
            // 
            // btnFichaCadastro
            // 
            this.btnFichaCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFichaCadastro.Location = new System.Drawing.Point(907, 225);
            this.btnFichaCadastro.Name = "btnFichaCadastro";
            this.btnFichaCadastro.Size = new System.Drawing.Size(122, 20);
            this.btnFichaCadastro.TabIndex = 39;
            this.btnFichaCadastro.Text = "&Ficha de Cadastro";
            this.btnFichaCadastro.UseSelectable = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(965, 429);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 20);
            this.btnLimpar.TabIndex = 38;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.Location = new System.Drawing.Point(895, 429);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(64, 20);
            this.btnGravar.TabIndex = 37;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "&Informação Adic.:";
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.Location = new System.Drawing.Point(104, 250);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(926, 174);
            this.txtInfo.TabIndex = 35;
            this.txtInfo.Text = "";
            // 
            // txtemail
            // 
            this.txtemail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemail.Location = new System.Drawing.Point(350, 225);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(482, 20);
            this.txtemail.TabIndex = 34;
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(104, 225);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(199, 20);
            this.txtSite.TabIndex = 32;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplemento.Location = new System.Drawing.Point(387, 200);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(445, 20);
            this.txtComplemento.TabIndex = 30;
            // 
            // txtNumEnd
            // 
            this.txtNumEnd.Location = new System.Drawing.Point(235, 200);
            this.txtNumEnd.Name = "txtNumEnd";
            this.txtNumEnd.Size = new System.Drawing.Size(67, 20);
            this.txtNumEnd.TabIndex = 28;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.Location = new System.Drawing.Point(104, 175);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(728, 20);
            this.txtBairro.TabIndex = 27;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndereco.Location = new System.Drawing.Point(104, 125);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(728, 20);
            this.txtEndereco.TabIndex = 21;
            // 
            // txtInscricaoEstadual
            // 
            this.txtInscricaoEstadual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInscricaoEstadual.Location = new System.Drawing.Point(442, 49);
            this.txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            this.txtInscricaoEstadual.Size = new System.Drawing.Size(389, 20);
            this.txtInscricaoEstadual.TabIndex = 12;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(104, 75);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(127, 20);
            this.txtRG.TabIndex = 10;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCompleto.Location = new System.Drawing.Point(104, 24);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(728, 20);
            this.txtNomeCompleto.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(307, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "&E-mail:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "&Site:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(307, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "&Complemento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "&Bairro:";
            // 
            // txtEstado
            // 
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.txtEstado.Location = new System.Drawing.Point(104, 150);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(127, 21);
            this.txtEstado.TabIndex = 25;
            this.txtEstado.TextChanged += new System.EventHandler(this.cmbEstado_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "&Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "&Cidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "&Endereço:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(104, 200);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(127, 20);
            this.txtCep.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "&Cep/Nº:";
            // 
            // btnRemoverFoto
            // 
            this.btnRemoverFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverFoto.Location = new System.Drawing.Point(837, 204);
            this.btnRemoverFoto.Name = "btnRemoverFoto";
            this.btnRemoverFoto.Size = new System.Drawing.Size(64, 20);
            this.btnRemoverFoto.TabIndex = 17;
            this.btnRemoverFoto.Text = "&Remover";
            this.btnRemoverFoto.UseVisualStyleBackColor = true;
            this.btnRemoverFoto.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdicionarFoto
            // 
            this.btnAdicionarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarFoto.Location = new System.Drawing.Point(837, 179);
            this.btnAdicionarFoto.Name = "btnAdicionarFoto";
            this.btnAdicionarFoto.Size = new System.Drawing.Size(64, 20);
            this.btnAdicionarFoto.TabIndex = 16;
            this.btnAdicionarFoto.Text = "&Adicionar";
            this.btnAdicionarFoto.UseVisualStyleBackColor = true;
            this.btnAdicionarFoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // picFoto
            // 
            this.picFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Image = global::SistemaVendas.Properties.Resources.user;
            this.picFoto.Location = new System.Drawing.Point(906, 85);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(123, 135);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 15;
            this.picFoto.TabStop = false;
            // 
            // txtCelSecundario
            // 
            this.txtCelSecundario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCelSecundario.Location = new System.Drawing.Point(442, 100);
            this.txtCelSecundario.Mask = "(99) 0 0000-0000";
            this.txtCelSecundario.Name = "txtCelSecundario";
            this.txtCelSecundario.Size = new System.Drawing.Size(389, 20);
            this.txtCelSecundario.TabIndex = 14;
            // 
            // txtCelPessoal
            // 
            this.txtCelPessoal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCelPessoal.Location = new System.Drawing.Point(442, 75);
            this.txtCelPessoal.Mask = "(99) 0 0000-0000";
            this.txtCelPessoal.Name = "txtCelPessoal";
            this.txtCelPessoal.Size = new System.Drawing.Size(389, 20);
            this.txtCelPessoal.TabIndex = 13;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(104, 100);
            this.txtCNPJ.Mask = "00.000.000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(127, 20);
            this.txtCNPJ.TabIndex = 11;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(104, 49);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(127, 20);
            this.txtCPF.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "&Celular Secundário:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "&Celular Pessoal:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "&Inscrição Estadual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "&CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&RG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nome Completo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAbrir);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.btnArquivo);
            this.tabPage2.Controls.Add(this.txtCaminho);
            this.tabPage2.Controls.Add(this.dtGridArquivos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1033, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Arquivos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrir.Location = new System.Drawing.Point(963, 429);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(64, 20);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Text = "&Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Caminho do Arquivo......";
            // 
            // btnArquivo
            // 
            this.btnArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArquivo.Location = new System.Drawing.Point(963, 26);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(64, 20);
            this.btnArquivo.TabIndex = 2;
            this.btnArquivo.Text = "&Enviar";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminho.Location = new System.Drawing.Point(5, 26);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(952, 20);
            this.txtCaminho.TabIndex = 1;
            // 
            // dtGridArquivos
            // 
            this.dtGridArquivos.AllowUserToAddRows = false;
            this.dtGridArquivos.AllowUserToOrderColumns = true;
            this.dtGridArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridArquivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDArquivo,
            this.col_nomeArquivo});
            this.dtGridArquivos.Location = new System.Drawing.Point(5, 58);
            this.dtGridArquivos.Name = "dtGridArquivos";
            this.dtGridArquivos.RowTemplate.Height = 25;
            this.dtGridArquivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtGridArquivos.Size = new System.Drawing.Size(1022, 365);
            this.dtGridArquivos.TabIndex = 0;
            this.dtGridArquivos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridArquivos_CellDoubleClick);
            this.dtGridArquivos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtGridArquivos_MouseDoubleClick);
            // 
            // IDArquivo
            // 
            this.IDArquivo.DataPropertyName = "col_IDArquivo";
            this.IDArquivo.HeaderText = "IDArquivo";
            this.IDArquivo.Name = "IDArquivo";
            // 
            // col_nomeArquivo
            // 
            this.col_nomeArquivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_nomeArquivo.DataPropertyName = "col_nomeArquivo";
            this.col_nomeArquivo.HeaderText = "Nome do Arquivo";
            this.col_nomeArquivo.Name = "col_nomeArquivo";
            this.col_nomeArquivo.Width = 105;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.datagridVenda);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1033, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Saldo Devedor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Sitka Banner", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label20.Location = new System.Drawing.Point(4, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(207, 39);
            this.label20.TabIndex = 1;
            this.label20.Text = "Vendas ao Cliente";
            // 
            // datagridVenda
            // 
            this.datagridVenda.AllowUserToAddRows = false;
            this.datagridVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridVenda.Location = new System.Drawing.Point(3, 72);
            this.datagridVenda.Name = "datagridVenda";
            this.datagridVenda.Size = new System.Drawing.Size(1027, 377);
            this.datagridVenda.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 57);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::SistemaVendas.Properties.Resources.logo_ti;
            this.pictureBox2.Location = new System.Drawing.Point(954, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Sitka Banner", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(11, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(347, 39);
            this.label17.TabIndex = 0;
            this.label17.Text = "Módulo de Cadastro de Cliente";
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 620);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroClientes";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 17);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CadastroClientes_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridArquivos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVenda)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label17;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtCodigoCliente;
        private ComboBox txtCidade;
        private MetroFramework.Controls.MetroButton btnFichaCadastro;
        private Button btnLimpar;
        private Button btnGravar;
        private Label label16;
        private RichTextBox txtInfo;
        private TextBox txtemail;
        private TextBox txtSite;
        private TextBox txtComplemento;
        private TextBox txtNumEnd;
        private TextBox txtBairro;
        private TextBox txtEndereco;
        private TextBox txtInscricaoEstadual;
        private TextBox txtRG;
        private TextBox txtNomeCompleto;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private ComboBox txtEstado;
        private Label label11;
        private Label label10;
        private Label label9;
        private MaskedTextBox txtCep;
        private Label label8;
        private Button btnRemoverFoto;
        private Button btnAdicionarFoto;
        private PictureBox picFoto;
        private MaskedTextBox txtCelSecundario;
        private MaskedTextBox txtCelPessoal;
        private MaskedTextBox txtCNPJ;
        private MaskedTextBox txtCPF;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private PictureBox pictureBox2;
        private Label label18;
        private Button btnArquivo;
        private TextBox txtCaminho;
        private DataGridView dtGridArquivos;
        private Button btnVoltar;
        private Button btnPesquisar;
        private Label label19;
        private Button btnAbrir;
        private Label label20;
        private DataGridView datagridVenda;
        private DataGridViewTextBoxColumn IDArquivo;
        private DataGridViewTextBoxColumn col_nomeArquivo;
    }
}