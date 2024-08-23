using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Grupal
{
    internal class Tratamiento
    {
        private int IDTratamiento { get; set; }
        public List<Medicamentos> Medicamento { get; set; }
        protected int CitaMedica { get; set; }

        public Tratamiento(int iDTratamiento, List<Medicamentos> medicamento, int citaMedica)
        {
            IDTratamiento = iDTratamiento;
            Medicamento = medicamento;
            CitaMedica = citaMedica;
        }
        private static int contadorID = 1;
        public void ProgramarTratamiento(List<Cita_medica> citaMedicaList, List<Tratamiento> tratamientoList, List<Medicamentos> medicamentosList) 
        {
            Console.WriteLine("--- Tratamiento ---");
            Console.Write("ID Cita Médica: ");
            int idCita = int.Parse(Console.ReadLine()??"");
            Cita_medica? citaFind = citaMedicaList.Find(c => c.NumeroCita == idCita);
            if (citaFind != null)
            {
                agregarmedicamentos(medicamentosList);
                tratamientoList.Add(new Tratamiento(contadorID++, medicamentosList, idCita));
            }
            else
            {
                Console.WriteLine("No hay ninguna cita añadida");
            }
        }
            public void agregarmedicamentos(List<Medicamentos> medicamentoList)
        {
            bool run = true;
            do
            {
                Console.Write("Descripción: ");
                string descripcion = Console.ReadLine()??"";
                Console.Write("Duración: ");
                string duracion = Console.ReadLine() ?? "";
                Medicamentos? medicamentoFind = medicamentoList.Find(p => p.Descripcion == descripcion);
                if (medicamentoFind != null)
                {
                    medicamentoList.Add(new Medicamentos(descripcion, duracion));
                    Console.WriteLine("Medicamento añadido con éxito");
                }
                else
                {
                    Console.WriteLine("Medicamento ya indicado");
                }
                Console.WriteLine("\nAgregar Otro Medicamento (s/n): ");
                string opcion = Console.ReadLine()??"".ToLower()??"";
                bool runDos = true;
                do
                {
                    if (opcion == "s")
                    {
                        run = true;
                        runDos = false;
                    }
                    else if (opcion == "n")
                    {
                        run = false;
                        runDos = false;
                    }
                    else
                    {
                        Console.WriteLine("Añada un valor válido");
                        runDos = true;

                    }
                } while (runDos == true); 
            } while (run == true);
            
        }
        public void MostrarTratamiento(List<Tratamiento> tratamientoList, List<Medicamentos> medicamentoList)
        {
            Console.Write("ID del tratamiento: ");
            int idTratamiento = int.Parse(Console.ReadLine()??"");
            Tratamiento? tratamientoFind = tratamientoList.Find(t => t.IDTratamiento == idTratamiento);
            if (tratamientoFind != null)
            {
                Console.WriteLine($"\n--- Tratamiento No.{idTratamiento} ---\nCita Médica: {tratamientoFind.CitaMedica}");
                Console.WriteLine();
                foreach (var medicamento in medicamentoList)
                {
                    Console.WriteLine($"Descripción: {medicamento.Descripcion}\tDuración: {medicamento.Duracion}");
                }
                Console.WriteLine("Hospital Pediátrico Alegría");
            }
        }
        

    }
}
