namespace Interfaz.Formularios
{
    partial class FrmPersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Perfil = new System.Windows.Forms.Label();
            this.btnContr = new System.Windows.Forms.Button();
            this.lblPerson = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdPer = new System.Windows.Forms.TextBox();
            this.cmbTipPag = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPer = new System.Windows.Forms.TextBox();
            this.cmbEst = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBusc = new FontAwesome.Sharp.IconButton();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOcup = new System.Windows.Forms.ComboBox();
            this.btnAsist = new System.Windows.Forms.Button();
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
            this.panelTitulo.Size = new System.Drawing.Size(1096, 69);
            this.panelTitulo.TabIndex = 22;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.flowLayoutPanel2.Controls.Add(this.Perfil);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 69);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1096, 76);
            this.flowLayoutPanel2.TabIndex = 34;
            // 
            // Perfil
            // 
            this.Perfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Perfil.AutoSize = true;
            this.Perfil.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold);
            this.Perfil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Perfil.Location = new System.Drawing.Point(3, 0);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(216, 61);
            this.Perfil.TabIndex = 0;
            this.Perfil.Text = "Personal";
            this.Perfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContr
            // 
            this.btnContr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnContr.BackColor = System.Drawing.Color.Transparent;
            this.btnContr.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContr.ForeColor = System.Drawing.Color.Black;
            this.btnContr.Location = new System.Drawing.Point(51, 581);
            this.btnContr.Name = "btnContr";
            this.btnContr.Size = new System.Drawing.Size(123, 50);
            this.btnContr.TabIndex = 85;
            this.btnContr.Text = "Contratar";
            this.btnContr.UseVisualStyleBackColor = false;
            this.btnContr.Click += new System.EventHandler(this.btnContr_Click);
            // 
            // lblPerson
            // 
            this.lblPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Franklin Gothic Medium", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPerson.Location = new System.Drawing.Point(634, 157);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(274, 32);
            this.lblPerson.TabIndex = 88;
            this.lblPerson.Text = "Personal encontrados: 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(651, 439);
            this.dataGridView1.TabIndex = 90;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(20, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 56;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 54;
            this.label3.Text = "Personal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(4, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ocupación:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdPer);
            this.groupBox2.Controls.Add(this.cmbTipPag);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPer);
            this.groupBox2.Controls.Add(this.cmbEst);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnBusc);
            this.groupBox2.Controls.Add(this.txtCor);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbOcup);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 415);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda";
            // 
            // txtIdPer
            // 
            this.txtIdPer.Location = new System.Drawing.Point(315, 14);
            this.txtIdPer.Name = "txtIdPer";
            this.txtIdPer.Size = new System.Drawing.Size(100, 35);
            this.txtIdPer.TabIndex = 92;
            this.txtIdPer.Text = "0";
            this.txtIdPer.Visible = false;
            // 
            // cmbTipPag
            // 
            this.cmbTipPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipPag.FormattingEnabled = true;
            this.cmbTipPag.Items.AddRange(new object[] {
            "Seleccionar",
            "Sueldo",
            "Sueldo + comisión",
            "Comisión"});
            this.cmbTipPag.Location = new System.Drawing.Point(122, 306);
            this.cmbTipPag.Name = "cmbTipPag";
            this.cmbTipPag.Size = new System.Drawing.Size(239, 33);
            this.cmbTipPag.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(11, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 26);
            this.label6.TabIndex = 83;
            this.label6.Text = "Tipo pago:";
            // 
            // txtPer
            // 
            this.txtPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPer.Location = new System.Drawing.Point(122, 38);
            this.txtPer.MaxLength = 200;
            this.txtPer.Multiline = true;
            this.txtPer.Name = "txtPer";
            this.txtPer.Size = new System.Drawing.Size(270, 46);
            this.txtPer.TabIndex = 82;
            this.txtPer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPer_KeyPress);
            // 
            // cmbEst
            // 
            this.cmbEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEst.FormattingEnabled = true;
            this.cmbEst.Items.AddRange(new object[] {
            "Contratado",
            "Despedido"});
            this.cmbEst.Location = new System.Drawing.Point(122, 259);
            this.cmbEst.Name = "cmbEst";
            this.cmbEst.Size = new System.Drawing.Size(208, 33);
            this.cmbEst.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(36, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 78;
            this.label5.Text = "Estado:";
            // 
            // btnBusc
            // 
            this.btnBusc.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusc.ForeColor = System.Drawing.Color.Black;
            this.btnBusc.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBusc.IconColor = System.Drawing.Color.Black;
            this.btnBusc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusc.IconSize = 30;
            this.btnBusc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusc.Location = new System.Drawing.Point(122, 364);
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.Size = new System.Drawing.Size(179, 34);
            this.btnBusc.TabIndex = 77;
            this.btnBusc.Text = "Buscar";
            this.btnBusc.UseVisualStyleBackColor = true;
            this.btnBusc.Click += new System.EventHandler(this.btnBusc_Click);
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(123, 211);
            this.txtCor.MaxLength = 150;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(207, 31);
            this.txtCor.TabIndex = 63;
            this.txtCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCor_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(123, 158);
            this.txtTel.MaxLength = 9;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(207, 31);
            this.txtTel.TabIndex = 62;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(34, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 60;
            this.label2.Text = "Correo:";
            // 
            // cmbOcup
            // 
            this.cmbOcup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOcup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOcup.FormattingEnabled = true;
            this.cmbOcup.Location = new System.Drawing.Point(122, 104);
            this.cmbOcup.Name = "cmbOcup";
            this.cmbOcup.Size = new System.Drawing.Size(207, 33);
            this.cmbOcup.TabIndex = 59;
            // 
            // btnAsist
            // 
            this.btnAsist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAsist.BackColor = System.Drawing.Color.Transparent;
            this.btnAsist.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsist.ForeColor = System.Drawing.Color.Black;
            this.btnAsist.Location = new System.Drawing.Point(262, 580);
            this.btnAsist.Name = "btnAsist";
            this.btnAsist.Size = new System.Drawing.Size(123, 50);
            this.btnAsist.TabIndex = 92;
            this.btnAsist.Text = "Asistencias";
            this.btnAsist.UseVisualStyleBackColor = false;
            this.btnAsist.Click += new System.EventHandler(this.btnAsist_Click);
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1096, 642);
            this.Controls.Add(this.btnAsist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.btnContr);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmPersonal";
            this.Text = "FrmPersonal";
            this.Load += new System.EventHandler(this.FrmPersonal_Load);
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
        private System.Windows.Forms.Button btnContr;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbOcup;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnBusc;
        private System.Windows.Forms.ComboBox cmbEst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPer;
        private System.Windows.Forms.ComboBox cmbTipPag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdPer;
        private System.Windows.Forms.Button btnAsist;
    }
}