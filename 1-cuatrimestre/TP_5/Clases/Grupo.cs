using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4.Clases
{
    class Grupo
    {
        public double random_1 { get; set; }
        public double random_2 { get; set; }
        public double timpoEntreLlegada { get; set; }
        public double proximaLlegada { get; set; }
        public bool utilizaRandom { get; set; }
        public int generoRandom { get; set; }
        public Eventos evento { get; set; }

    }
}
