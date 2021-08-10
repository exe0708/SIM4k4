using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4
{
    class Simulacion
    {
        public Eventos evento { get; set; }
        public Objetos objeto { get; set; }
        
        public double reloj { get; set; }
        public bool limpia { get; set; }
        public bool ocupa { get; set; }
        public int prioridad { get; set; }
        //Evento Limpieza
        public double tiempoLimpieza { get; set; }
        public double tiempoFinLimpieza { get; set; }
        // Futbol
        public double tiempoLlegadaFutbol { get; set; }
        public double tiempoProximaLlegadaFutbol { get; set; }
        public double tiempoFinFutbol { get; set; }
        public double tiempoFutbolFinal { get; set; }
        // Random Futbol 
        public double randomLlegadaFutbol { get; set; }
        public double random1FinFutbol { get; set; }
        public double random2FinFutbol { get; set; }

        // Basquet
        public double tiempoLlegadaBasquet { get; set; }
        public double tiempoProximaLlegadaBasquet { get; set; }
        public double tiempoFinBasquet { get; set; }
        public double tiempoBasquetFinal { get; set; }
        //Random Basquet
        public double ramdom1LlegadaBasquet { get; set; }
        public double ramdom2LlegadaBasquet { get; set; }
        public double ramdom1FinBasquet { get; set; }
        public bool utilizaBasquet { get; set; }
        public bool generaRandomBasquet { get; set; }

        //Handball
        public double tiempoLlegadaHandball { get; set; }
        public double tiempoProximaLlegadaHandball { get; set; }
        public double tiempoFinHandball { get; set; }
        public double tiempoHandballFinal { get; set; }

        //Random Basquet
        public double ramdom1LlegadaHandbal { get; set; }
        public double ramdom2LlegadaHandbal { get; set; }
        public double ramdom1FinHandbal { get; set; }
        public double ramdom2FinHandbal { get; set; }
        public bool generaRandomHanball { get; set; }
        public bool utilizaHandball { get; set; }

    }
}
