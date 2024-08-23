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

        public virtual string CrearID(ref int cantidadID) => "";
        public  string GetID() 
        {
            return ID;
        }

        public Persona(string iD, string nombre, string direccion, DateTime fechaNacimiento, string numeroTelefonico)
        {
            ID = iD;
            Nombre = nombre;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            NumeroTelefonico = numeroTelefonico;
        }
        public void MostrarDetalles(List<Persona> personaList)
        {
            if (personaList.Count == 0)
            {
                Console.WriteLine("No hay Datos Añadidos");
            }
            else
            {
                foreach (var persona in personaList)
                {
                    persona.Mostrar();
                    Console.WriteLine("");
                }

            }
        }
        public virtual void Mostrar()
        {
            Console.WriteLine($"Paciente No.{ID}\nNombre: {Nombre}\nDirección: {Direccion}\nFecha de Nacimiento: {FechaNacimiento}\nNúmero Telefónico: {NumeroTelefonico}");

        }

    }
}
