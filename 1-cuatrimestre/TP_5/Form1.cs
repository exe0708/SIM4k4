using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TP_4.Clases;

namespace TP_4
{
    public partial class Form1 : Form
    {
        private List<Eventos> lista_eventos;
        private List<Objetos> lista_objetos;
        private List<Temporarios> lista_temporarios;
        public Form1()
        {
            InitializeComponent();
            lista_temporarios = new List<Temporarios>();
            cargarEventos();
            cargarObjetos();

        }

        private void calcularTiempos(Grupo grupo, int j, Simular sim, bool band)
        {
            Random random = new Random();
            // GENERO TEMPORARIO
            if (!band)
            {
                Temporarios temp = new Temporarios();
                if (sim.cola[0] == 0 || sim.cola[1] == 0 || sim.cola[2] == 0 && sim.cancha1 == 1 || sim.cancha2 == 1)
                {

                    if (sim.id_evento == 1)
                    {
                        if (sim.limpieza.ordena)
                        {
                            temp.id_estado = sim.id_evento;
                            temp.nombre = "Limpieza";
                            temp.tiempo_espera = 10.0;
                            temp.tiempo = sim.reloj;
                            temp.utilizado = false;
                        }
                        else
                        {
                            temp.id_estado = sim.id_evento;
                            temp.nombre = "Jugando";
                            temp.tiempo_espera = 0;
                            temp.tiempo = sim.reloj;
                            temp.utilizado = true;
                        }
                    }
                    else if (sim.cancha1 == 1 && sim.cancha2 == 1 && sim.id_evento == 2 || sim.id_evento == 0)
                    {
                        if (sim.limpieza.ordena)
                        {
                            temp.id_estado = sim.id_evento;
                            temp.nombre = "Limpieza";
                            temp.tiempo_espera = 10.0;
                            temp.tiempo = sim.reloj;
                            temp.utilizado = false;
                        }
                        else
                        {
                            temp.id_estado = sim.id_evento;
                            temp.nombre = "Jugando";
                            temp.tiempo_espera = 0;
                            temp.tiempo = sim.reloj;
                            temp.utilizado = true;
                        }
                    }

                }
                else
                {
                    if (sim.limpieza.ordena)
                    {
                        temp.id_estado = sim.id_evento;
                        temp.nombre = "Limpieza";
                        temp.tiempo_espera = 10;
                        temp.tiempo = sim.reloj;
                        temp.utilizado = false;
                    }
                    else
                    {
                        temp.id_estado = sim.id_evento;
                        temp.nombre = "Espera";
                        temp.tiempo_espera = 0;
                        temp.tiempo = sim.reloj;
                        temp.utilizado = false;
                    }
                }
                if (sim.id_evento <= 2)
                {
                    lista_temporarios.Add(temp);
                }
            }
            switch (j)
            {
                //FUTBOL LLEGADA
                case 0:
                    grupo.timpoEntreLlegada = -600 * Math.Log(1 - grupo.random_1);
                    grupo.random_1 = random.NextDouble();
                    grupo.evento = new Eventos();
                    grupo.evento.id = 0;
                    grupo.evento.nombre = "LlegadaFutbol";
                    //FUTBOL FIN CUANDO LLEGA
                    if (sim != null)
                    {
                        sim.grupos[j].timpoEntreLlegada = -600 * Math.Log(1 - grupo.random_1);
                        sim.grupos[j].random_1 = random.NextDouble();
                        sim.grupos[j].evento = new Eventos();
                        sim.grupos[j].evento.id = 0;
                        sim.grupos[j].evento.nombre = "LlegadaFutbol";
                        //SI PUEDE JUGAR
                        if (sim.cancha1 == 1 && sim.cancha2 == 1 && sim.cola[0] == 0)
                        {
                            //CUANDO UTILIZA UN RND NUEVO
                            if (sim.grupos[3].generoRandom == 2)
                            {
                                sim.grupos[3].random_1 = random.NextDouble();
                                sim.grupos[3].random_2 = random.NextDouble();
                                sim.grupos[3].generoRandom = 0;
                            }
                            //CUANDO UTILIZA EL 2 RANDOM
                            if (!sim.grupos[3].utilizaRandom)
                            {
                                sim.grupos[3].timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(sim.grupos[3].random_1)) * Math.Cos(2 * Math.PI * sim.grupos[3].random_2) * 10) + 90;
                                sim.grupos[3].proximaLlegada = sim.grupos[3].timpoEntreLlegada + sim.reloj;
                                sim.grupos[3].utilizaRandom = true;
                                grupo.generoRandom++;
                            }
                            else
                            {
                                sim.grupos[3].timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(sim.grupos[3].random_1)) * Math.Sin(2 * Math.PI * sim.grupos[3].random_2) * 10) + 90;
                                sim.grupos[3].proximaLlegada = sim.grupos[3].timpoEntreLlegada + sim.reloj;
                                sim.grupos[3].utilizaRandom = false;
                                grupo.generoRandom++;
                            }
                            sim.cancha1 = 2;
                            sim.cancha2 = 2;
                        }
                        //SUMO COLA
                        else
                        {
                            sim.cola[0]++;
                        }

                    }
                    break;
                //BASQUET LLEGADA
                case 1:
                    grupo.evento = new Eventos();
                    grupo.evento.id = 1;
                    grupo.evento.nombre = "LlegadaBasket";
                    //CUANDO UTILIZA UN RND NUEVO
                    if (grupo.generoRandom == 2)
                    {
                        grupo.random_1 = random.NextDouble();
                        grupo.random_2 = random.NextDouble();
                        grupo.generoRandom = 0;
                    }
                    //CUANDO UTILIZA EL 2 RANDOM
                    if (!grupo.utilizaRandom)
                    {
                        grupo.timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(grupo.random_1)) * Math.Cos(2 * Math.PI * grupo.random_2) * 120) + 480;
                        grupo.utilizaRandom = true;
                        grupo.generoRandom++;
                    }
                    else
                    {
                        grupo.timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(grupo.random_1)) * Math.Sin(2 * Math.PI * grupo.random_2) * 120) + 480;
                        grupo.utilizaRandom = false;
                        grupo.generoRandom++;
                    }
                    //FUTBOL FIN CUANDO LLEGA
                    if (sim != null)
                    {
                        sim.grupos[j].evento = new Eventos();
                        sim.grupos[j].evento.id = 1;
                        sim.grupos[j].evento.nombre = "LlegadaBasket";
                        //CUANDO UTILIZA UN RND NUEVO
                        if (sim.grupos[j].generoRandom == 2)
                        {
                            sim.grupos[j].random_1 = random.NextDouble();
                            sim.grupos[j].random_2 = random.NextDouble();
                            sim.grupos[j].generoRandom = 0;
                        }
                        //CUANDO UTILIZA EL 2 RANDOM
                        if (!sim.grupos[j].utilizaRandom)
                        {
                            sim.grupos[j].timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(sim.grupos[j].random_1)) * Math.Cos(2 * Math.PI * sim.grupos[j].random_2) * 120) + 480;
                            sim.grupos[j].utilizaRandom = true;
                            sim.grupos[j].generoRandom++;
                        }
                        else
                        {
                            sim.grupos[j].timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(sim.grupos[j].random_1)) * Math.Sin(2 * Math.PI * sim.grupos[j].random_2) * 120) + 480;
                            sim.grupos[j].utilizaRandom = false;
                            sim.grupos[j].generoRandom++;
                        }
                        //SI PUEDE JUGAR
                        if (sim.cancha1 == 1 || sim.cancha2 == 1 && sim.cola[0] == 0 && sim.cola[2] == 0)
                        {
                            sim.grupos[4].timpoEntreLlegada = 70 + (sim.grupos[4].random_1 * (130 - 70));
                            sim.grupos[4].random_1 = random.NextDouble();
                            sim.grupos[4].proximaLlegada = sim.grupos[4].timpoEntreLlegada + sim.reloj;

                            if (sim.cancha1 == 1 && sim.cancha2 == 1)
                            {
                                sim.cancha1 = 2;
                                sim.cancha2 = 1;
                            }
                            else if (sim.cancha1 == 1 && sim.cancha2 == 2)
                            {
                                sim.cancha1 = 2;
                            }
                            else if (sim.cancha1 == 2 && sim.cancha2 == 1)
                            {
                                sim.cancha2 = 2;
                            }

                        }
                        //SUMO COLA
                        else
                        {
                            sim.cola[1]++;
                        }

                    }
                    break;
                //HANDBALL LLEGADA
                case 2:
                    grupo.evento = new Eventos();
                    grupo.evento.id = 2;
                    grupo.evento.nombre = "LlegadaHandBall";
                    //CUANDO UTILIZA UN RND NUEVO
                    if (grupo.generoRandom == 2)
                    {
                        grupo.random_1 = random.NextDouble();
                        grupo.random_2 = random.NextDouble();
                        grupo.generoRandom = 0;
                    }
                    //CUANDO UTILIZA EL 2 RANDOM
                    if (!grupo.utilizaRandom)
                    {
                        grupo.timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(grupo.random_1)) * Math.Cos(2 * Math.PI * grupo.random_2) * 120) + 720;
                        grupo.utilizaRandom = true;
                        grupo.generoRandom++;
                    }
                    else
                    {
                        grupo.timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(grupo.random_1)) * Math.Sin(2 * Math.PI * grupo.random_2) * 120) + 720;
                        grupo.utilizaRandom = false;
                        grupo.generoRandom++;
                    }

                    //HANDBALL FIN CUANDO LLEGA
                    if (sim != null)
                    {
                        sim.grupos[j].evento = new Eventos();
                        sim.grupos[j].evento.id = 2;
                        sim.grupos[j].evento.nombre = "LlegadaHandBall";
                        //CUANDO UTILIZA UN RND NUEVO
                        if (sim.grupos[j].generoRandom == 2)
                        {
                            sim.grupos[j].random_1 = random.NextDouble();
                            sim.grupos[j].random_2 = random.NextDouble();
                            sim.grupos[j].generoRandom = 0;
                        }
                        //CUANDO UTILIZA EL 2 RANDOM
                        if (!sim.grupos[j].utilizaRandom)
                        {
                            sim.grupos[j].timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(sim.grupos[j].random_1)) * Math.Cos(2 * Math.PI * sim.grupos[j].random_2) * 120) + 720;
                            sim.grupos[j].utilizaRandom = true;
                            sim.grupos[j].generoRandom++;
                        }
                        else
                        {
                            sim.grupos[j].timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(sim.grupos[j].random_1)) * Math.Sin(2 * Math.PI * sim.grupos[j].random_2) * 120) + 720;
                            sim.grupos[j].utilizaRandom = false;
                            sim.grupos[j].generoRandom++;
                        }
                        //SI PUEDE JUGAR
                        if (sim.cancha1 == 1 && sim.cancha2 == 1 && sim.cola[2] == 0)
                        {
                            //CUANDO UTILIZA UN RND NUEVO
                            if (sim.grupos[5].generoRandom == 2)
                            {
                                sim.grupos[5].random_1 = random.NextDouble();
                                sim.grupos[5].random_2 = random.NextDouble();
                                sim.grupos[5].generoRandom = 0;
                            }
                            //CUANDO UTILIZA EL 2 RANDOM
                            if (!sim.grupos[5].utilizaRandom)
                            {
                                sim.grupos[5].timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(sim.grupos[5].random_1)) * Math.Cos(2 * Math.PI * sim.grupos[5].random_2) * 20) + 80;
                                sim.grupos[5].proximaLlegada = sim.grupos[5].timpoEntreLlegada + sim.reloj;
                                sim.grupos[5].utilizaRandom = true;
                                grupo.generoRandom++;
                            }
                            else
                            {
                                sim.grupos[5].timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(sim.grupos[5].random_1)) * Math.Sin(2 * Math.PI * sim.grupos[3].random_2) * 20) + 80;
                                sim.grupos[5].proximaLlegada = sim.grupos[5].timpoEntreLlegada + sim.reloj;
                                sim.grupos[5].utilizaRandom = false;
                                grupo.generoRandom++;
                            }
                            sim.cancha1 = 2;
                            sim.cancha2 = 2;
                        }
                        //SUMO COLA
                        else
                        {
                            sim.cola[2]++;
                        }
                    }
                    break;
                //FIN FUTBOL
                case 3:
                    grupo.evento = new Eventos();
                    grupo.evento.id = 3;
                    grupo.evento.nombre = "FinFutbol";
                    if (sim != null)
                    {
                        sim.limpieza = new Limpieza();
                        sim.limpieza.ordena = true;
                        sim.limpieza.acondicionamiento = 10.0;
                        sim.limpieza.finLimpieza = sim.reloj + sim.limpieza.acondicionamiento;
                        sim.cancha1 = 3;
                        sim.cancha2 = 3;
                        sim.grupos[3].proximaLlegada = 9999999;
                    }
                    break;
                //FIN BASQUET
                case 4:
                    grupo.evento = new Eventos();
                    grupo.evento.id = 4;
                    grupo.evento.nombre = "FinBasquet";
                    if (sim != null)
                    {
                        sim.limpieza = new Limpieza();
                        sim.limpieza.ordena = true;
                        sim.limpieza.acondicionamiento = 10.0;
                        sim.limpieza.finLimpieza = sim.reloj + sim.limpieza.acondicionamiento;
                        sim.cancha1 = 3;
                        sim.cancha2 = 3;
                        sim.grupos[4].proximaLlegada = 9999999;
                    }
                    break;
                //FIN HANDBALL
                case 5:
                    grupo.evento = new Eventos();
                    grupo.evento.id = 5;
                    grupo.evento.nombre = "FinHandball";
                    if (sim != null)
                    {
                        sim.limpieza = new Limpieza();
                        sim.limpieza.ordena = true;
                        sim.limpieza.acondicionamiento = 10.0;
                        sim.limpieza.finLimpieza = sim.reloj + sim.limpieza.acondicionamiento;
                        sim.cancha1 = 3;
                        sim.cancha2 = 3;
                        sim.grupos[5].proximaLlegada = 9999999;

                    }
                    break;
                //LIMPIEZA
                case 6:
                    sim.cancha1 = 1;
                    sim.cancha2 = 1;
                    sim.grupos[3].proximaLlegada = 999999;
                    sim.grupos[4].proximaLlegada = 999999;
                    sim.grupos[5].proximaLlegada = 999999;
                    if (sim != null)
                    {
                        var temporario = calcularLlegadaCola();
                        if (temporario.nombre != "")
                        {
                            if (sim.cola[0] > 0 && temporario.id_estado == 0)
                            {
                                if (sim.grupos[3].generoRandom == 2)
                                {
                                    sim.grupos[3].random_1 = random.NextDouble();
                                    sim.grupos[3].random_2 = random.NextDouble();
                                    sim.grupos[3].generoRandom = 0;
                                }
                                //CUANDO UTILIZA EL 2 RANDOM
                                if (!sim.grupos[3].utilizaRandom)
                                {
                                    sim.grupos[3].timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(sim.grupos[3].random_1)) * Math.Cos(2 * Math.PI * sim.grupos[3].random_2) * 10) + 90;
                                    sim.grupos[3].proximaLlegada = sim.grupos[3].timpoEntreLlegada + sim.reloj;
                                    sim.grupos[3].utilizaRandom = true;
                                    sim.grupos[3].generoRandom++;
                                }
                                else
                                {
                                    sim.grupos[3].timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(sim.grupos[3].random_1)) * Math.Sin(2 * Math.PI * sim.grupos[3].random_2) * 10) + 90;
                                    sim.grupos[3].proximaLlegada = sim.grupos[3].timpoEntreLlegada + sim.reloj;
                                    sim.grupos[3].utilizaRandom = false;
                                    sim.grupos[3].generoRandom++;
                                }
                                sim.cancha1 = 2;
                                sim.cancha2 = 2;
                                sim.cola[0]--;
                            }
                            else if (sim.cola[2] > 0 && temporario.id_estado == 2)
                            {
                                if (sim.grupos[5].generoRandom == 2)
                                {
                                    sim.grupos[5].random_1 = random.NextDouble();
                                    sim.grupos[5].random_2 = random.NextDouble();
                                    sim.grupos[5].generoRandom = 0;
                                }
                                //CUANDO UTILIZA EL 2 RANDOM
                                if (!sim.grupos[5].utilizaRandom)
                                {
                                    sim.grupos[5].timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(sim.grupos[5].random_1)) * Math.Cos(2 * Math.PI * sim.grupos[5].random_2) * 20) + 80;
                                    sim.grupos[5].proximaLlegada = sim.grupos[5].timpoEntreLlegada + sim.reloj;
                                    sim.grupos[5].utilizaRandom = true;
                                    sim.grupos[5].generoRandom++;
                                }
                                else
                                {
                                    sim.grupos[5].timpoEntreLlegada = (Math.Sqrt(-2 * Math.Log(sim.grupos[5].random_1)) * Math.Sin(2 * Math.PI * sim.grupos[3].random_2) * 20) + 80;
                                    sim.grupos[5].proximaLlegada = sim.grupos[5].timpoEntreLlegada + sim.reloj;
                                    sim.grupos[5].utilizaRandom = false;
                                    sim.grupos[5].generoRandom++;
                                }
                                sim.cancha1 = 2;
                                sim.cancha2 = 2;
                                sim.cola[2]--;
                            }
                            else if (sim.cola[1] > 0 && temporario.id_estado == 1)
                            {
                                sim.grupos[4].timpoEntreLlegada = 70 + (sim.grupos[4].random_1 * (130 - 70));
                                sim.grupos[4].random_1 = random.NextDouble();
                                sim.grupos[4].proximaLlegada = sim.grupos[4].timpoEntreLlegada + sim.reloj;

                                if (sim.cancha1 == 1 && sim.cancha2 == 1)
                                {
                                    sim.cancha1 = 2;
                                    sim.cancha2 = 1;
                                }
                                else if (sim.cancha1 == 1 && sim.cancha2 == 2)
                                {
                                    sim.cancha1 = 2;
                                }
                                else if (sim.cancha1 == 2 && sim.cancha2 == 1)
                                {
                                    sim.cancha2 = 2;
                                }
                                sim.cola[1]--;
                            }

                        }
                    }

                    break;

            }

        }

        // CALCULO EL MENOR TEMPORARTIO
        private Temporarios calcularLlegadaCola()
        {
            double menor = 999999;
            Temporarios objeto_menor = new Temporarios();
            int contador = 0;
            int puntero = 0;
            foreach (var temp in lista_temporarios)
            {
                contador++;
                if (temp.tiempo < menor && !temp.utilizado)
                {
                    menor = temp.tiempo;
                    objeto_menor = temp;
                    puntero = contador;
                }
            }
            if (puntero != 0)
            {
                lista_temporarios[puntero - 1].utilizado = true;
            }
            else
            {
                lista_temporarios[puntero].utilizado = true;
            }
            return objeto_menor;
        }
        //CALCULO LA LLEGADA DEL PROXIMO EVENTO MIRANDO EL MENOR TIEMPO
        private void calcularProximoEvento(Simular sim)
        {
            double menor = 999999;
            foreach (var grupo in sim.grupos)
            {
                if (grupo.proximaLlegada < menor && grupo.proximaLlegada > 0)
                {
                    menor = grupo.proximaLlegada;
                    sim.nombre_evento = grupo.evento.nombre;
                    sim.id_evento = grupo.evento.id;
                }
            }
            if (sim.limpieza.finLimpieza < menor)
            {
                menor = sim.limpieza.finLimpieza;
                sim.nombre_evento = "FinLimpieza";
                sim.id_evento = 6;
                sim.limpieza.ordena = false;
                sim.limpieza.finLimpieza = 9999999;
            }
            sim.reloj = menor;
        }
        //SIMULO
        private void btn_simular_Click(object sender, EventArgs e)
        {
            double minutos = double.Parse(txt_minutos.Text);
            double cont = 0;
            int cont2 = 0;
            bool band;
            int desde = -1, hasta = -1, dia, dif = -1, limite = 0;
            Random random = new Random();
            List<Simular> lista = new List<Simular>();
            Simular anterior = new Simular();

            do
            {
                Simular sim = new Simular();
                sim = anterior;
                if (cont == 0)
                {
                    sim.reloj = 0;
                    sim.limpieza = new Limpieza();
                    sim.grupos = new List<Grupo>();
                    sim.cola = new int[3];
                    sim.limpieza.ordena = false;
                    sim.limpieza.finLimpieza = 9999999;
                    sim.cancha1 = 1;
                    sim.cancha2 = 1;
                    for (int j = 0; j < 6; j++)
                    {
                        Grupo grupo = new Grupo();
                        grupo.random_1 = random.NextDouble();
                        grupo.random_2 = random.NextDouble();
                        calcularTiempos(grupo, j, null, true);
                        grupo.proximaLlegada = grupo.timpoEntreLlegada + sim.reloj;
                        sim.grupos.Add(grupo);
                        if (j < 3)
                        {
                            sim.cola[j] = 0;
                        }
                    }

                    calcularProximoEvento(sim);
                    calcularTiempos(sim.grupos[sim.id_evento], sim.id_evento, sim, false);
                    sim.grupos[sim.id_evento].proximaLlegada = sim.grupos[sim.id_evento].timpoEntreLlegada + sim.reloj;
                    cont = sim.reloj;
                    lista.Add(sim);
                }
                else
                {
                    calcularProximoEvento(sim);
                    if (sim.id_evento != 6)
                    {
                        calcularTiempos(sim.grupos[sim.id_evento], sim.id_evento, sim, false);
                        sim.grupos[sim.id_evento].proximaLlegada = sim.grupos[sim.id_evento].timpoEntreLlegada + sim.reloj;
                    }
                    else
                    {
                        calcularTiempos(null, sim.id_evento, sim, false);
                    }
                    cont = sim.reloj;

                }
                Simular insertar = new Simular();
                insertar.cancha1 = sim.cancha1;
                insertar.cancha2 = sim.cancha2;
                insertar.id_evento = sim.id_evento;
                insertar.nombre_evento = sim.nombre_evento;
                insertar.reloj = sim.reloj;
                insertar.cola = sim.cola;
                insertar.grupos = sim.grupos;
                insertar.limpieza = sim.limpieza;
                insertar.colaFutbol = sim.cola[0];
                insertar.colaBasquet = sim.cola[1];
                insertar.colaHandball = sim.cola[2];

                lista.Insert(cont2, insertar);
                cont++;
                anterior = sim;

                band = cont >= minutos;
            } while (!band);
            armarGrilla(lista);
        }

        private void armarGrilla(List<Simular> simular) 
        {
            dg_simulacion.Columns.Add("nombre_evento", "Nombre Evento");
            dg_simulacion.Columns.Add("reloj", "Reloj");
            dg_simulacion.Columns.Add("cancha1", "Cancha 1");
            dg_simulacion.Columns.Add("cancha2", "Cancha 2");
            dg_simulacion.Columns.Add("ordena", "Ordena");
            dg_simulacion.Columns.Add("acondicionamiento", "Acondicionamiento");
            dg_simulacion.Columns.Add("finLimpieza", "Fin Limpieza");
            dg_simulacion.Columns.Add("colaFutbol", "Cola Futbol");
            dg_simulacion.Columns.Add("colaBasquet", "Cola Basquet");
            dg_simulacion.Columns.Add("colaHandballl", "Cola Handball");


            dg_simulacion.Columns.Add("random1Fut", "Random");
            dg_simulacion.Columns.Add("tiempoEntreLlegadaFut", "Tiempo Entre Llegada");
            dg_simulacion.Columns.Add("tiempoProximaLlegadaFut", "Proxima Llegada");

            dg_simulacion.Columns.Add("random1Bask", "Random 1 Futbol");
            dg_simulacion.Columns.Add("random2Bask", "Random 2 Futbol");
            dg_simulacion.Columns.Add("tiempoEntreLlegadaBask", "Tiempo Entre Llegada Futbol");
            dg_simulacion.Columns.Add("tiempoProximaLlegadaBask", "Proxima Llegada Futbol");

            dg_simulacion.Columns.Add("random1Hand", "Random 1 Handball");
            dg_simulacion.Columns.Add("random2Hand", "Random 2 Handball");
            dg_simulacion.Columns.Add("tiempoEntreLlegadaHand", "Tiempo Entre Llegada Handball");
            dg_simulacion.Columns.Add("tiempoProximaLlegadaHand", "Proxima Llegada Handball");

            dg_simulacion.Columns.Add("random1FinFut", "Random 1 Fin Futbol");
            dg_simulacion.Columns.Add("random2FinFut", "Random 2 Fin Futbol");
            dg_simulacion.Columns.Add("tiempoFinLlegadaFut", "Tiempo Entre Llegada Fin Futbol");
            dg_simulacion.Columns.Add("tiempoFinFut", "Fin Futbol");

            dg_simulacion.Columns.Add("random1FinBask", "Random 1 Fin Basquet");
            dg_simulacion.Columns.Add("tiempoFinLlegadaBask", "Tiempo Entre Llegada Fin Basquet");
            dg_simulacion.Columns.Add("tiempoFinBask", "Fin Basquet");

            dg_simulacion.Columns.Add("random1FinHand", "Random 1 Fin Handball");
            dg_simulacion.Columns.Add("random2FinHand", "Random 2 Fin Handball ");
            dg_simulacion.Columns.Add("tiempoFinLlegadaHand", "Tiempo Entre Llegada Fin Handball");
            dg_simulacion.Columns.Add("tiempoFinHand", "Fin Handball");

            foreach (var simulacion in simular)
            {
                /*   
                dg_simulacion.Rows[index].Cells["random1Fut"].Value = "";
                dg_simulacion.Rows[index].Cells["tiempoEntreLlegadaFut"].Value = "";
                dg_simulacion.Rows[index].Cells["tiempoProximaLlegadaFut"].Value = "";

                dg_simulacion.Rows[index].Cells["random1Bask"].Value = "";
                dg_simulacion.Rows[index].Cells["random2Bask"].Value = "";
                dg_simulacion.Rows[index].Cells["tiempoEntreLlegadaBask"].Value = "";
                dg_simulacion.Rows[index].Cells["tiempoProximaLlegadaBask"].Value = "";

                dg_simulacion.Rows[index].Cells["random1Hand"].Value = "";
                dg_simulacion.Rows[index].Cells["random2Hand"].Value = "";
                dg_simulacion.Rows[index].Cells["tiempoEntreLlegadaHand"].Value = "";
                dg_simulacion.Rows[index].Cells["tiempoProximaLlegadaHand"].Value = "";

                dg_simulacion.Rows[index].Cells["random1FinFut"].Value = "";
                dg_simulacion.Rows[index].Cells["random2FinFut"].Value = "";
                dg_simulacion.Rows[index].Cells["tiempoFinLlegadaFut"].Value = "";
                dg_simulacion.Rows[index].Cells["tiempoFinFut"].Value = "";

                dg_simulacion.Rows[index].Cells["random1FinBask"].Value = "";
                dg_simulacion.Rows[index].Cells["tiempoFinLlegadaBask"].Value = "";
                dg_simulacion.Rows[index].Cells["tiempoFinBask"].Value = "";

                dg_simulacion.Rows[index].Cells["random1FinHand"].Value = "";
                dg_simulacion.Rows[index].Cells["random2FinHand"].Value = "";
                dg_simulacion.Rows[index].Cells["tiempoFinLlegadaHand"].Value = "";
                dg_simulacion.Rows[index].Cells["tiempoFinHand"].Value = "";*/
                foreach (var grupo in simulacion.grupos)
                {
                    if(grupo.evento.id == simulacion.id_evento)
                    {
                        var index = dg_simulacion.Rows.Add();
                        dg_simulacion.Rows[index].Cells["nombre_evento"].Value = simulacion.nombre_evento;
                        dg_simulacion.Rows[index].Cells["reloj"].Value = simulacion.reloj;
                        dg_simulacion.Rows[index].Cells["ordena"].Value = simulacion.limpieza.ordena;
                        dg_simulacion.Rows[index].Cells["acondicionamiento"].Value = simulacion.limpieza.acondicionamiento;
                        dg_simulacion.Rows[index].Cells["finLimpieza"].Value = simulacion.limpieza.finLimpieza;
                        dg_simulacion.Rows[index].Cells["cancha1"].Value = simulacion.cancha1;
                        dg_simulacion.Rows[index].Cells["cancha2"].Value = simulacion.cancha2;
                        dg_simulacion.Rows[index].Cells["colaFutbol"].Value = simulacion.colaFutbol;
                        dg_simulacion.Rows[index].Cells["colaBasquet"].Value = simulacion.colaBasquet;
                        dg_simulacion.Rows[index].Cells["colaHandballl"].Value = simulacion.colaHandball;

                        switch (grupo.evento.id)
                        {
                            case 0:
                                dg_simulacion.Rows[index].Cells["random1Fut"].Value = grupo.random_1;
                                dg_simulacion.Rows[index].Cells["tiempoEntreLlegadaFut"].Value = grupo.timpoEntreLlegada;
                                dg_simulacion.Rows[index].Cells["tiempoProximaLlegadaFut"].Value = grupo.proximaLlegada;
                                break;
                            case 1:
                                dg_simulacion.Rows[index].Cells["random1Bask"].Value = grupo.random_1;
                                dg_simulacion.Rows[index].Cells["random2Bask"].Value = grupo.random_2;
                                dg_simulacion.Rows[index].Cells["tiempoEntreLlegadaBask"].Value = grupo.timpoEntreLlegada;
                                dg_simulacion.Rows[index].Cells["tiempoProximaLlegadaBask"].Value = grupo.proximaLlegada;
                                break;
                            case 2:
                                dg_simulacion.Rows[index].Cells["random1Hand"].Value = grupo.random_1;
                                dg_simulacion.Rows[index].Cells["random2Hand"].Value = grupo.random_2;
                                dg_simulacion.Rows[index].Cells["tiempoEntreLlegadaHand"].Value = grupo.timpoEntreLlegada;
                                dg_simulacion.Rows[index].Cells["tiempoProximaLlegadaHand"].Value = grupo.proximaLlegada;
                                break;
                            case 3:
                                dg_simulacion.Rows[index].Cells["random1FinFut"].Value = grupo.random_1;
                                dg_simulacion.Rows[index].Cells["random2FinFut"].Value = grupo.random_2;
                                dg_simulacion.Rows[index].Cells["tiempoFinLlegadaFut"].Value = grupo.timpoEntreLlegada;
                                dg_simulacion.Rows[index].Cells["tiempoFinFut"].Value = grupo.proximaLlegada;
                                break;
                            case 4:
                                dg_simulacion.Rows[index].Cells["random1FinBask"].Value = grupo.random_1;
                                dg_simulacion.Rows[index].Cells["tiempoFinLlegadaBask"].Value = grupo.timpoEntreLlegada;
                                dg_simulacion.Rows[index].Cells["tiempoFinBask"].Value = grupo.proximaLlegada;
                                break;
                            case 5:
                                dg_simulacion.Rows[index].Cells["random1FinHand"].Value = simulacion;
                                dg_simulacion.Rows[index].Cells["random2FinHand"].Value = simulacion;
                                dg_simulacion.Rows[index].Cells["tiempoFinLlegadaHand"].Value = simulacion;
                                dg_simulacion.Rows[index].Cells["tiempoFinHand"].Value = simulacion;
                                break;

                        }
                        
                        
                    }
                    else if (simulacion.id_evento == 6 && grupo.evento.id==5)
                    {
                        var index = dg_simulacion.Rows.Add();
                        dg_simulacion.Rows[index].Cells["nombre_evento"].Value = simulacion.nombre_evento;
                        dg_simulacion.Rows[index].Cells["reloj"].Value = simulacion.reloj;
                        dg_simulacion.Rows[index].Cells["ordena"].Value = simulacion.limpieza.ordena;
                        dg_simulacion.Rows[index].Cells["acondicionamiento"].Value = simulacion.limpieza.acondicionamiento;
                        dg_simulacion.Rows[index].Cells["finLimpieza"].Value = simulacion.limpieza.finLimpieza;
                        dg_simulacion.Rows[index].Cells["cancha1"].Value = simulacion.cancha1;
                        dg_simulacion.Rows[index].Cells["cancha2"].Value = simulacion.cancha2;
                        dg_simulacion.Rows[index].Cells["colaFutbol"].Value = simulacion.colaFutbol;
                        dg_simulacion.Rows[index].Cells["colaBasquet"].Value = simulacion.colaBasquet;
                        dg_simulacion.Rows[index].Cells["colaHandballl"].Value = simulacion.colaHandball;
                    }
                }
                
            }

        }

        private void cargarObjetos()
        {
            lista_objetos = new List<Objetos>();
            for (int k = 0; k < 4; k++)
            {
                Objetos objeto = new Objetos();
                objeto.estado = new List<Estado>();
                objeto.tipo_objeto = new TipoObjeto();
                switch (k)
                {
                    case 0:
                        objeto.nombre = "GrupoFutbol";
                        break;
                    case 1:
                        objeto.nombre = "GrupoBasket";
                        break;
                    case 2:
                        objeto.nombre = "GrupoHandball";
                        break;
                    case 3:
                        objeto.nombre = "Cancha";
                        objeto.tipo_objeto.id = 2;
                        objeto.tipo_objeto.nombre = "Permanente";
                        Estado libre = new Estado();
                        libre.id = 1;
                        libre.nombre = "Libre (L)";
                        Estado ocupado = new Estado();
                        ocupado.id = 2;
                        ocupado.nombre = " Ocupada (O)";
                        Estado limpieza = new Estado();
                        limpieza.id = 3;
                        limpieza.nombre = " En Limpieza (EL)";
                        objeto.estado.Add(libre);
                        objeto.estado.Add(limpieza);
                        objeto.estado.Add(ocupado);
                        break;
                }
                if (k != 3)
                {
                    Estado jugado = new Estado();
                    jugado.id = 1;
                    jugado.nombre = "Jugando (J)";
                    Estado espera = new Estado();
                    espera.id = 2;
                    espera.nombre = "En Espera (EE)";
                    Estado limpieza = new Estado();
                    limpieza.id = 3;
                    limpieza.nombre = "En Espera Limpieza (EEL)";
                    objeto.estado.Add(jugado);
                    objeto.estado.Add(limpieza);
                    objeto.estado.Add(espera);
                    objeto.tipo_objeto.id = 1;
                    objeto.tipo_objeto.nombre = "Temporal";

                }
                lista_objetos.Add(objeto);

            }
            dg_objetos.DataSource = lista_objetos;
        }

        private void cargarEventos()
        {
            lista_eventos = new List<Eventos>();

            for (int j = 0; j < 7; j++)
            {
                Eventos evento = new Eventos();
                evento.tipoDistribucion = new TipoDistribucion();
                switch (j)
                {
                    case 0:
                        evento.nombre = "LlegadaFutbol";
                        evento.tipoDistribucion.id = 1;
                        evento.tipoDistribucion.nombre = "Exp Neg";
                        evento.tipoDistribucion.formula = "X = -600*LN(1-RND)";
                        break;
                    case 1:
                        evento.nombre = "LlegadaBasket";
                        evento.tipoDistribucion.id = 2;
                        evento.tipoDistribucion.nombre = "Normal";
                        evento.tipoDistribucion.formula = "X = (√(-2*LN(RND))*Cos(2*∏*RND2))*120 + 480";
                        break;
                    case 2:
                        evento.nombre = "LlegadaHandBall";
                        evento.tipoDistribucion.id = 2;
                        evento.tipoDistribucion.nombre = "Normal";
                        evento.tipoDistribucion.formula = "X = (√(-2*LN(RND))*Cos(2*∏*RND2))*120 + 720";
                        break;
                    case 3:
                        evento.nombre = "FinFutbol";
                        evento.tipoDistribucion.id = 2;
                        evento.tipoDistribucion.nombre = "Normal";
                        evento.tipoDistribucion.formula = "X = (√(-2*LN(RND))*Cos(2*∏*RND2))*10 + 90";
                        break;
                    case 4:
                        evento.nombre = "FinBasket";
                        evento.tipoDistribucion.id = 3;
                        evento.tipoDistribucion.nombre = "Uniforme";
                        evento.tipoDistribucion.formula = "X = 70 + RND*(130-70)";
                        break;
                    case 5:
                        evento.nombre = "FinHandBall";
                        evento.tipoDistribucion.id = 2;
                        evento.tipoDistribucion.nombre = "Normal";
                        evento.tipoDistribucion.formula = "X = (√(-2*LN(RND))*Cos(2*∏*RND2))*20 + 80";
                        break;
                    case 6:
                        evento.nombre = "FinLimpieza";
                        evento.tipoDistribucion.id = 4;
                        evento.tipoDistribucion.nombre = "ninguna";
                        evento.tipoDistribucion.formula = "10";
                        break;
                }
                lista_eventos.Add(evento);

            }
            dg_eventos.DataSource = lista_eventos;


        }
    }
}



