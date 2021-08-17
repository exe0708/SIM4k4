using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SIM_NUEVO
{
    public class MetodoGenerador
    {
        public int semilla { get; set; }
        public int a { get; set; }
        public int c { get; set; }
        public int m { get; set; }

        public MetodoGenerador(int semilla, int a, int c, int m)
        {
            this.semilla = semilla;
            this.a = a;
            this.c = c;
            this.m = m;
        }

        public bool tipoMetodo()
        {
            return false;
        }
    }
}
