using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.ESTRUCTURA.Entities
{
    public class Alumno
    {
        public int id {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaIngreso { get; set; }

        public int Grado { get; set; }
        public double Promedio { get; set; }

    }
}
