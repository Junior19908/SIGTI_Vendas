using System.Windows.Forms;

namespace CadastroClientes
{
    partial class FormularioVendas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioVendas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.datagridVenda = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.btnVerificaCliente = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUm = new System.Windows.Forms.TextBox();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricaoItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.txtVendaCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClienteNovo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescontoPorcent = new System.Windows.Forms.TextBox();
            this.txtItensDoPedido = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbFormaPagamento1 = new System.Windows.Forms.ComboBox();
            this.cmbFormaPagamento2 = new System.Windows.Forms.ComboBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdOrcamento = new System.Windows.Forms.RadioButton();
            this.rdVenda = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtStatusBarCaixa = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtStatusCaixa = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTotalPago = new SistemaVendas.Classes.textValor();
            this.txtTotalBruto = new SistemaVendas.Classes.textValor();
            this.txtLiquido = new SistemaVendas.Classes.textValor();
            this.txtTroco = new SistemaVendas.Classes.textValor();
            this.txtValorPago2 = new SistemaVendas.Classes.textValor();
            this.txtValorPago1 = new SistemaVendas.Classes.textValor();
            this.btnExluirItem = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVenda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(1049, 57);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(958, 3);
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
            this.label17.Size = new System.Drawing.Size(215, 39);
            this.label17.TabIndex = 0;
            this.label17.Text = "Módulo de Vendas";
            // 
            // datagridVenda
            // 
            this.datagridVenda.AllowUserToAddRows = false;
            this.datagridVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.MEDIDA,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column9,
            this.Column10,
            this.Column8});
            this.datagridVenda.Location = new System.Drawing.Point(3, 16);
            this.datagridVenda.Name = "datagridVenda";
            this.datagridVenda.RowTemplate.Height = 25;
            this.datagridVenda.Size = new System.Drawing.Size(1043, 152);
            this.datagridVenda.TabIndex = 2;
            this.datagridVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridVenda_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "col_codProduto";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column1.HeaderText = "Código do Produto";
            this.Column1.Name = "Column1";
            this.Column1.Width = 123;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "col_descricaoProduto";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column2.HeaderText = "Descrição do Produto";
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // MEDIDA
            // 
            this.MEDIDA.DataPropertyName = "col_unidadeMedida";
            this.MEDIDA.HeaderText = "Um.";
            this.MEDIDA.Name = "MEDIDA";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.DataPropertyName = "col_quantidadeVendaProduto";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column4.HeaderText = "Qtde";
            this.Column4.Name = "Column4";
            this.Column4.Width = 56;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.DataPropertyName = "col_valorProdutoUnidade";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column3.HeaderText = "Valor Un.";
            this.Column3.Name = "Column3";
            this.Column3.Width = 63;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.DataPropertyName = "col_valorTotalProduto";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column5.HeaderText = "Total Bruto";
            this.Column5.Name = "Column5";
            this.Column5.Width = 63;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "col_porcentagemProduto";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "%";
            dataGridViewCellStyle14.NullValue = null;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column9.HeaderText = "% Desc";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "col_valorDesconto";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "C2";
            this.Column10.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column10.HeaderText = "R$ Desc";
            this.Column10.Name = "Column10";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column8.DataPropertyName = "col_valorLiquidoProduto";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "C2";
            this.Column8.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column8.HeaderText = "Total Líquido";
            this.Column8.Name = "Column8";
            this.Column8.Width = 101;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbVendedor);
            this.groupBox1.Controls.Add(this.btnVerificaCliente);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPrecoVenda);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUm);
            this.groupBox1.Controls.Add(this.btnAdicionarItem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDescricaoItem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCodBarras);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQtde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.txtVendaCod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(17, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(693, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Vendedor:";
            // 
            // cbVendedor
            // 
            this.cbVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVendedor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbVendedor.Enabled = false;
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(755, 10);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(135, 23);
            this.cbVendedor.TabIndex = 26;
            // 
            // btnVerificaCliente
            // 
            this.btnVerificaCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerificaCliente.BackgroundImage")));
            this.btnVerificaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerificaCliente.Location = new System.Drawing.Point(572, 9);
            this.btnVerificaCliente.Name = "btnVerificaCliente";
            this.btnVerificaCliente.Size = new System.Drawing.Size(33, 26);
            this.btnVerificaCliente.TabIndex = 14;
            this.btnVerificaCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnVerificaCliente_MouseClick);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(611, 9);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(82, 26);
            this.textBox6.TabIndex = 25;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code SemiBold", 7F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(857, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Preço de Venda";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPrecoVenda.Location = new System.Drawing.Point(861, 54);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(81, 20);
            this.txtPrecoVenda.TabIndex = 23;
            this.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code SemiBold", 7F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(797, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Unidade";
            // 
            // txtUm
            // 
            this.txtUm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtUm.Location = new System.Drawing.Point(789, 54);
            this.txtUm.Name = "txtUm";
            this.txtUm.Size = new System.Drawing.Size(66, 20);
            this.txtUm.TabIndex = 21;
            this.txtUm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarItem.Location = new System.Drawing.Point(953, 34);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(90, 40);
            this.btnAdicionarItem.TabIndex = 8;
            this.btnAdicionarItem.Text = "&Adicionar";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code SemiBold", 7F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(502, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Descrição do Item";
            // 
            // txtDescricaoItem
            // 
            this.txtDescricaoItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtDescricaoItem.Location = new System.Drawing.Point(331, 54);
            this.txtDescricaoItem.Name = "txtDescricaoItem";
            this.txtDescricaoItem.Size = new System.Drawing.Size(452, 20);
            this.txtDescricaoItem.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code SemiBold", 7F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(115, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Código de Barras - (F1 Localizar)";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtCodBarras.Location = new System.Drawing.Point(112, 54);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(213, 20);
            this.txtCodBarras.TabIndex = 17;
            this.txtCodBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodBarras.Enter += new System.EventHandler(this.txtCodBarras_Enter);
            this.txtCodBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodBarras_KeyDown);
            this.txtCodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBarras_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 7F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(39, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Qtde";
            // 
            // txtQtde
            // 
            this.txtQtde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtQtde.Location = new System.Drawing.Point(6, 54);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 15;
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(61, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(227, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(288, 10);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(277, 23);
            this.cbCliente.TabIndex = 9;
            // 
            // txtVendaCod
            // 
            this.txtVendaCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendaCod.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtVendaCod.Enabled = false;
            this.txtVendaCod.Location = new System.Drawing.Point(957, 11);
            this.txtVendaCod.Name = "txtVendaCod";
            this.txtVendaCod.Size = new System.Drawing.Size(86, 20);
            this.txtVendaCod.TabIndex = 1;
            this.txtVendaCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(896, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda Nº:";
            // 
            // btnClienteNovo
            // 
            this.btnClienteNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClienteNovo.Location = new System.Drawing.Point(970, 448);
            this.btnClienteNovo.Name = "btnClienteNovo";
            this.btnClienteNovo.Size = new System.Drawing.Size(96, 52);
            this.btnClienteNovo.TabIndex = 11;
            this.btnClienteNovo.Text = "&Cliente Novo?";
            this.btnClienteNovo.UseVisualStyleBackColor = true;
            this.btnClienteNovo.Click += new System.EventHandler(this.btnClienteNovo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(439, 554);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 20);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.datagridVenda);
            this.groupBox2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(17, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1049, 174);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.Location = new System.Drawing.Point(369, 554);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(64, 20);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(62, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "TOTAL BRUTO";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(249, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "DESCONTO";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(398, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "TOTAL LIQUIDO";
            // 
            // txtDescontoPorcent
            // 
            this.txtDescontoPorcent.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtDescontoPorcent.Location = new System.Drawing.Point(209, 408);
            this.txtDescontoPorcent.Multiline = true;
            this.txtDescontoPorcent.Name = "txtDescontoPorcent";
            this.txtDescontoPorcent.Size = new System.Drawing.Size(160, 31);
            this.txtDescontoPorcent.TabIndex = 36;
            this.txtDescontoPorcent.Text = "0%";
            this.txtDescontoPorcent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtItensDoPedido
            // 
            this.txtItensDoPedido.Enabled = false;
            this.txtItensDoPedido.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtItensDoPedido.Location = new System.Drawing.Point(541, 408);
            this.txtItensDoPedido.Multiline = true;
            this.txtItensDoPedido.Name = "txtItensDoPedido";
            this.txtItensDoPedido.Size = new System.Drawing.Size(160, 31);
            this.txtItensDoPedido.TabIndex = 39;
            this.txtItensDoPedido.Text = "0";
            this.txtItensDoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(558, 387);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 18);
            this.label13.TabIndex = 38;
            this.label13.Text = "TOTAL DE ITENS";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(742, 387);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 18);
            this.label14.TabIndex = 40;
            this.label14.Text = "TOTAL PAGO";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(947, 387);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 18);
            this.label15.TabIndex = 42;
            this.label15.Text = "TROCO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtValorPago2);
            this.groupBox3.Controls.Add(this.txtValorPago1);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cmbFormaPagamento1);
            this.groupBox3.Controls.Add(this.cmbFormaPagamento2);
            this.groupBox3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(20, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 129);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Forma de Pagamento";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cascadia Code SemiBold", 7F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(41, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 52;
            this.label19.Text = "2ª Forma";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cascadia Code SemiBold", 7F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(242, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 13);
            this.label20.TabIndex = 51;
            this.label20.Text = "Valor Pago (2)";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cascadia Code SemiBold", 7F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(41, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "1ª Forma";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cascadia Code SemiBold", 7F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(242, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Valor Pago (1)";
            // 
            // cmbFormaPagamento1
            // 
            this.cmbFormaPagamento1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormaPagamento1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbFormaPagamento1.FormattingEnabled = true;
            this.cmbFormaPagamento1.Items.AddRange(new object[] {
            "Á VISTA",
            "CARTÃO DE CRÉDITO",
            "CARTÃO DE DÉBITO",
            "BOLETO",
            "CARNÊ"});
            this.cmbFormaPagamento1.Location = new System.Drawing.Point(6, 32);
            this.cmbFormaPagamento1.Name = "cmbFormaPagamento1";
            this.cmbFormaPagamento1.Size = new System.Drawing.Size(126, 23);
            this.cmbFormaPagamento1.TabIndex = 45;
            // 
            // cmbFormaPagamento2
            // 
            this.cmbFormaPagamento2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormaPagamento2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbFormaPagamento2.FormattingEnabled = true;
            this.cmbFormaPagamento2.Items.AddRange(new object[] {
            "Á VISTA",
            "CARTÃO DE CRÉDITO",
            "CARTÃO DE DÉBITO",
            "BOLETO",
            "CARNÊ"});
            this.cmbFormaPagamento2.Location = new System.Drawing.Point(6, 79);
            this.cmbFormaPagamento2.Name = "cmbFormaPagamento2";
            this.cmbFormaPagamento2.Size = new System.Drawing.Size(126, 23);
            this.cmbFormaPagamento2.TabIndex = 49;
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVender.Location = new System.Drawing.Point(970, 506);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(96, 52);
            this.btnVender.TabIndex = 45;
            this.btnVender.Text = "&Finalizar Venda";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdOrcamento);
            this.groupBox4.Controls.Add(this.rdVenda);
            this.groupBox4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 7F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(375, 445);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 62);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operação Destinada";
            // 
            // rdOrcamento
            // 
            this.rdOrcamento.AutoSize = true;
            this.rdOrcamento.Location = new System.Drawing.Point(24, 34);
            this.rdOrcamento.Name = "rdOrcamento";
            this.rdOrcamento.Size = new System.Drawing.Size(115, 17);
            this.rdOrcamento.TabIndex = 1;
            this.rdOrcamento.Text = "&Criar Orçamento";
            this.rdOrcamento.UseVisualStyleBackColor = true;
            // 
            // rdVenda
            // 
            this.rdVenda.AutoSize = true;
            this.rdVenda.Checked = true;
            this.rdVenda.Location = new System.Drawing.Point(24, 19);
            this.rdVenda.Name = "rdVenda";
            this.rdVenda.Size = new System.Drawing.Size(91, 17);
            this.rdVenda.TabIndex = 0;
            this.rdVenda.TabStop = true;
            this.rdVenda.Text = "&Criar Venda";
            this.rdVenda.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(869, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 52);
            this.button1.TabIndex = 47;
            this.button1.Text = "&Imprimir Recibo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 2000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(541, 448);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 17);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.Text = "Desabilitar Timer";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.txtStatusBarCaixa,
            this.toolStripStatusLabel1,
            this.txtStatusCaixa});
            this.statusStrip1.Location = new System.Drawing.Point(17, 581);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1049, 22);
            this.statusStrip1.TabIndex = 54;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel2.Text = "Nome do Caixa:";
            // 
            // txtStatusBarCaixa
            // 
            this.txtStatusBarCaixa.BackColor = System.Drawing.Color.Red;
            this.txtStatusBarCaixa.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.txtStatusBarCaixa.Name = "txtStatusBarCaixa";
            this.txtStatusBarCaixa.Size = new System.Drawing.Size(37, 17);
            this.txtStatusBarCaixa.Text = "Caixa";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabel1.Text = "Status do Caixa:";
            // 
            // txtStatusCaixa
            // 
            this.txtStatusCaixa.BackColor = System.Drawing.Color.Lime;
            this.txtStatusCaixa.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.txtStatusCaixa.Name = "txtStatusCaixa";
            this.txtStatusCaixa.Size = new System.Drawing.Size(43, 17);
            this.txtStatusCaixa.Text = "Aberto";
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Enabled = false;
            this.txtTotalPago.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotalPago.Location = new System.Drawing.Point(708, 408);
            this.txtTotalPago.Multiline = true;
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(170, 31);
            this.txtTotalPago.TabIndex = 53;
            this.txtTotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalBruto
            // 
            this.txtTotalBruto.Enabled = false;
            this.txtTotalBruto.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotalBruto.Location = new System.Drawing.Point(23, 408);
            this.txtTotalBruto.Multiline = true;
            this.txtTotalBruto.Name = "txtTotalBruto";
            this.txtTotalBruto.Size = new System.Drawing.Size(180, 31);
            this.txtTotalBruto.TabIndex = 52;
            this.txtTotalBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLiquido
            // 
            this.txtLiquido.BackColor = System.Drawing.SystemColors.Info;
            this.txtLiquido.Enabled = false;
            this.txtLiquido.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtLiquido.Location = new System.Drawing.Point(375, 408);
            this.txtLiquido.Multiline = true;
            this.txtLiquido.Name = "txtLiquido";
            this.txtLiquido.Size = new System.Drawing.Size(160, 31);
            this.txtLiquido.TabIndex = 51;
            this.txtLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTroco
            // 
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtTroco.Location = new System.Drawing.Point(884, 408);
            this.txtTroco.Multiline = true;
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(180, 31);
            this.txtTroco.TabIndex = 50;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorPago2
            // 
            this.txtValorPago2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtValorPago2.Location = new System.Drawing.Point(237, 79);
            this.txtValorPago2.Name = "txtValorPago2";
            this.txtValorPago2.Size = new System.Drawing.Size(100, 20);
            this.txtValorPago2.TabIndex = 49;
            this.txtValorPago2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorPago2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorPago2_KeyDown);
            // 
            // txtValorPago1
            // 
            this.txtValorPago1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtValorPago1.Location = new System.Drawing.Point(237, 35);
            this.txtValorPago1.Name = "txtValorPago1";
            this.txtValorPago1.Size = new System.Drawing.Size(100, 20);
            this.txtValorPago1.TabIndex = 49;
            this.txtValorPago1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorPago1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorPago1_KeyDown_1);
            // 
            // btnExluirItem
            // 
            this.btnExluirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExluirItem.Location = new System.Drawing.Point(869, 506);
            this.btnExluirItem.Name = "btnExluirItem";
            this.btnExluirItem.Size = new System.Drawing.Size(96, 52);
            this.btnExluirItem.TabIndex = 55;
            this.btnExluirItem.Text = "&Excluir Item";
            this.btnExluirItem.UseVisualStyleBackColor = true;
            this.btnExluirItem.Click += new System.EventHandler(this.btnExluirItem_Click);
            // 
            // FormularioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 620);
            this.Controls.Add(this.btnExluirItem);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtTotalPago);
            this.Controls.Add(this.txtTotalBruto);
            this.Controls.Add(this.txtLiquido);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtItensDoPedido);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDescontoPorcent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClienteNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioVendas";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 17);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.FormularioVendas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVenda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Label label17;
        private DataGridView datagridVenda;
        private GroupBox groupBox1;
        private Button btnLimpar;
        private TextBox txtVendaCod;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnClienteNovo;
        private Label label4;
        private ComboBox cbCliente;
        private Button btnAdicionarItem;
        private Button btnVoltar;
        private PictureBox pictureBox2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private FlowLayoutPanel btnVerificaCliente;
        private Label label9;
        private ComboBox cbVendedor;
        private TextBox textBox6;
        private Label label8;
        private TextBox txtPrecoVenda;
        private Label label7;
        private TextBox txtUm;
        private Label label6;
        private TextBox txtDescricaoItem;
        private Label label5;
        private TextBox txtCodBarras;
        private Label label3;
        private TextBox txtQtde;
        private Label label11;
        private Label label10;
        private Label label12;
        private TextBox txtDescontoPorcent;
        private TextBox txtItensDoPedido;
        private Label label13;
        private Label label14;
        private Label label15;
        private GroupBox groupBox3;
        private Label label19;
        private Label label20;
        private Label label18;
        private Label label16;
        private ComboBox cmbFormaPagamento1;
        private ComboBox cmbFormaPagamento2;
        private Button btnVender;
        private GroupBox groupBox4;
        private RadioButton rdOrcamento;
        private RadioButton rdVenda;
        private Button button1;
        private Timer refreshTimer;
        private CheckBox checkBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn MEDIDA;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column8;
        private SistemaVendas.Classes.textValor txtValorPago2;
        private SistemaVendas.Classes.textValor txtValorPago1;
        private SistemaVendas.Classes.textValor txtTroco;
        private SistemaVendas.Classes.textValor txtLiquido;
        private SistemaVendas.Classes.textValor txtTotalBruto;
        private SistemaVendas.Classes.textValor txtTotalPago;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel txtStatusBarCaixa;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel txtStatusCaixa;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Button btnExluirItem;
    }
}