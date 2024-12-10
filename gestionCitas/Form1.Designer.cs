namespace gestionCitas
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.gbDatosCita = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cbDoctores = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.lblResumenCita = new System.Windows.Forms.Label();
            this.lblResumenMedico = new System.Windows.Forms.Label();
            this.lblResumenPaciente = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.picResumenCita = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.gbDatosCita.SuspendLayout();
            this.gbResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResumenCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.lblTitulo.Location = new System.Drawing.Point(206, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(285, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Clínica de Especialidades Médicas";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(280, 25);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(136, 27);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Salud Integral";
            // 
            // gbDatosCita
            // 
            this.gbDatosCita.Controls.Add(this.btnCancelar);
            this.gbDatosCita.Controls.Add(this.btnAgendar);
            this.gbDatosCita.Controls.Add(this.lblDescripcion);
            this.gbDatosCita.Controls.Add(this.cbDoctores);
            this.gbDatosCita.Controls.Add(this.label9);
            this.gbDatosCita.Controls.Add(this.txtHorario);
            this.gbDatosCita.Controls.Add(this.label8);
            this.gbDatosCita.Controls.Add(this.dateFecha);
            this.gbDatosCita.Controls.Add(this.label7);
            this.gbDatosCita.Controls.Add(this.label6);
            this.gbDatosCita.Controls.Add(this.txtDireccion);
            this.gbDatosCita.Controls.Add(this.label5);
            this.gbDatosCita.Controls.Add(this.txtTelefono);
            this.gbDatosCita.Controls.Add(this.label4);
            this.gbDatosCita.Controls.Add(this.txtNoPaciente);
            this.gbDatosCita.Controls.Add(this.label3);
            this.gbDatosCita.Controls.Add(this.txtPaciente);
            this.gbDatosCita.Controls.Add(this.label2);
            this.gbDatosCita.Controls.Add(this.label1);
            this.gbDatosCita.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.gbDatosCita.Location = new System.Drawing.Point(21, 120);
            this.gbDatosCita.Name = "gbDatosCita";
            this.gbDatosCita.Size = new System.Drawing.Size(637, 353);
            this.gbDatosCita.TabIndex = 3;
            this.gbDatosCita.TabStop = false;
            this.gbDatosCita.Text = " Información de la Nueva Cita ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancelar.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(19, 296);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(343, 41);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "CANCELAR CITA ❌";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAgendar.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgendar.Location = new System.Drawing.Point(19, 246);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(343, 41);
            this.btnAgendar.TabIndex = 17;
            this.btnAgendar.Text = "AGENDAR CITA ✍";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(400, 200);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(215, 137);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Especialidad del Médico Seleccionado";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbDoctores
            // 
            this.cbDoctores.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoctores.FormattingEnabled = true;
            this.cbDoctores.Items.AddRange(new object[] {
            "Dr. Leonardo Di Caprio",
            "Dra. Scarlett Johansson",
            "Dra. Natalie Portman",
            "Dr. Tony Stark"});
            this.cbDoctores.Location = new System.Drawing.Point(403, 159);
            this.cbDoctores.Name = "cbDoctores";
            this.cbDoctores.Size = new System.Drawing.Size(213, 26);
            this.cbDoctores.TabIndex = 15;
            this.cbDoctores.SelectedIndexChanged += new System.EventHandler(this.cbDoctores_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(478, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "- MÉDICO - ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHorario
            // 
            this.txtHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.txtHorario.Location = new System.Drawing.Point(94, 192);
            this.txtHorario.Mask = "00 : 00";
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(100, 26);
            this.txtHorario.TabIndex = 13;
            this.txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "HORA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateFecha
            // 
            this.dateFecha.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.dateFecha.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFecha.Location = new System.Drawing.Point(92, 161);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(270, 23);
            this.dateFecha.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "FECHA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "- CITA -";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDireccion
            // 
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.txtDireccion.Location = new System.Drawing.Point(360, 88);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(256, 26);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "DIRECCION";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefono
            // 
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.txtTelefono.Location = new System.Drawing.Point(92, 88);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(128, 26);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "TEL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNoPaciente
            // 
            this.txtNoPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.txtNoPaciente.Location = new System.Drawing.Point(493, 53);
            this.txtNoPaciente.Name = "txtNoPaciente";
            this.txtNoPaciente.Size = new System.Drawing.Size(123, 26);
            this.txtNoPaciente.TabIndex = 4;
            this.txtNoPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNoPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoPaciente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "No Paciente";
            // 
            // txtPaciente
            // 
            this.txtPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.txtPaciente.Location = new System.Drawing.Point(92, 53);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(270, 26);
            this.txtPaciente.TabIndex = 2;
            this.txtPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "- PACIENTE -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbResumen
            // 
            this.gbResumen.Controls.Add(this.btnDetalle);
            this.gbResumen.Controls.Add(this.lblResumenCita);
            this.gbResumen.Controls.Add(this.lblResumenMedico);
            this.gbResumen.Controls.Add(this.lblResumenPaciente);
            this.gbResumen.Controls.Add(this.picResumenCita);
            this.gbResumen.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(125)))));
            this.gbResumen.Location = new System.Drawing.Point(21, 479);
            this.gbResumen.Name = "gbResumen";
            this.gbResumen.Size = new System.Drawing.Size(637, 109);
            this.gbResumen.TabIndex = 4;
            this.gbResumen.TabStop = false;
            this.gbResumen.Text = " Resumen de la Cita ";
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDetalle.Font = new System.Drawing.Font("Open Sans Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDetalle.Location = new System.Drawing.Point(514, 27);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(102, 62);
            this.btnDetalle.TabIndex = 4;
            this.btnDetalle.Text = "Mostrar Detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // lblResumenCita
            // 
            this.lblResumenCita.Location = new System.Drawing.Point(106, 71);
            this.lblResumenCita.Name = "lblResumenCita";
            this.lblResumenCita.Size = new System.Drawing.Size(381, 24);
            this.lblResumenCita.TabIndex = 3;
            this.lblResumenCita.Text = "Datos de la Cita";
            this.lblResumenCita.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblResumenMedico
            // 
            this.lblResumenMedico.Location = new System.Drawing.Point(106, 46);
            this.lblResumenMedico.Name = "lblResumenMedico";
            this.lblResumenMedico.Size = new System.Drawing.Size(381, 24);
            this.lblResumenMedico.TabIndex = 2;
            this.lblResumenMedico.Text = "Datos del Médico";
            this.lblResumenMedico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblResumenPaciente
            // 
            this.lblResumenPaciente.Location = new System.Drawing.Point(106, 21);
            this.lblResumenPaciente.Name = "lblResumenPaciente";
            this.lblResumenPaciente.Size = new System.Drawing.Size(381, 24);
            this.lblResumenPaciente.TabIndex = 1;
            this.lblResumenPaciente.Text = "Datos del Paciente";
            this.lblResumenPaciente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(259, 599);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(399, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Desarrollado por Gerardo Castro | 3BP CBTis 60 👨🏻‍💻";
            // 
            // picResumenCita
            // 
            this.picResumenCita.Image = global::gestionCitas.Properties.Resources.appointment_102882;
            this.picResumenCita.Location = new System.Drawing.Point(19, 34);
            this.picResumenCita.Name = "picResumenCita";
            this.picResumenCita.Size = new System.Drawing.Size(56, 50);
            this.picResumenCita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResumenCita.TabIndex = 0;
            this.picResumenCita.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::gestionCitas.Properties.Resources.logoClinica;
            this.picLogo.Location = new System.Drawing.Point(314, 55);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(69, 57);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 624);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gbResumen);
            this.Controls.Add(this.gbDatosCita);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistro";
            this.Text = "Clínica Médica - Registro de Citas";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.gbDatosCita.ResumeLayout(false);
            this.gbDatosCita.PerformLayout();
            this.gbResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResumenCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox gbDatosCita;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtHorario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cbDoctores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbResumen;
        private System.Windows.Forms.PictureBox picResumenCita;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label lblResumenCita;
        private System.Windows.Forms.Label lblResumenMedico;
        private System.Windows.Forms.Label lblResumenPaciente;
        private System.Windows.Forms.Label label10;
    }
}

