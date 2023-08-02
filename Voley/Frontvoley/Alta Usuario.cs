using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontvoley
{
    public partial class Alta_Usuario : Form
    {
       Principal principal = new Principal();

        public Alta_Usuario()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Botonalta_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.DNI = int.Parse(txtDNI.Text);
            persona.Name = txtName.Text;
            persona.Apellido = txtApell.Text;
            persona.Direccion = txtDirecc.Text;
            persona.Club = txtClub.Text;
            persona.Correo = txtCorreo.Text;
            persona.Contraseña = txtContra.Text;

            principal.AltaPersona(persona);

            

            Presentación_de_datos presentación_De_Datos = new Presentación_de_datos();
            presentación_De_Datos.Show();
            this.Hide();

            txtDNI.Clear();
            txtName.Clear();
            txtApell.Clear();
            txtDirecc.Clear();
            txtClub.Clear();
            txtCorreo.Clear();
            txtContra.Clear();



                    

        }

        private void butALTA_Click(object sender, EventArgs e)
        {

        }   

        private void botonModif_Click(object sender, EventArgs e)
        {

        }
    }
}
