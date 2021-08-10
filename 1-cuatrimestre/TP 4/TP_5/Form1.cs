using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP_4
{
    public partial class Form1 : Form
    {
        //private List<Distribucion> lista_distribucion_frecuencia;
        public Form1()
        {
            InitializeComponent();
            //Cargar las listas de Eventos y Objetos ya cargados en un vector en el data source de el dg
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            // Hacer lo q haya q hacer con la simulacion y queda el codigo q muestra solamente las filas que desea el usuario agregando la ultima al final
            int cantidad = -1;
            int desde = -1, hasta = -1, dia, dif = -1, limite = 0;
            Random random = new Random();


            for (int i = 0; i < cantidad; i++)
            {


                if (i >= desde && limite < hasta)
                {
                    limite++;
                }
                if (i == cantidad - 1)
                {

                }
            }

        }
    }
}



