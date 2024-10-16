namespace Presentacion.Formularios.frmPersonal.frmAsistencias
{
    partial class frmAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistencias));
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAyer = new System.Windows.Forms.Button();
            this.btnHoy = new System.Windows.Forms.Button();
            this.btnEnt = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPersonal = new System.Windows.Forms.ComboBox();
            this.timerBarraLateral = new System.Windows.Forms.Timer(this.components);
            this.txtPersonal = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSal = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.Panel();
            this.txtIdTrab = new System.Windows.Forms.TextBox();
            this.txtIdAsist = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Location = new System.Drawing.Point(17, 102);
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.ReadOnly = true;
            this.dgvAsistencias.Size = new System.Drawing.Size(670, 188);
            this.dgvAsistencias.TabIndex = 0;
            this.dgvAsistencias.TabStop = false;
            this.dgvAsistencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencias_CellClick);
            this.dgvAsistencias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencias_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Personal:";
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(422, 12);
            this.dtpFecIni.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.dtpFecIni.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(117, 26);
            this.dtpFecIni.TabIndex = 5;
            this.dtpFecIni.ValueChanged += new System.EventHandler(this.dtpFecIni_ValueChanged);
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(570, 12);
            this.dtpFecFin.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.dtpFecFin.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(117, 26);
            this.dtpFecFin.TabIndex = 6;
            this.dtpFecFin.ValueChanged += new System.EventHandler(this.dtpFecFin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "-";
            // 
            // btnAyer
            // 
            this.btnAyer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyer.Location = new System.Drawing.Point(422, 55);
            this.btnAyer.Name = "btnAyer";
            this.btnAyer.Size = new System.Drawing.Size(111, 35);
            this.btnAyer.TabIndex = 7;
            this.btnAyer.Text = "Ayer";
            this.btnAyer.UseVisualStyleBackColor = true;
            this.btnAyer.Click += new System.EventHandler(this.btnAyer_Click);
            // 
            // btnHoy
            // 
            this.btnHoy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoy.Location = new System.Drawing.Point(576, 55);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(111, 35);
            this.btnHoy.TabIndex = 8;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.UseVisualStyleBackColor = true;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // btnEnt
            // 
            this.btnEnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnt.Enabled = false;
            this.btnEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnt.Location = new System.Drawing.Point(16, 55);
            this.btnEnt.Name = "btnEnt";
            this.btnEnt.Size = new System.Drawing.Size(109, 41);
            this.btnEnt.TabIndex = 2;
            this.btnEnt.Text = "Entrada";
            this.btnEnt.UseVisualStyleBackColor = true;
            this.btnEnt.Click += new System.EventHandler(this.btnEnt_Click);
            // 
            // btnCan
            // 
            this.btnCan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCan.Location = new System.Drawing.Point(228, 248);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(111, 35);
            this.btnCan.TabIndex = 98;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.CalendarFont = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpHoraSalida.CustomFormat = "HH:mm:ss";
            this.dtpHoraSalida.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSalida.Location = new System.Drawing.Point(203, 192);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(100, 28);
            this.dtpHoraSalida.TabIndex = 97;
            this.dtpHoraSalida.Value = new System.DateTime(2023, 3, 2, 0, 0, 0, 0);
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.CalendarFont = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpHoraEntrada.CustomFormat = "HH:mm:ss";
            this.dtpHoraEntrada.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEntrada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(203, 136);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(100, 28);
            this.dtpHoraEntrada.TabIndex = 96;
            this.dtpHoraEntrada.Value = new System.DateTime(2023, 3, 2, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 70;
            this.label5.Text = "Hora Salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "Hora Entrada:";
            // 
            // btnHec
            // 
            this.btnHec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHec.Location = new System.Drawing.Point(43, 248);
            this.btnHec.Name = "btnHec";
            this.btnHec.Size = new System.Drawing.Size(111, 35);
            this.btnHec.TabIndex = 67;
            this.btnHec.Text = "Hecho";
            this.btnHec.UseVisualStyleBackColor = true;
            this.btnHec.Click += new System.EventHandler(this.btnHec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "Personal:";
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.Location = new System.Drawing.Point(103, 31);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.Size = new System.Drawing.Size(281, 28);
            this.cmbPersonal.TabIndex = 56;
            // 
            // timerBarraLateral
            // 
            this.timerBarraLateral.Interval = 2;
            this.timerBarraLateral.Tick += new System.EventHandler(this.timerBarraLateral_Tick);
            // 
            // txtPersonal
            // 
            this.txtPersonal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPersonal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonal.Location = new System.Drawing.Point(103, 13);
            this.txtPersonal.MaxLength = 200;
            this.txtPersonal.Name = "txtPersonal";
            this.txtPersonal.Size = new System.Drawing.Size(300, 27);
            this.txtPersonal.TabIndex = 1;
            this.txtPersonal.TextChanged += new System.EventHandler(this.txtPersonal_TextChanged);
            this.txtPersonal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPersonal_KeyDown);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(203, 85);
            this.dtpFecha.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(117, 26);
            this.dtpFecha.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 100;
            this.label6.Text = "Fecha:";
            // 
            // btnSal
            // 
            this.btnSal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSal.Enabled = false;
            this.btnSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSal.Location = new System.Drawing.Point(141, 55);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(109, 41);
            this.btnSal.TabIndex = 3;
            this.btnSal.Text = "Salida";
            this.btnSal.UseVisualStyleBackColor = true;
            this.btnSal.Click += new System.EventHandler(this.btnSal_Click);
            // 
            // btnElim
            // 
            this.btnElim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElim.Enabled = false;
            this.btnElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElim.Location = new System.Drawing.Point(272, 55);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(109, 41);
            this.btnElim.TabIndex = 4;
            this.btnElim.Text = "Eliminar";
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // sideBar
            // 
            this.sideBar.Controls.Add(this.label6);
            this.sideBar.Controls.Add(this.cmbPersonal);
            this.sideBar.Controls.Add(this.dtpFecha);
            this.sideBar.Controls.Add(this.label2);
            this.sideBar.Controls.Add(this.btnHec);
            this.sideBar.Controls.Add(this.btnCan);
            this.sideBar.Controls.Add(this.label3);
            this.sideBar.Controls.Add(this.dtpHoraSalida);
            this.sideBar.Controls.Add(this.label5);
            this.sideBar.Controls.Add(this.dtpHoraEntrada);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(415, 302);
            this.sideBar.MinimumSize = new System.Drawing.Size(5, 302);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(10, 302);
            this.sideBar.TabIndex = 69;
            // 
            // txtIdTrab
            // 
            this.txtIdTrab.Location = new System.Drawing.Point(587, 283);
            this.txtIdTrab.Name = "txtIdTrab";
            this.txtIdTrab.Size = new System.Drawing.Size(100, 19);
            this.txtIdTrab.TabIndex = 70;
            this.txtIdTrab.Text = "0";
            this.txtIdTrab.Visible = false;
            this.txtIdTrab.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtIdAsist
            // 
            this.txtIdAsist.Location = new System.Drawing.Point(16, 283);
            this.txtIdAsist.Name = "txtIdAsist";
            this.txtIdAsist.Size = new System.Drawing.Size(100, 19);
            this.txtIdAsist.TabIndex = 71;
            this.txtIdAsist.Text = "0";
            this.txtIdAsist.Visible = false;
            this.txtIdAsist.TextChanged += new System.EventHandler(this.txtIdAsist_TextChanged);
            // 
            // frmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 302);
            this.Controls.Add(this.txtIdAsist);
            this.Controls.Add(this.txtIdTrab);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.btnSal);
            this.Controls.Add(this.txtPersonal);
            this.Controls.Add(this.btnEnt);
            this.Controls.Add(this.btnHoy);
            this.Controls.Add(this.btnAyer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvAsistencias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(713, 341);
            this.MinimumSize = new System.Drawing.Size(713, 341);
            this.Name = "frmAsistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencias del Personal";
            this.Load += new System.EventHandler(this.frmAsistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAyer;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Button btnEnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPersonal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHec;
        public System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.Button btnCan;
        public System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Timer timerBarraLateral;
        private System.Windows.Forms.TextBox txtPersonal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnSal;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.TextBox txtIdTrab;
        private System.Windows.Forms.TextBox txtIdAsist;
    }
}