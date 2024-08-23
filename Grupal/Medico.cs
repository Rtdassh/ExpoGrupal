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

        public override string CrearID(ref int cantidadID)
        {
            cantidadID++;
            return "A" + cantidadID;
        }
        public void agregarMedico(List<Persona> listaMedicos)
        {
            Console.WriteLine("Ingrese el ID del medico");
            string idMedico = Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese el nombre del medico");
            string nombreMedico = Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese la dirección del medico");
            string direccionMedico = Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese la fecha de nacimiento");
            DateTime fechaMedico = DateTime.Now;
            Console.WriteLine("Ingrese el nombre del número de telefono");
            string numeroMedico = Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese la especialidad del medico");
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
