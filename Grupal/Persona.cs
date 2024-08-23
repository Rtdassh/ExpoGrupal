using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Grupal
{
    internal class Persona
    {
        protected string ID { get; set; }
        public string Nombre { get; set; }
        protected string Direccion { get; set; }

        protected DateTime FechaNacimiento { get; set; }

        protected string NumeroTelefonico { get; set; }

        public virtual string CrearID() => "";
        public virtual string GetID() => ID;
        List<Tratamiento> hola = new List<Tratamiento>();
        public virtual List<Tratamiento> GetList() => hola;


        public Persona(string iD, string nombre, string direccion, DateTime fechaNacimiento, string numeroTelefonico)
        {
            ID = iD;
            Nombre = nombre;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            NumeroTelefonico = numeroTelefonico;
        }
        public virtual void  MostrarDetalles(List<Persona> personaList){}
        public virtual void Mostrar()
        {
            Console.WriteLine($"Paciente No.{ID}\nNombre: {Nombre}\nDirección: {Direccion}\nFecha de Nacimiento: {FechaNacimiento}\nNúmero Telefónico: {NumeroTelefonico}");
        }

    }
}
