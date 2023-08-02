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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alta_Usuario alta_Usuario = new Alta_Usuario();
            alta_Usuario.Show();
            this.Hide();

        
        }

        private void Fixture_Click(object sender, EventArgs e)
        {
            Fixture fixture = new Fixture();
            fixture.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Inicio_Sesion inicio_Sesion = new Inicio_Sesion();
            inicio_Sesion.Show();
            this.Hide();
        }
    }
}
