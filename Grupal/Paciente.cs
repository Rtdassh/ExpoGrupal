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
            List<Tratamiento> ListadoNuevoPaciente = new List<Tratamiento>();
            string nuevoId = CrearID(ref cantidadID);
            Console.WriteLine("Ingrese el nombre del nuevo paciente:");
            string nuevoNombre = Console.ReadLine()??"";
            Console.WriteLine("Ingrese la dirección del paciente:");
            string nuevaDireccion = Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese el año de nacimiento:");
            int nuevaFecha = int.Parse(Console.ReadLine() ?? "");
            DateTime fechaNacimiento = new DateTime(nuevaFecha);
            Console.WriteLine("Ingrese el número de teléfono del paciente:");
            string nuevoNumero = Console.ReadLine() ?? "";

            Paciente agregarPaciente = new Paciente(nuevoId, nuevoNombre, nuevaDireccion, fechaNacimiento, nuevoNumero, ListadoNuevoPaciente);
            listaPacientes.Add(agregarPaciente);
        }
        public override string CrearID(ref int cantidadID)
        {
            cantidadID++;
            return "B" + cantidadID;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.Write($"Listado Paciente: {ListadoPaciente}");
        }
    }
}
