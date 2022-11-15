using System.Windows.Forms;

namespace CadastroClientes
{
    partial class TelaInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicio));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbluser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFluxoCaixa = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAberturaCaixa = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCadastro = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEstoque = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVendas = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(17, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 57);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::SistemaVendas.Properties.Resources.logo_ti;
            this.pictureBox2.Location = new System.Drawing.Point(988, 9);
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
            this.label17.Size = new System.Drawing.Size(203, 39);
            this.label17.TabIndex = 0;
            this.label17.Text = "Menu do Sistema";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbluser,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(17, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1082, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbluser
            // 
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(50, 17);
            this.lbluser.Text = "Usuário:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(29, 17);
            this.lblUsuario.Text = "user";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Italic);
            this.textBox1.Location = new System.Drawing.Point(1004, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "R$ 10,25";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.label1.Location = new System.Drawing.Point(1001, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vendas de Hoje";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.Location = new System.Drawing.Point(17, 399);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 20);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(76, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vendas (F8)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(287, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Produtos (F3)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(467, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cadastros de Clientes (F3)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 7F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(494, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Usuários do Sistema (F1)";
            // 
            // btnFluxoCaixa
            // 
            this.btnFluxoCaixa.BackgroundImage = global::SistemaVendas.Properties.Resources._6078603;
            this.btnFluxoCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFluxoCaixa.Location = new System.Drawing.Point(888, 123);
            this.btnFluxoCaixa.Name = "btnFluxoCaixa";
            this.btnFluxoCaixa.Size = new System.Drawing.Size(211, 197);
            this.btnFluxoCaixa.TabIndex = 12;
            // 
            // btnAberturaCaixa
            // 
            this.btnAberturaCaixa.BackgroundImage = global::SistemaVendas.Properties.Resources.índices;
            this.btnAberturaCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAberturaCaixa.Location = new System.Drawing.Point(671, 123);
            this.btnAberturaCaixa.Name = "btnAberturaCaixa";
            this.btnAberturaCaixa.Size = new System.Drawing.Size(211, 197);
            this.btnAberturaCaixa.TabIndex = 11;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackgroundImage = global::SistemaVendas.Properties.Resources.identification_id_student_card_icon_260nw_288673628_removebg_preview_1_;
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastro.Location = new System.Drawing.Point(454, 123);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(211, 197);
            this.btnCadastro.TabIndex = 10;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackgroundImage = global::SistemaVendas.Properties.Resources.c67aef3d02b7b2eb9cfb953fe776d224_pilha_de_caixas_de_papelao;
            this.btnEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEstoque.Location = new System.Drawing.Point(237, 123);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(211, 197);
            this.btnEstoque.TabIndex = 9;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            this.btnEstoque.Paint += new System.Windows.Forms.PaintEventHandler(this.btnEstoque_Paint);
            // 
            // btnVendas
            // 
            this.btnVendas.BackgroundImage = global::SistemaVendas.Properties.Resources.caixaRegistradora_removebg_preview;
            this.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVendas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVendas.Location = new System.Drawing.Point(20, 123);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(211, 197);
            this.btnVendas.TabIndex = 8;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            this.btnVendas.Paint += new System.Windows.Forms.PaintEventHandler(this.btnVendas_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(927, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fluxo de Caixa (F3)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(697, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 38);
            this.label7.TabIndex = 15;
            this.label7.Text = "Abertura e \r\nFechamento Caixa (F3)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFluxoCaixa);
            this.Controls.Add(this.btnAberturaCaixa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Menu";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 17);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Menu_KeyPress);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label17;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbluser;
        private ToolStripStatusLabel lblUsuario;
        private TextBox textBox1;
        private Label label1;
        private Button btnSair;
        private FlowLayoutPanel btnVendas;
        private FlowLayoutPanel btnEstoque;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel btnCadastro;
        private Label label4;
        private Label label5;
        private FlowLayoutPanel btnAberturaCaixa;
        private FlowLayoutPanel btnFluxoCaixa;
        private Label label6;
        private Label label7;
    }
}