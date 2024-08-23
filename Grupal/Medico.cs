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
            string idMedico = CrearID(ref cantidadID);
            Console.Write("Ingrese el nombre del médico: ");

            string nombreMedico = Console.ReadLine() ?? "";
            Console.Write("Ingrese la dirección del médico: ");
            string direccionMedico = Console.ReadLine() ?? "";
            Console.Write("Ingrese la fecha de nacimiento: ");
            DateTime fechaMedico = DateTime.Now;
            Console.Write("Ingrese el número de teléfono: ");
            string numeroMedico = Console.ReadLine() ?? "";
            Console.Write("Ingrese la especialidad del médico: ");
            string especialidad = Console.ReadLine() ?? "";
            Medico agregarMedico = new Medico(idMedico, nombreMedico, direccionMedico, fechaMedico, numeroMedico, especialidad);
            listaMedicos.Add(agregarMedico);
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Especialidad: {Especialidad}");
        }
    }
}
