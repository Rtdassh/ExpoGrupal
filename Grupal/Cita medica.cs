using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupal
{
    internal class Cita_medica
    {

        protected int NumeroCita {  get; set; }
        protected DateTime Fecha { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        protected string Diagnostico { get; set; }
        protected List<Tratamiento> Tratamientossss { get; set; }

       public Cita_medica(int numeroCita, DateTime fecha, Medico medico, Paciente paciente, string diagnostico, List<Tratamiento> tratamientossss)
        {
            NumeroCita = numeroCita;
            Fecha = fecha;
            Medico = medico;
            Paciente = paciente;
            Diagnostico = diagnostico;
            Tratamientossss = tratamientossss;
        }
       
    }
}
