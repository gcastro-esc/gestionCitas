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
    public partial class frmDetalle : Form
    {
        //Form 2
        //Crear propiedad publica
        public int numDoc { get; set; }

        public frmDetalle()
        {
            InitializeComponent();
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            switch (numDoc)
            {
                case 0:     //Medico # 1
                    lblDatos.Text = "Medico Internista \n Cedula Profesional: 500698741";
                    lblUbicacion.Text = "Consultorio 300, Torre 2 \n Tel: 4153335577";
                    break;
                case 1:     //Medico # 2
                    lblDatos.Text = "Médico Pediatra \n Cédula Profesional: 98741236";
                    lblUbicacion.Text = "Consultorio 450, Torre 1 \n Tel: 4152008855";
                    break;
                case 2:     //Medico # 3
                    lblDatos.Text = "Médico Ortopedista \n Cédula Profesional: 41023698";
                    lblUbicacion.Text = "Consultorio 900, Torre 3 \n Tel: 4158887755";
                    break;
                case 3:     //Médico # 4
                    lblDatos.Text = "Médico Cardiologo \n Cédula Profesional: 95103578";
                    lblUbicacion.Text = "Consultorio 101, Torre 2 \n 4157539575";
                    break;
            }

        }
    }
}
