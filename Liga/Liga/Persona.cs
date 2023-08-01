using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga
{
    public class Persona : Usuario
    {
        public int DNI { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Club { get; set; }
    }
}
