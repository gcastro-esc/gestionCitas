namespace gestionCitas
{
    partial class frmDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalle));
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabPaciente = new System.Windows.Forms.TabPage();
            this.tabMedico = new System.Windows.Forms.TabPage();
            this.lblCita = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.picPaciente = new System.Windows.Forms.PictureBox();
            this.picMedico = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.tabInfo.SuspendLayout();
            this.tabPaciente.SuspendLayout();
            this.tabMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(264, 31);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(136, 27);
            this.lblSubtitulo.TabIndex = 4;
            this.lblSubtitulo.Text = "Salud Integral";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.lblTitulo.Location = new System.Drawing.Point(190, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(285, 22);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Clínica de Especialidades Médicas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.label1.Location = new System.Drawing.Point(247, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Detalle de la Cita";
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tabPaciente);
            this.tabInfo.Controls.Add(this.tabMedico);
            this.tabInfo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInfo.Location = new System.Drawing.Point(43, 185);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(581, 277);
            this.tabInfo.TabIndex = 7;
            // 
            // tabPaciente
            // 
            this.tabPaciente.Controls.Add(this.lblCita);
            this.tabPaciente.Controls.Add(this.lblContacto);
            this.tabPaciente.Controls.Add(this.picPaciente);
            this.tabPaciente.Controls.Add(this.lblPaciente);
            this.tabPaciente.Location = new System.Drawing.Point(4, 31);
            this.tabPaciente.Name = "tabPaciente";
            this.tabPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaciente.Size = new System.Drawing.Size(573, 242);
            this.tabPaciente.TabIndex = 0;
            this.tabPaciente.Text = "Datos del Paciente";
            this.tabPaciente.UseVisualStyleBackColor = true;
            // 
            // tabMedico
            // 
            this.tabMedico.Controls.Add(this.lblUbicacion);
            this.tabMedico.Controls.Add(this.lblDatos);
            this.tabMedico.Controls.Add(this.picMedico);
            this.tabMedico.Controls.Add(this.lblMedico);
            this.tabMedico.Location = new System.Drawing.Point(4, 31);
            this.tabMedico.Name = "tabMedico";
            this.tabMedico.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedico.Size = new System.Drawing.Size(573, 242);
            this.tabMedico.TabIndex = 1;
            this.tabMedico.Text = "Datos del Médico";
            this.tabMedico.UseVisualStyleBackColor = true;
            // 
            // lblCita
            // 
            this.lblCita.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.lblCita.Location = new System.Drawing.Point(25, 171);
            this.lblCita.Name = "lblCita";
            this.lblCita.Size = new System.Drawing.Size(523, 46);
            this.lblCita.TabIndex = 14;
            this.lblCita.Text = "Cita";
            this.lblCita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCita.UseWaitCursor = true;
            // 
            // lblContacto
            // 
            this.lblContacto.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.lblContacto.Location = new System.Drawing.Point(166, 66);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(382, 81);
            this.lblContacto.TabIndex = 13;
            this.lblContacto.Text = "Contacto";
            // 
            // lblPaciente
            // 
            this.lblPaciente.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.lblPaciente.Location = new System.Drawing.Point(25, 26);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(523, 23);
            this.lblPaciente.TabIndex = 11;
            this.lblPaciente.Text = "Paciente";
            this.lblPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMedico
            // 
            this.lblMedico.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.lblMedico.Location = new System.Drawing.Point(26, 26);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(523, 23);
            this.lblMedico.TabIndex = 12;
            this.lblMedico.Text = "Medico";
            this.lblMedico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPaciente
            // 
            this.picPaciente.Image = global::gestionCitas.Properties.Resources._17_113699;
            this.picPaciente.Location = new System.Drawing.Point(29, 66);
            this.picPaciente.Name = "picPaciente";
            this.picPaciente.Size = new System.Drawing.Size(104, 81);
            this.picPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaciente.TabIndex = 12;
            this.picPaciente.TabStop = false;
            // 
            // picMedico
            // 
            this.picMedico.Image = global::gestionCitas.Properties.Resources.doctor_icon_134842;
            this.picMedico.Location = new System.Drawing.Point(30, 73);
            this.picMedico.Name = "picMedico";
            this.picMedico.Size = new System.Drawing.Size(104, 81);
            this.picMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMedico.TabIndex = 13;
            this.picMedico.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::gestionCitas.Properties.Resources.logoClinica;
            this.picLogo.Location = new System.Drawing.Point(298, 61);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(69, 57);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // lblDatos
            // 
            this.lblDatos.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.lblDatos.Location = new System.Drawing.Point(167, 73);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(382, 81);
            this.lblDatos.TabIndex = 14;
            this.lblDatos.Text = "Datos del Médico";
            this.lblDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.lblUbicacion.Location = new System.Drawing.Point(26, 187);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(523, 23);
            this.lblUbicacion.TabIndex = 15;
            this.lblUbicacion.Text = "Ubicacion";
            this.lblUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 493);
            this.Controls.Add(this.tabInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetalle";
            this.Text = "Clínica Médica - Detalle de Cita";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            this.tabInfo.ResumeLayout(false);
            this.tabPaciente.ResumeLayout(false);
            this.tabMedico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabInfo;
        private System.Windows.Forms.TabPage tabPaciente;
        public System.Windows.Forms.Label lblCita;
        public System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.PictureBox picPaciente;
        public System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TabPage tabMedico;
        public System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.PictureBox picMedico;
        public System.Windows.Forms.Label lblUbicacion;
        public System.Windows.Forms.Label lblDatos;
    }
}