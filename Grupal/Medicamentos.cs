using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupal
{
    internal class Medicamentos
    {
        public string Descripcion { get; set; }
        public string Duracion { get; set; }

        public Medicamentos(string descripcion, string duracion)
        {
            Descripcion = descripcion;
            Duracion = duracion;
        }
    }
}
