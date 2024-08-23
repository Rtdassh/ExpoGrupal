using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Grupal
{
    internal class Cita_medica
    {

        public int contador = 0;
        public int NumeroCita {  get; set; }
        protected DateTime Fecha { get; set; }
        public string Medico { get; set; }
        public string Paciente { get; set; }
        protected string Diagnostico { get; set; }

       public Cita_medica(int numeroCita, DateTime fecha, string medico, string paciente, string diagnostico)
        {
            NumeroCita = numeroCita;
            Fecha = fecha;
            Medico = medico;
            Paciente = paciente;
            Diagnostico = diagnostico;
        }

        public int CrearID(ref int cantidadID)
        {
            cantidadID++;
            return cantidadID;
        }

        public void AgregarCita(List<Persona> personas, List<Cita_medica> listadoCitas)
        {
            Console.Clear();
            string idMedico = "";
            string idPaciente = "";
            int consulta = 0;
            int busquedaPaciente = 0;

            bool valores = true; 
            while (valores)
            {
                Console.WriteLine("--- AGENDAR CITA ---");
                Console.Write("ID Médico: ");
                idMedico = Console.ReadLine() ?? "";
                consulta = personas.FindIndex(n => n.GetID() == idMedico)!;
                Console.Write("ID paciente: ");
                idPaciente = Console.ReadLine() ?? "";
                busquedaPaciente = personas.FindIndex(n => n.GetID() == idPaciente)!;
                Console.WriteLine(consulta);
                Console.WriteLine(busquedaPaciente);
                if (consulta != -1 && busquedaPaciente != -1) break;
                else Console.WriteLine("El usuario ingresado no se ha encontrado, inténtelo de nuevo.");
                Console.ReadKey();
                Console.Clear();
            }
            
            Console.Write("Diagnóstico: ");
            string diagnostico = Console.ReadLine() ?? "";
            DateTime fecha = DateTime.Now;
            int nuevoID = CrearID(ref contador);

            Cita_medica nuevaCita = new Cita_medica(nuevoID, fecha, personas[consulta].Nombre, personas[busquedaPaciente].Nombre, diagnostico);
            listadoCitas.Add(nuevaCita);
        }
        public void ListadoCitas(List<Cita_medica> listaCitas)
        {
            Console.Clear();
            foreach (var cita in listaCitas)
            {
                Console.WriteLine("");
                Console.WriteLine("Número de cita: " + cita.NumeroCita);
                Console.WriteLine("Fecha: " + cita.Fecha);
                Console.WriteLine("Médico: " + cita.Medico);
                Console.WriteLine("Paciente: " + cita.Paciente);
                Console.WriteLine("Diagnóstico: " + cita.Diagnostico);
            }
        }
    }
}
