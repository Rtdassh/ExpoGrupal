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
        public List<Tratamiento> ListadoPaciente { get; set; }

        public Paciente(string iD, string nombre, string direccion, DateTime fechaNacimiento, string numeroTelefonico, List<Tratamiento> listadoPaciente) : base(iD, nombre, direccion, fechaNacimiento, numeroTelefonico)
        {
            ListadoPaciente = listadoPaciente;
        }

        public void agregarPaciente(List<Persona> listaPacientes)
        {
            Console.Clear();
            string nuevoId = CrearID(cantidadID);
            Console.WriteLine("Ingrese el nombre del nuevo paciente:");
            string nuevoNombre = Console.ReadLine()??"";
            Console.WriteLine("Ingrese la dirección del paciente:");
            string nuevaDireccion = Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese el año de naciemiento:");
            int nuevaFecha = int.Parse(Console.ReadLine() ?? "");
            DateTime fechaNacimiento = new DateTime(nuevaFecha);
            Console.WriteLine("Ingrese el número de teléfono del paciente:");
            string nuevoNumero = Console.ReadLine() ?? "";
        }
        public override string CrearID(int cantidadID)
        {
            cantidadID++;
            return "B" + cantidadID;
        }

        
    }
}
