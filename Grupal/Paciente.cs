using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupal
{
    internal class Paciente : Persona
    {
        int cantidadID = 0;
        public override string CrearID(int cantidadID)
        {
            cantidadID++;
            return "B" + cantidadID;
        }
        public Paciente(string iD, string nombre, string direccion, DateTime fechaNacimiento, string numeroTelefonico) : base(iD, nombre, direccion, fechaNacimiento, numeroTelefonico)
        {
        }
    }
}
