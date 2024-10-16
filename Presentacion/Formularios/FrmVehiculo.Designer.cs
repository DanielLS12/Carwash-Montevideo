namespace Interfaz.Formularios
{
    partial class FrmVehiculo
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
            this.txtPlac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCantVeh = new System.Windows.Forms.Label();
            this.btnAgre = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdVeh = new System.Windows.Forms.TextBox();
            this.btnBusc = new FontAwesome.Sharp.IconButton();
            this.lblNumPag = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1120, 75);
            this.panelTitulo.TabIndex = 18;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.flowLayoutPanel2.Controls.Add(this.Perfil);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 75);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1120, 82);
            this.flowLayoutPanel2.TabIndex = 30;
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
            this.Perfil.Size = new System.Drawing.Size(232, 61);
            this.Perfil.TabIndex = 0;
            this.Perfil.Text = "Vehiculos";
            this.Perfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlac
            // 
            this.txtPlac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlac.Location = new System.Drawing.Point(147, 44);
            this.txtPlac.MaxLength = 7;
            this.txtPlac.Multiline = true;
            this.txtPlac.Name = "txtPlac";
            this.txtPlac.Size = new System.Drawing.Size(226, 30);
            this.txtPlac.TabIndex = 49;
            this.txtPlac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlac_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 30);
            this.label2.TabIndex = 48;
            this.label2.Text = "Placa:";
            // 
            // cmbCate
            // 
            this.cmbCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCate.FormattingEnabled = true;
            this.cmbCate.Location = new System.Drawing.Point(147, 116);
            this.cmbCate.Name = "cmbCate";
            this.cmbCate.Size = new System.Drawing.Size(226, 32);
            this.cmbCate.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(22, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 50;
            this.label1.Text = "Categoria:";
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
            this.dataGridView1.Location = new System.Drawing.Point(530, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(560, 482);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblCantVeh
            // 
            this.lblCantVeh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantVeh.AutoSize = true;
            this.lblCantVeh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantVeh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantVeh.Location = new System.Drawing.Point(670, 170);
            this.lblCantVeh.Name = "lblCantVeh";
            this.lblCantVeh.Size = new System.Drawing.Size(273, 30);
            this.lblCantVeh.TabIndex = 71;
            this.lblCantVeh.Text = "Vehiculos encontrados: 0";
            // 
            // btnAgre
            // 
            this.btnAgre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgre.BackColor = System.Drawing.Color.Transparent;
            this.btnAgre.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgre.Location = new System.Drawing.Point(202, 635);
            this.btnAgre.Name = "btnAgre";
            this.btnAgre.Size = new System.Drawing.Size(123, 54);
            this.btnAgre.TabIndex = 73;
            this.btnAgre.Text = "Agregar";
            this.btnAgre.UseVisualStyleBackColor = false;
            this.btnAgre.Click += new System.EventHandler(this.btnAgre_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.txtIdVeh);
            this.groupBox2.Controls.Add(this.btnBusc);
            this.groupBox2.Controls.Add(this.txtPlac);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbCate);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(13, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 275);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda";
            // 
            // txtIdVeh
            // 
            this.txtIdVeh.Location = new System.Drawing.Point(388, 30);
            this.txtIdVeh.Name = "txtIdVeh";
            this.txtIdVeh.Size = new System.Drawing.Size(73, 31);
            this.txtIdVeh.TabIndex = 56;
            this.txtIdVeh.Text = "0";
            this.txtIdVeh.Visible = false;
            // 
            // btnBusc
            // 
            this.btnBusc.ForeColor = System.Drawing.Color.Black;
            this.btnBusc.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBusc.IconColor = System.Drawing.Color.Black;
            this.btnBusc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusc.IconSize = 30;
            this.btnBusc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusc.Location = new System.Drawing.Point(162, 207);
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.Size = new System.Drawing.Size(179, 37);
            this.btnBusc.TabIndex = 52;
            this.btnBusc.Text = "Buscar";
            this.btnBusc.UseVisualStyleBackColor = true;
            this.btnBusc.Click += new System.EventHandler(this.btnBusc_Click);
            // 
            // lblNumPag
            // 
            this.lblNumPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumPag.AutoSize = true;
            this.lblNumPag.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPag.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumPag.Location = new System.Drawing.Point(731, 709);
            this.lblNumPag.Name = "lblNumPag";
            this.lblNumPag.Size = new System.Drawing.Size(50, 20);
            this.lblNumPag.TabIndex = 99;
            this.lblNumPag.Text = "label7";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(530, 703);
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
            this.btnSig.Location = new System.Drawing.Point(637, 703);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(75, 32);
            this.btnSig.TabIndex = 97;
            this.btnSig.Text = ">";
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1120, 747);
            this.Controls.Add(this.lblNumPag);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAgre);
            this.Controls.Add(this.lblCantVeh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmVehiculo";
            this.Text = "FrmVehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label Perfil;
        private System.Windows.Forms.TextBox txtPlac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgre;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnBusc;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label lblCantVeh;
        private System.Windows.Forms.TextBox txtIdVeh;
        private System.Windows.Forms.Label lblNumPag;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSig;
    }
}