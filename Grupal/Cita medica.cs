using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupal
{
    internal class Cita_medica
    {

        public int contador = 0;
        public int NumeroCita {  get; set; }
        protected DateTime Fecha { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        protected string Diagnostico { get; set; }
        protected Tratamiento Tratamientos { get; set; }

       public Cita_medica(int numeroCita, DateTime fecha, Medico medico, Paciente paciente, string diagnostico, Tratamiento tratamientos)
        {
            NumeroCita = numeroCita;
            Fecha = fecha;
            Medico = medico;
            Paciente = paciente;
            Diagnostico = diagnostico;
            Tratamientos = tratamientos;
        }

        public string CrearID(ref int cantidadID)
        {
            cantidadID++;
            return "C" + cantidadID;
        }

        public void AgregarCita(List<Persona> personas, List<Tratamiento> listadoTratamientos, List<Cita_medica> listadoCitas)
        {
            Console.Clear();
            Console.WriteLine("--- AGENDAR CITA ---");
            string nuevoID = CrearID(ref contador);
            Console.Write("Fecha de cita: ");
            DateTime fecha = DateTime.Now;
            Console.Write("ID Médico: ");
            string idMedico = Console.ReadLine()??"";
            Persona? consulta = personas.Find(n => n.GetID() == idMedico);
            
          

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
                Console.WriteLine("Tratamiento: " + cita.Tratamientos);
            }
        }
    }
}
