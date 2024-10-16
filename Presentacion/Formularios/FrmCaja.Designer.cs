namespace Interfaz.Formularios
{
    partial class FrmCaja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Perfil = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEgreso = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCantIngre = new System.Windows.Forms.Label();
            this.lblCantEgre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblMontoAnt = new System.Windows.Forms.Label();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1207, 75);
            this.panelTitulo.TabIndex = 19;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.flowLayoutPanel2.Controls.Add(this.Perfil);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 75);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1207, 82);
            this.flowLayoutPanel2.TabIndex = 31;
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
            this.Perfil.Size = new System.Drawing.Size(123, 61);
            this.Perfil.TabIndex = 0;
            this.Perfil.Text = "Caja";
            this.Perfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(8, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 32);
            this.label7.TabIndex = 73;
            this.label7.Text = "Saldo del dia anterior: S/.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(589, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 43);
            this.label2.TabIndex = 77;
            this.label2.Text = "Egreso";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(140, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 43);
            this.label3.TabIndex = 78;
            this.label3.Text = "Ingreso";
            // 
            // lblIngreso
            // 
            this.lblIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIngreso.Location = new System.Drawing.Point(1066, 480);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(24, 26);
            this.lblIngreso.TabIndex = 84;
            this.lblIngreso.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(881, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 32);
            this.label6.TabIndex = 83;
            this.label6.Text = "Total Ingreso: S/.";
            // 
            // lblEgreso
            // 
            this.lblEgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEgreso.AutoSize = true;
            this.lblEgreso.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgreso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEgreso.Location = new System.Drawing.Point(1068, 537);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(24, 26);
            this.lblEgreso.TabIndex = 86;
            this.lblEgreso.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(891, 533);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 32);
            this.label10.TabIndex = 85;
            this.label10.Text = "Total Egreso: S/.";
            // 
            // lblMonto
            // 
            this.lblMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMonto.Location = new System.Drawing.Point(1069, 596);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(24, 26);
            this.lblMonto.TabIndex = 88;
            this.lblMonto.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(907, 592);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 32);
            this.label12.TabIndex = 87;
            this.label12.Text = "Saldo neto: S/.";
            // 
            // lblCantIngre
            // 
            this.lblCantIngre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCantIngre.AutoEllipsis = true;
            this.lblCantIngre.AutoSize = true;
            this.lblCantIngre.Font = new System.Drawing.Font("Franklin Gothic Medium", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantIngre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantIngre.Location = new System.Drawing.Point(165, 647);
            this.lblCantIngre.Name = "lblCantIngre";
            this.lblCantIngre.Size = new System.Drawing.Size(29, 32);
            this.lblCantIngre.TabIndex = 90;
            this.lblCantIngre.Text = "0";
            this.lblCantIngre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantEgre
            // 
            this.lblCantEgre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantEgre.AutoEllipsis = true;
            this.lblCantEgre.AutoSize = true;
            this.lblCantEgre.Font = new System.Drawing.Font("Franklin Gothic Medium", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantEgre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantEgre.Location = new System.Drawing.Point(617, 647);
            this.lblCantEgre.Name = "lblCantEgre";
            this.lblCantEgre.Size = new System.Drawing.Size(29, 32);
            this.lblCantEgre.TabIndex = 91;
            this.lblCantEgre.Text = "0";
            this.lblCantEgre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(1014, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 26);
            this.label8.TabIndex = 96;
            this.label8.Text = "hasta";
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecFin.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFecFin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecFin.Location = new System.Drawing.Point(887, 272);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(298, 26);
            this.dtpFecFin.TabIndex = 95;
            this.dtpFecFin.ValueChanged += new System.EventHandler(this.dtpFecFin_ValueChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(889, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 29);
            this.label13.TabIndex = 92;
            this.label13.Text = "Fecha:";
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecIni.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFecIni.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecIni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFecIni.Location = new System.Drawing.Point(887, 200);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(298, 26);
            this.dtpFecIni.TabIndex = 93;
            this.dtpFecIni.ValueChanged += new System.EventHandler(this.dtpFecIni_ValueChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(405, 383);
            this.dataGridView1.TabIndex = 98;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(425, 255);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(441, 383);
            this.dataGridView2.TabIndex = 99;
            // 
            // lblMontoAnt
            // 
            this.lblMontoAnt.AutoSize = true;
            this.lblMontoAnt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAnt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMontoAnt.Location = new System.Drawing.Point(283, 164);
            this.lblMontoAnt.Name = "lblMontoAnt";
            this.lblMontoAnt.Size = new System.Drawing.Size(24, 26);
            this.lblMontoAnt.TabIndex = 100;
            this.lblMontoAnt.Text = "0";
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1207, 688);
            this.Controls.Add(this.lblMontoAnt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.lblCantEgre);
            this.Controls.Add(this.lblCantIngre);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblEgreso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmCaja";
            this.Text = "FrmCaja";
            this.Load += new System.EventHandler(this.FrmCaja_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label Perfil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCantIngre;
        private System.Windows.Forms.Label lblCantEgre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblMontoAnt;
    }
}