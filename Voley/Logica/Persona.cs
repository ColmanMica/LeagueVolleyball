using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Persona: Usuario
    {
        public int DNI { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Club { get; set; }

        public string PE
        {
            get { return "DNI:" + DNI + "Nombre:" + Name + "Apellido: " + Apellido + "Dirección: " + Direccion + "Club: " + Club; }
        }
    }
}
