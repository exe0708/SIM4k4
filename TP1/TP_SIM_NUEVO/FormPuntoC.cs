using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TP_SIM_NUEVO
{
    public partial class FormPuntoC : Form
    {
        public MetodoGenerador metodo;
        public List<Numero> lista_numeros;
        List<Frecuencia> olTablaFrec = new List<Frecuencia>();
        List<double> lista_numeros_plano = new List<double>();
        List<Numero> lista_aleatorios = new List<Numero>();
        public FormPuntoC()
        {
            InitializeComponent();
            btn_graficar.Enabled = false;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (!String.IsNullOrEmpty(txt_intervalos.Text) || !String.IsNullOrEmpty(txt_cantidad.Text))
                {
                    calcularIntervalos(calcularNumeros());
                }
                else
                {
                    MessageBox.Show("Ingrese cantidad de intervalos y cantidad de numeros a generar");
                }
            }
        }
        private List<double> calcularNumeros()
        {
            
                lista_numeros = new List<Numero>();
                lista_numeros_plano = new List<double>();
                metodo = new MetodoGenerador(int.Parse(tx_semilla.Text), int.Parse(txt_a.Text), int.Parse(txt_c.Text), int.Parse(txt_m.Text));
                var cantidad = int.Parse(txt_cantidad.Text);
                for (int i = 0; i < cantidad; i++)
                {
                    Numero aleatorio = new Numero();
                    aleatorio.indice = i + 1;
                    var residuo = ((metodo.a * metodo.semilla) + metodo.c) % metodo.m;
                    aleatorio.numero_aleatorio = Math.Round((double)residuo / metodo.m, 4);
                    aleatorio.semilla = residuo;
                    metodo.semilla = residuo;
                    lista_numeros_plano.Add(aleatorio.numero_aleatorio);
                    lista_numeros.Add(aleatorio);
                }
                dgwDatos.DataSource = lista_numeros;
               
            
            return lista_numeros_plano;
        }
        public void calcularIntervalos(List<double> lista)
        {
            olTablaFrec = new List<Frecuencia>();
            lista = lista.GetRange(0, lista.Count);
            Double Paso = 0;
            var intervalo = int.Parse(txt_intervalos.Text);
            Int32 CantidadAleatorios = Int32.Parse(txt_cantidad.Text);
            Double Min = lista.Min();
            Double Max = lista.Max();
            Paso = (Max - Min) / intervalo;
            Double Frecuencia = CantidadAleatorios / intervalo;
            Double sumChi = 0;

            for (int i = 0; i < intervalo; i++)
            {
                Frecuencia oFrecuencia = new Frecuencia();
                oFrecuencia.LimInferior = Math.Round(Min, 4);
                Double Maximo = Min + Paso;
                oFrecuencia.LimSuperior = Math.Round(Maximo, 4);
                if (i == intervalo - 1)
                {
                    oFrecuencia.FrecObservada = lista.Count(p => (p >= oFrecuencia.LimInferior)
                    && (p <= oFrecuencia.LimSuperior));

                }
                else
                {
                    oFrecuencia.FrecObservada = lista.Count(p => (p >= oFrecuencia.LimInferior)
                    && (p < oFrecuencia.LimSuperior));
                }
                oFrecuencia.FrecEsperado = Frecuencia;
                oFrecuencia.indice = i + 1;
                var chiTemp = ((oFrecuencia.FrecEsperado - oFrecuencia.FrecObservada) * (oFrecuencia.FrecEsperado - oFrecuencia.FrecObservada)) / oFrecuencia.FrecEsperado;
                oFrecuencia.Chi = Math.Round(chiTemp, 4);
                sumChi = sumChi + oFrecuencia.Chi;
                oFrecuencia.SumChi = Math.Round(sumChi, 4);
                olTablaFrec.Add(oFrecuencia);
                Min = Min + Paso;
            }

            dgwIntervalos.DataSource = olTablaFrec;
            btn_graficar.Enabled = true;
            lbl_sumchi.Text = "La sumatoria de Chi Cuadrado es: " + sumChi;
        }

        private bool validarDatos()
        {
            if (String.IsNullOrEmpty(txt_a.Text) || String.IsNullOrEmpty(txt_cantidad.Text) || String.IsNullOrEmpty(tx_semilla.Text) || String.IsNullOrEmpty(txt_m.Text) || String.IsNullOrEmpty(txt_cantidad.Text) || String.IsNullOrEmpty(txt_c.Text))
            {

                MessageBox.Show("Por favor ingrese todos los valores para el metodo seleccionado");
                return false;
            }
            else
            {

                if (int.Parse(txt_c.Text) < 0 || int.Parse(txt_c.Text) > int.Parse(txt_m.Text))
                {
                    MessageBox.Show("Por favor ingrese un [c] mayor 0 y menor a [m]");
                    return false;
                }

            }

            if (int.Parse(txt_a.Text) < 0)
            {
                MessageBox.Show("Por favor ingrese un [a] mayor a 0");
                return false;
            }
            if (int.Parse(tx_semilla.Text) < 0 && int.Parse(tx_semilla.Text) > int.Parse(txt_m.Text) - 1)
            {
                MessageBox.Show("Por favor ingrese una semilla mayor o igual a 0 y menor o igual a [m-1]");
                return false;
            }
            if (int.Parse(txt_m.Text) < 0)
            {
                MessageBox.Show("Por favor ingrese un [m] mayor 0");
                return false;
            }
            if (int.Parse(txt_cantidad.Text) < 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad mayor 0");
                return false;
            }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            SizeF prueba = new SizeF();
            grafico.Scale(prueba);
            dgwDatos.DataSource = null;
            dgwIntervalos.DataSource = null;
            txt_a.Text = "";
            txt_c.Text = "";
            txt_m.Text = "";
            tx_semilla.Text = "";
            txt_cantidad.Text = "";
            lbl_sumchi.Text = "*";
            txt_intervalos.Text = "";
            grafico.DataSource = null;
            grafico.Series.Clear();
            grafico.Titles.Clear();
            lista_numeros = new List<Numero>();
            btn_graficar.Enabled = false;
            btn_generar.Enabled = true;
        }

        private void btn_graficar_Click(object sender, EventArgs e)
        {
           
            grafico.DataSource = null;
            grafico.Series.Clear();
            grafico.Titles.Clear();
            if (!(dgwDatos.DataSource == null && dgwIntervalos.DataSource == null))
            {
                //grafico.Titles.Add("Histograma");
                grafico.Series.Add("Esperada");
                grafico.Series.Add("Observada");
                grafico.Series["Esperada"].LegendText = "Esperada";
                grafico.Series["Observada"].LegendText = "Observada";

                int[] pointsArray = { };
                grafico.Titles.Add("Histograma");

                foreach (var item in olTablaFrec)
                {
                    var cad1 = item.LimInferior.ToString() + " - " + item.LimSuperior.ToString();
                    grafico.Series["Esperada"].Points.Add(item.FrecEsperado);
                    grafico.Series["Esperada"].Points[item.indice - 1].AxisLabel = cad1;
                    grafico.Series["Observada"].Points.Add(item.FrecObservada);
                    grafico.Series["Observada"].Points[item.indice - 1].AxisLabel = cad1;

                }
                btn_graficar.Enabled = false;
                btn_generar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Las grillas de numeros aleatorios e intervalos no puede estar vacia");
            }
        }
    }
}
