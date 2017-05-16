using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756_ENT
{
    public class Empleado : Persona
    {
        public int EmpleadoId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public String Cargo { get; set; }

    }
}
