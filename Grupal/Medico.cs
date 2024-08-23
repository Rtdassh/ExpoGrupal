using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupal
{
    internal class Medico : Persona
    {
        int cantidadID = 0;
        
        public string Especialidad { get; set; }

        public Medico(string iD, string nombre, string direccion, DateTime fechaNacimiento, string numeroTelefonico, string especialidad) : base(iD, nombre, direccion, fechaNacimiento, numeroTelefonico)
        {
            Especialidad = especialidad;
        }

        public override string CrearID()
        {
            cantidadID++;
            return "A" + cantidadID;
        }


        public void agregarMedico(List<Persona> listaMedicos)
        {

            Console.Clear();
            Console.WriteLine("--- AGREGAR MÉDICO ---");
            string idMedico = CrearID();
            Console.Write("Ingrese el nombre del médico: ");

            string nombreMedico = Console.ReadLine() ?? "";
            Console.Write("Ingrese la dirección del médico: ");
            string direccionMedico = Console.ReadLine() ?? "";
            int nuevaFecha = int.Parse(Console.ReadLine() ?? "");
            DateTime fechaNacimiento = new DateTime(nuevaFecha);
            Console.Write("Ingrese el número de teléfono: ");
            string numeroMedico = Console.ReadLine() ?? "";
            Console.Write("Ingrese la especialidad del médico: ");
            string especialidad = Console.ReadLine() ?? "";
            Medico agregarMedico = new Medico(idMedico, nombreMedico, direccionMedico, fechaNacimiento, numeroMedico, especialidad);
            listaMedicos.Add(agregarMedico);
        }
        public override void MostrarDetalles(List<Persona> personaList)
        {
            foreach (var persona in personaList)
            {
                if (persona is Medico)
                {
                    persona.Mostrar();
                    Console.WriteLine("");
                    Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                }
            }
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Especialidad: {Especialidad}");
        }
    }
}
