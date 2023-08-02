using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        public List<Persona> ListaPersona = new List<Persona>();

        public void AltaPersona(Persona personaparametro)
        {
            Persona persona1 = new Persona();
            persona1.DNI = personaparametro.DNI;
            persona1.Name = personaparametro.Name;
            persona1.Apellido = personaparametro.Apellido;
            persona1.Direccion = personaparametro.Direccion;
            persona1.Club = personaparametro.Club;
            persona1.Correo = personaparametro.Correo;
            persona1.Contraseña = personaparametro.Contraseña;

            ListaPersona.Add(persona1);

        }

        public void BajaPersona(Persona personaparametro)
        {
            ListaPersona.Remove(personaparametro);
        }

        public void ModificacionPersona(Persona PersonaNueva, Persona personaEliminar)
        {
            Persona personamodificada = new Persona();


            personamodificada.DNI = PersonaNueva.DNI;
            personamodificada.Name = PersonaNueva.Name;
            personamodificada.Apellido = PersonaNueva.Apellido;
            personamodificada.Direccion = PersonaNueva.Direccion;
            personamodificada.Club = PersonaNueva.Club;
            personamodificada.Correo = PersonaNueva.Correo;
            personamodificada.Contraseña = PersonaNueva.Contraseña;
            ListaPersona.Remove(personaEliminar);
            ListaPersona.Add (personamodificada);
        }
    }
}
