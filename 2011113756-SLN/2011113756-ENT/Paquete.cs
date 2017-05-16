using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756_ENT
{
    public class Paquete
    {
        public int PaqueteId { get; set; }
        public List<ServicioTuristico> Servicios { get; set; }

        public Paquete()
        {
            Servicios = new List<ServicioTuristico>();
        }
    }
}

