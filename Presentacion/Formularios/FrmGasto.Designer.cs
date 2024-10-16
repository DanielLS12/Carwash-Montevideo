namespace Interfaz.Formularios
{
    partial class FrmGasto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Perfil = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGasto = new System.Windows.Forms.Label();
            this.btnElim = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPer = new System.Windows.Forms.TextBox();
            this.txtIdGast = new System.Windows.Forms.TextBox();
            this.chkAscDesc = new System.Windows.Forms.CheckBox();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkRan = new System.Windows.Forms.CheckBox();
            this.btnBusc = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrec2 = new System.Windows.Forms.TextBox();
            this.txtPrec1 = new System.Windows.Forms.TextBox();
            this.cmbPrec = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.chkFec = new System.Windows.Forms.CheckBox();
            this.lblGastTot = new System.Windows.Forms.Label();
            this.lblNumPag = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1237, 75);
            this.panelTitulo.TabIndex = 24;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.flowLayoutPanel2.Controls.Add(this.Perfil);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 75);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1237, 82);
            this.flowLayoutPanel2.TabIndex = 36;
            // 
            // Perfil
            // 
            this.Perfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Perfil.AutoSize = true;
            this.Perfil.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perfil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Perfil.Location = new System.Drawing.Point(3, 0);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(174, 61);
            this.Perfil.TabIndex = 0;
            this.Perfil.Text = "Gastos";
            this.Perfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 62;
            this.label2.Text = "Personal:";
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecIni.Location = new System.Drawing.Point(98, 111);
            this.dtpFecIni.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(312, 27);
            this.dtpFecIni.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 64;
            this.label3.Text = "Fecha:";
            // 
            // lblGasto
            // 
            this.lblGasto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGasto.AutoSize = true;
            this.lblGasto.Font = new System.Drawing.Font("Franklin Gothic Medium", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGasto.Location = new System.Drawing.Point(764, 167);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(253, 32);
            this.lblGasto.TabIndex = 73;
            this.lblGasto.Text = "Gastos encontrados: 0";
            // 
            // btnElim
            // 
            this.btnElim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElim.BackColor = System.Drawing.Color.Transparent;
            this.btnElim.Enabled = false;
            this.btnElim.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElim.Location = new System.Drawing.Point(309, 617);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(123, 54);
            this.btnElim.TabIndex = 78;
            this.btnElim.Text = "Eliminar";
            this.btnElim.UseVisualStyleBackColor = false;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(40, 617);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 54);
            this.btnAgregar.TabIndex = 76;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(491, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(733, 402);
            this.dataGridView1.TabIndex = 91;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPer);
            this.groupBox1.Controls.Add(this.txtIdGast);
            this.groupBox1.Controls.Add(this.chkAscDesc);
            this.groupBox1.Controls.Add(this.dtpFecFin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkRan);
            this.groupBox1.Controls.Add(this.btnBusc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrec2);
            this.groupBox1.Controls.Add(this.txtPrec1);
            this.groupBox1.Controls.Add(this.cmbPrec);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.chkFec);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFecIni);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(10, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 433);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // txtPer
            // 
            this.txtPer.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPer.Location = new System.Drawing.Point(126, 45);
            this.txtPer.MaxLength = 150;
            this.txtPer.Multiline = true;
            this.txtPer.Name = "txtPer";
            this.txtPer.Size = new System.Drawing.Size(275, 43);
            this.txtPer.TabIndex = 84;
            this.txtPer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPer_KeyPress);
            // 
            // txtIdGast
            // 
            this.txtIdGast.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdGast.Location = new System.Drawing.Point(322, 13);
            this.txtIdGast.Name = "txtIdGast";
            this.txtIdGast.Size = new System.Drawing.Size(139, 26);
            this.txtIdGast.TabIndex = 83;
            this.txtIdGast.Text = "0";
            this.txtIdGast.Visible = false;
            this.txtIdGast.TextChanged += new System.EventHandler(this.txtIdGast_TextChanged);
            // 
            // chkAscDesc
            // 
            this.chkAscDesc.AutoSize = true;
            this.chkAscDesc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAscDesc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chkAscDesc.Location = new System.Drawing.Point(13, 153);
            this.chkAscDesc.Name = "chkAscDesc";
            this.chkAscDesc.Size = new System.Drawing.Size(135, 25);
            this.chkAscDesc.TabIndex = 82;
            this.chkAscDesc.Text = "Descendente";
            this.chkAscDesc.UseVisualStyleBackColor = true;
            this.chkAscDesc.CheckedChanged += new System.EventHandler(this.chkAscDesc_CheckedChanged);
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecFin.Location = new System.Drawing.Point(98, 188);
            this.dtpFecFin.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(312, 27);
            this.dtpFecFin.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(233, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 80;
            this.label8.Text = "hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 79;
            this.label7.Text = "Máx";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 21);
            this.label6.TabIndex = 78;
            this.label6.Text = "Min";
            this.label6.Visible = false;
            // 
            // chkRan
            // 
            this.chkRan.AutoSize = true;
            this.chkRan.Enabled = false;
            this.chkRan.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRan.Location = new System.Drawing.Point(366, 279);
            this.chkRan.Name = "chkRan";
            this.chkRan.Size = new System.Drawing.Size(81, 25);
            this.chkRan.TabIndex = 77;
            this.chkRan.Text = "Rango";
            this.chkRan.UseVisualStyleBackColor = true;
            this.chkRan.Visible = false;
            this.chkRan.CheckedChanged += new System.EventHandler(this.chkRan_CheckedChanged);
            // 
            // btnBusc
            // 
            this.btnBusc.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusc.ForeColor = System.Drawing.Color.Black;
            this.btnBusc.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBusc.IconColor = System.Drawing.Color.Black;
            this.btnBusc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusc.IconSize = 30;
            this.btnBusc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusc.Location = new System.Drawing.Point(140, 379);
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.Size = new System.Drawing.Size(179, 37);
            this.btnBusc.TabIndex = 76;
            this.btnBusc.Text = "Buscar";
            this.btnBusc.UseVisualStyleBackColor = true;
            this.btnBusc.Click += new System.EventHandler(this.btnBusc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 31);
            this.label5.TabIndex = 75;
            this.label5.Text = "-";
            this.label5.Visible = false;
            // 
            // txtPrec2
            // 
            this.txtPrec2.Enabled = false;
            this.txtPrec2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrec2.Location = new System.Drawing.Point(271, 325);
            this.txtPrec2.MaxLength = 6;
            this.txtPrec2.Name = "txtPrec2";
            this.txtPrec2.Size = new System.Drawing.Size(100, 31);
            this.txtPrec2.TabIndex = 74;
            this.txtPrec2.Text = "0";
            this.txtPrec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrec2.Visible = false;
            this.txtPrec2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrec2_KeyPress);
            // 
            // txtPrec1
            // 
            this.txtPrec1.Enabled = false;
            this.txtPrec1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrec1.Location = new System.Drawing.Point(106, 325);
            this.txtPrec1.MaxLength = 6;
            this.txtPrec1.Name = "txtPrec1";
            this.txtPrec1.Size = new System.Drawing.Size(100, 31);
            this.txtPrec1.TabIndex = 73;
            this.txtPrec1.Text = "0";
            this.txtPrec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrec1.Visible = false;
            this.txtPrec1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrec1_KeyPress);
            // 
            // cmbPrec
            // 
            this.cmbPrec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrec.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrec.FormattingEnabled = true;
            this.cmbPrec.Items.AddRange(new object[] {
            "Seleccionar",
            "de mayor a menor",
            "de menor a mayor"});
            this.cmbPrec.Location = new System.Drawing.Point(105, 317);
            this.cmbPrec.Name = "cmbPrec";
            this.cmbPrec.Size = new System.Drawing.Size(214, 34);
            this.cmbPrec.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(20, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 71;
            this.label4.Text = "Gasto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(19, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 70;
            this.label1.Text = "Descripción:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(156, 239);
            this.txtDesc.MaxLength = 200;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(254, 55);
            this.txtDesc.TabIndex = 69;
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc_KeyPress);
            // 
            // chkFec
            // 
            this.chkFec.AutoSize = true;
            this.chkFec.Checked = true;
            this.chkFec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFec.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFec.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chkFec.Location = new System.Drawing.Point(407, 153);
            this.chkFec.Name = "chkFec";
            this.chkFec.Size = new System.Drawing.Size(54, 25);
            this.chkFec.TabIndex = 68;
            this.chkFec.Text = "ON";
            this.chkFec.UseVisualStyleBackColor = true;
            this.chkFec.CheckedChanged += new System.EventHandler(this.chkFec_CheckedChanged);
            // 
            // lblGastTot
            // 
            this.lblGastTot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGastTot.AutoSize = true;
            this.lblGastTot.Font = new System.Drawing.Font("Franklin Gothic Medium", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastTot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGastTot.Location = new System.Drawing.Point(494, 659);
            this.lblGastTot.Name = "lblGastTot";
            this.lblGastTot.Size = new System.Drawing.Size(87, 32);
            this.lblGastTot.TabIndex = 93;
            this.lblGastTot.Text = "label9";
            // 
            // lblNumPag
            // 
            this.lblNumPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumPag.AutoSize = true;
            this.lblNumPag.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPag.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumPag.Location = new System.Drawing.Point(692, 623);
            this.lblNumPag.Name = "lblNumPag";
            this.lblNumPag.Size = new System.Drawing.Size(50, 20);
            this.lblNumPag.TabIndex = 99;
            this.lblNumPag.Text = "label7";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(491, 617);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 32);
            this.btnAtras.TabIndex = 98;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSig
            // 
            this.btnSig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSig.Location = new System.Drawing.Point(598, 617);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(75, 32);
            this.btnSig.TabIndex = 97;
            this.btnSig.Text = ">";
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.AutoSize = true;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrint.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.IconSize = 36;
            this.btnPrint.Location = new System.Drawing.Point(1182, 649);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(42, 42);
            this.btnPrint.TabIndex = 100;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1237, 699);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblNumPag);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.lblGastTot);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmGasto";
            this.Text = "FrmGasto";
            this.Load += new System.EventHandler(this.FrmGasto_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label Perfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.CheckBox chkFec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrec2;
        private System.Windows.Forms.TextBox txtPrec1;
        private System.Windows.Forms.ComboBox cmbPrec;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnBusc;
        private System.Windows.Forms.CheckBox chkRan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkAscDesc;
        private System.Windows.Forms.TextBox txtIdGast;
        private System.Windows.Forms.Label lblGastTot;
        private System.Windows.Forms.TextBox txtPer;
        private System.Windows.Forms.Label lblNumPag;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSig;
        private FontAwesome.Sharp.IconButton btnPrint;
    }
}