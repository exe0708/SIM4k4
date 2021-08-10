using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4.Clases
{
    class Simular
    {
        public int id_evento { get; set; }
        public string nombre_evento { get; set; }
        public double reloj { get; set; }
        public Limpieza limpieza { get; set; }
        public List<Grupo> grupos { get; set; }
        public int [] cola { get; set; }
        public int cancha1 { get; set; }
        public int cancha2 { get; set; }
        public int colaFutbol { get; set; }
        public int colaBasquet { get; set; }
        public int colaHandball { get; set; }
    }
}
