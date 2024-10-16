namespace pruebaLoading.Formularios.frmPersonal.frmPago
{
    partial class pagoPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagoPersonal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMontoServ = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.lblComision = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.cmbTipPag = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.lblMontoServ);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpFecFin);
            this.groupBox1.Controls.Add(this.dtpFecIni);
            this.groupBox1.Controls.Add(this.lblComision);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblPago);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtComision);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSueldo);
            this.groupBox1.Controls.Add(this.cmbTipPag);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnCan);
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 248);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pago Personal";
            // 
            // lblMontoServ
            // 
            this.lblMontoServ.AutoSize = true;
            this.lblMontoServ.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMontoServ.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoServ.Location = new System.Drawing.Point(694, 102);
            this.lblMontoServ.Name = "lblMontoServ";
            this.lblMontoServ.Size = new System.Drawing.Size(44, 23);
            this.lblMontoServ.TabIndex = 84;
            this.lblMontoServ.Text = "0.00";
            this.lblMontoServ.TextChanged += new System.EventHandler(this.lblMontoServ_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(478, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 23);
            this.label10.TabIndex = 83;
            this.label10.Text = "Monto Total Servicios (S/.):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 82;
            this.label9.Text = "Hasta";
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecFin.Location = new System.Drawing.Point(64, 149);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(300, 26);
            this.dtpFecFin.TabIndex = 81;
            this.dtpFecFin.ValueChanged += new System.EventHandler(this.dtpFecFin_ValueChanged);
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecIni.Location = new System.Drawing.Point(64, 91);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(300, 26);
            this.dtpFecIni.TabIndex = 80;
            this.dtpFecIni.ValueChanged += new System.EventHandler(this.dtpFecIni_ValueChanged);
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblComision.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComision.Location = new System.Drawing.Point(694, 145);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(44, 23);
            this.lblComision.TabIndex = 79;
            this.lblComision.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 78;
            this.label2.Text = "Total de comisión (S/.):";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPago.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Location = new System.Drawing.Point(694, 189);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(44, 23);
            this.lblPago.TabIndex = 77;
            this.lblPago.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 23);
            this.label4.TabIndex = 76;
            this.label4.Text = "Total a Pagar (S/.):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(771, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 26);
            this.label5.TabIndex = 75;
            this.label5.Text = "%";
            // 
            // txtComision
            // 
            this.txtComision.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComision.Location = new System.Drawing.Point(703, 42);
            this.txtComision.MaxLength = 5;
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(66, 29);
            this.txtComision.TabIndex = 74;
            this.txtComision.Text = "0.00";
            this.txtComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtComision.TextChanged += new System.EventHandler(this.txtComision_TextChanged);
            this.txtComision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComision_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(608, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 73;
            this.label6.Text = "Comisión:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 72;
            this.label7.Text = "Sueldo (S/.):";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(523, 43);
            this.txtSueldo.MaxLength = 7;
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(78, 29);
            this.txtSueldo.TabIndex = 71;
            this.txtSueldo.Text = "0.00";
            this.txtSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSueldo.TextChanged += new System.EventHandler(this.txtSueldo_TextChanged);
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
            // 
            // cmbTipPag
            // 
            this.cmbTipPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipPag.FormattingEnabled = true;
            this.cmbTipPag.Items.AddRange(new object[] {
            "Sueldo",
            "Sueldo + comisión",
            "Comisión"});
            this.cmbTipPag.Location = new System.Drawing.Point(138, 42);
            this.cmbTipPag.Name = "cmbTipPag";
            this.cmbTipPag.Size = new System.Drawing.Size(226, 28);
            this.cmbTipPag.TabIndex = 70;
            this.cmbTipPag.SelectedIndexChanged += new System.EventHandler(this.cmbTipPag_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 69;
            this.label8.Text = "Tipo pago:";
            // 
            // btnCan
            // 
            this.btnCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCan.Location = new System.Drawing.Point(30, 199);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(118, 35);
            this.btnCan.TabIndex = 57;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(355, 199);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(111, 35);
            this.btnPagar.TabIndex = 56;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // pagoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 267);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(870, 306);
            this.MinimumSize = new System.Drawing.Size(870, 306);
            this.Name = "pagoPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Pago";
            this.Load += new System.EventHandler(this.pagoPersonal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipPag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label lblMontoServ;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtSueldo;
        public System.Windows.Forms.TextBox txtComision;
    }
}