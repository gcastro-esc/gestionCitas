using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionCitas
{
    public partial class frmRegistro : Form
    {
        string paciente, telefono, direccion, medico, hora;
        int numeroPaciente, numeroDr;
        DateTime fechaCita;

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            //Evento LOAD (cuando carga el formulario)
            btnCancelar.Enabled = false;
            gbResumen.Visible = false;
            lblDescripcion.Visible =  false;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            //Boton Agendar

            //Valida si el nombre del paciente se ha ingresao y si se ha seleccionado un medico
            //Lo ideal seria incluir todos los campos de entrada en esta validacion
            if (string.IsNullOrWhiteSpace(txtPaciente.Text) || cbDoctores.SelectedIndex < 0)
            {
                MessageBox.Show("No se ha ingresado el nombre del paciente y/o no se ha " +
                    "seleccionado un médico. \n\nIntenta nuevamente", "Datos Incompletos");
            }
            else
            {
                //Obtener datos de entrada
                paciente = txtPaciente.Text;
                numeroPaciente = Convert.ToInt32(txtNoPaciente.Text); //Validado
                telefono = txtTelefono.Text;
                direccion = txtDireccion.Text;
                fechaCita = dateFecha.Value;
                medico = cbDoctores.SelectedItem.ToString();    //Nombre
                numeroDr = cbDoctores.SelectedIndex;            //Indice
                hora = txtHorario.Text;

                //Mostrar datos de salida
                lblResumenPaciente.Text = "Paciente # " + numeroPaciente + " - " + paciente;
                lblResumenMedico.Text = "Médico que lo atiende: " + medico;
                lblResumenCita.Text = "Cita programada: " + fechaCita.ToLongDateString() +
                    ", a las " + hora;
                gbResumen.Visible = true;
                btnCancelar.Enabled = true;
                btnAgendar.Enabled = false;

            }

        }

        private void cbDoctores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoctores.SelectedIndex == 0)
            {
                lblDescripcion.Visible = true;
                lblDescripcion.Text = "Médico Internista, se especializa en el diagnóstico y tratamiento de enfermedades que afectan los órganos internos, brindando atención integral a adultos con condiciones médicas complejas y crónicas";
            }
            if (cbDoctores.SelectedIndex == 1)
            {
                lblDescripcion.Visible = true;
                lblDescripcion.Text = "Médico Pediatra. uidado integral de niños desde su nacimiento hasta la adolescencia, ofreciendo tratamientos para enfermedades comunes y previniendo problemas de salud en la infancia.";
            }
            if (cbDoctores.SelectedIndex == 2)
            {
                lblDescripcion.Visible = true;
                lblDescripcion.Text = "Médico Ortopedista, se dedica al diagnóstico y tratamiento de lesiones y enfermedades del sistema musculoesquelético, ayudando a pacientes con fracturas, artritis y problemas relacionados con los huesos y las articulaciones.";
            }
            if (cbDoctores.SelectedIndex == 3)
            {
                lblDescripcion.Visible = true;
                lblDescripcion.Text = "Médico Cardiólogo, es experta en el diagnóstico y tratamiento de problemas cardíacos, desde hipertensión hasta enfermedades coronarias, ayudando a mejorar la salud del corazón de sus pacientes.";
            }

        }

        private void txtNoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Controla que la tecla presionada sea un numero
            // '8' es el código de la tecla backSpace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;       //Cancela el ingreso de la tecla
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Boton cancelar cita
            txtPaciente.Clear();    //Clear tmb "limpia" el contenido del textBox
            txtNoPaciente.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            dateFecha.Value = DateTime.Now;
            txtHorario.Clear();
            cbDoctores.SelectedIndex = -1;
            lblDescripcion.Text = "";
            gbResumen.Visible = false;
            btnAgendar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            //Boton Detalle
            frmDetalle dato = new frmDetalle();
            //pestaña Paciente
            dato.lblPaciente.Text = "Paciente " + numeroPaciente + ": " + paciente;
            dato.lblContacto.Text = "Datos de contacto del paciente \n" +
                "Dirección: " + direccion + "\nTeléfono: " + telefono;
            dato.lblCita.Text = "Cita agendada: " + fechaCita.ToLongDateString() + ", a las " +
                hora + " hrs";
            //pestaña Medico
            dato.lblMedico.Text = medico;
            dato.numDoc = numeroDr;

            //Al final
            dato.Show();
        }

    }
}
