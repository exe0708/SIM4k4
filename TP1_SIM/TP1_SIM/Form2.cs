using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_SIM
{
    public partial class Form2 : Form
    {
        List<eTfrecuencia> olTablaFrec = new List<eTfrecuencia>();   
        public Form2()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxCantNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtPrueba_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                oGridFrec.DataSource = null; // Limpio el datasource de la grilla para limpiarla
                oGridFrec.Refresh();

                Int32 Intervalos = Int32.Parse(txCantIntervalo.Text); // leo la cantidad de interbalos del textbox
                Int32 CantidadAleatorios = Int32.Parse(txCantNro.Text); // leo la cantidad de Numero aleatroios a generar del textbox

                List<eNroPseudo> olRandom = new List<eNroPseudo>(); // Creo una lista de objetos eNroPseudo
                Random Numero = new Random();                       // Creo un objeto Random para generar ls numeros aleatorios 

                for (int i = 0; i < CantidadAleatorios; i++)
                {
                    eNroPseudo oNumero = new eNroPseudo();          // creo un Objeto enroPseudo y le asigno a la propiedad Numero, el numero 
                    oNumero.Numero = Math.Round(Numero.NextDouble(), 4);           // aleatorio que genero con el random.
                    olRandom.Add(oNumero);       // agrego el objeto a la lista
                }

                olRandom = olRandom.OrderBy(p=>p.Numero).ToList();  // ordeno la lista de menor a mayor
                Double Min = olRandom.First().Numero;   // Obtengo el primero de los numeros aleatorios de la lista (menor numero)
                Double Max = olRandom.Last().Numero;    // Obtengo el ultimo numero de la lista  (Mayor numero)
                Double Paso = (Max - Min) / Intervalos;   // Calculo el paso
                Double Frecuencia = CantidadAleatorios / Intervalos;  // Calculo la frecuancia

                
                for (int i = 0; i < Intervalos; i++)
                {
                    eTfrecuencia oFrecuencia = new eTfrecuencia();   //Creo un objeto etFrecuencia
                    oFrecuencia.Min = Math.Round(Min, 4);                            // asigno al atributo Min el valor del numero menor
                    Double Maximo = Min + Paso;
                    oFrecuencia.Max = Math.Round( Maximo,4);                          // asigno al atributo Max el valor del maximo numero del intervalo
                    oFrecuencia.FrecAbsoluta = olRandom.Count(p => (p.Numero >= Min) && (p.Numero <= Maximo)); // Obtengo la cantidad de numeros de la lista dentro del intervalo (min - max
                    oFrecuencia.FrecEsperado = Frecuencia;    // asigno la frecuencia 
                    olTablaFrec.Add(oFrecuencia);   // agego el objeto a la lista
                    Min = Min + Paso;  // calculo el nuevo limite inferior para el siguiente intervalo.
                }

                oGridFrec.DataSource = olTablaFrec;   // asigno la lista como origen de datos de la grilla
                oGridFrec.Refresh();                    // actualizo la grilla

            }
        }

        private bool Validacion()
        {
            bool resultado = false;
            try
            {
                if(String.IsNullOrEmpty(txCantIntervalo.Text) || (String.IsNullOrEmpty(txCantNro.Text)))
                {
                    MessageBox.Show("Debe ingresar la cantidad de intervalos y la cantidad de numeros a generar");
                }
                else
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resultado;
        }

        private void BtGraficar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
