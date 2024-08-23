using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupal
{
    internal class Persona
    {
        public List<Persona> listadoGeneralPersonas = new List<Persona>();
        private string ID { get; set; }
        public string Nombre { get; set; }
        protected string Direccion{ get; set; }

        protected DateTime FechaNacimiento { get; set; }

        protected string NumeroTelefonico { get; set; }

       

        public Persona(string iD, string nombre, string direccion, DateTime fechaNacimiento, string numeroTelefonico)
        {
            ID = iD;
            Nombre = nombre;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            NumeroTelefonico = numeroTelefonico;
        }
    }
}
