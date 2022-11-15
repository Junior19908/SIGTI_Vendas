namespace SistemaVendas.Vendas.Estoque
{
    partial class CadastroGrupoSub
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGravarGrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridViewGrupo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGravarSubGrupo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtGridViewSubGrupo = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubGrupo = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewGrupo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewSubGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 57);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::SistemaVendas.Properties.Resources.logo_ti;
            this.pictureBox2.Location = new System.Drawing.Point(948, 9);
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
            this.label17.Size = new System.Drawing.Size(624, 39);
            this.label17.TabIndex = 0;
            this.label17.Text = "Módulo de Cadastro de Grupo e Sub-Grupo de Materiais";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGravarGrupo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtGridViewGrupo);
            this.groupBox1.Controls.Add(this.txtGrupo);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(20, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 203);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo de Material";
            // 
            // btnGravarGrupo
            // 
            this.btnGravarGrupo.Location = new System.Drawing.Point(442, 16);
            this.btnGravarGrupo.Name = "btnGravarGrupo";
            this.btnGravarGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnGravarGrupo.TabIndex = 3;
            this.btnGravarGrupo.Text = "&Gravar";
            this.btnGravarGrupo.UseVisualStyleBackColor = true;
            this.btnGravarGrupo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição do Grupo:";
            // 
            // dtGridViewGrupo
            // 
            this.dtGridViewGrupo.AllowUserToAddRows = false;
            this.dtGridViewGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewGrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtGridViewGrupo.Location = new System.Drawing.Point(6, 71);
            this.dtGridViewGrupo.Name = "dtGridViewGrupo";
            this.dtGridViewGrupo.Size = new System.Drawing.Size(511, 126);
            this.dtGridViewGrupo.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Código";
            this.Column1.HeaderText = "Código do Grupo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "col_descricaoGrupo";
            this.Column2.HeaderText = "Descrição do Grupo";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(133, 45);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(384, 20);
            this.txtGrupo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGravarSubGrupo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtGridViewSubGrupo);
            this.groupBox2.Controls.Add(this.txtSubGrupo);
            this.groupBox2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(549, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 203);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sub-Grupo de Material";
            // 
            // btnGravarSubGrupo
            // 
            this.btnGravarSubGrupo.Location = new System.Drawing.Point(430, 16);
            this.btnGravarSubGrupo.Name = "btnGravarSubGrupo";
            this.btnGravarSubGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnGravarSubGrupo.TabIndex = 4;
            this.btnGravarSubGrupo.Text = "&Gravar";
            this.btnGravarSubGrupo.UseVisualStyleBackColor = true;
            this.btnGravarSubGrupo.Click += new System.EventHandler(this.btnGravarSubGrupo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição do Sub-Grupo:";
            // 
            // dtGridViewSubGrupo
            // 
            this.dtGridViewSubGrupo.AllowUserToAddRows = false;
            this.dtGridViewSubGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewSubGrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dtGridViewSubGrupo.Location = new System.Drawing.Point(6, 71);
            this.dtGridViewSubGrupo.Name = "dtGridViewSubGrupo";
            this.dtGridViewSubGrupo.Size = new System.Drawing.Size(499, 126);
            this.dtGridViewSubGrupo.TabIndex = 1;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Código";
            this.Column3.HeaderText = "Código do Sub-Grupo";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "col_descricaoSubGrupo";
            this.Column4.HeaderText = "Descrição do Sub-Grupo";
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // txtSubGrupo
            // 
            this.txtSubGrupo.Location = new System.Drawing.Point(157, 45);
            this.txtSubGrupo.Name = "txtSubGrupo";
            this.txtSubGrupo.Size = new System.Drawing.Size(348, 20);
            this.txtSubGrupo.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(985, 341);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CadastroGrupoSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 374);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "CadastroGrupoSub";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewGrupo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewSubGrupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridViewGrupo;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtGridViewSubGrupo;
        private System.Windows.Forms.TextBox txtSubGrupo;
        private System.Windows.Forms.Button btnGravarGrupo;
        private System.Windows.Forms.Button btnGravarSubGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnClose;
    }
}