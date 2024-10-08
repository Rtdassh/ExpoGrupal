﻿using System;
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
            Console.WriteLine("--- AGREGAR PACIENTE ---");
            List<Tratamiento> ListadoNuevoPaciente = new List<Tratamiento>();
            string nuevoId = CrearID();
            Console.Write("Ingrese el nombre del nuevo paciente: ");
            string nuevoNombre = Console.ReadLine()??"";
            Console.Write("Ingrese la dirección del paciente: ");
            string nuevaDireccion = Console.ReadLine() ?? "";
            Console.Write("Ingrese el año de nacimiento: ");
            int nuevaFecha = int.Parse(Console.ReadLine() ?? "");
            DateTime fechaNacimiento = new DateTime(nuevaFecha);
            Console.Write("Ingrese el número de teléfono del paciente: ");
            string nuevoNumero = Console.ReadLine() ?? "";

            Paciente agregarPaciente = new Paciente(nuevoId, nuevoNombre, nuevaDireccion, fechaNacimiento, nuevoNumero, ListadoNuevoPaciente);
            listaPacientes.Add(agregarPaciente);
        }
        public override string CrearID()
        {
            cantidadID++;
            return "B" + cantidadID;
        }
        public override void MostrarDetalles(List<Persona> personaList)
        {
            foreach (var persona in personaList)
            {
                if (persona is Paciente)
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
            foreach (Tratamiento tratamiento in ListadoPaciente)
            {
                for (int i = 0; i < ListadoPaciente.Count; i++)
                {
                    Console.WriteLine($"Tratamiento: {tratamiento.Medicamento[0].Descripcion}");
                }
            }
        }
        public override List<Tratamiento> GetList() => ListadoPaciente;

    }
}
