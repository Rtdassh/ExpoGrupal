using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupal
{
    internal class Paciente : Persona
    {
        public Paciente(string iD, string nombre, string direccion, DateTime fechaNacimiento, string numeroTelefonico) : base(iD, nombre, direccion, fechaNacimiento, numeroTelefonico)
        {
        }
    }
}
