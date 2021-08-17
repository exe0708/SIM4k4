using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TP_SIM_NUEVO
{
    public partial class FormPrincipal : Form
    {
        List<Frecuencia> olTablaFrec = new List<Frecuencia>();
        List<double> lista_numeros = new List<double>();
        List<Numero> lista_aleatorios = new List<Numero>();
        bool flag = true;
        public FormPrincipal()
        {
            InitializeComponent();
            rd_10.Checked = true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lista_numeros = new List<double>();
            lista_aleatorios = new List<Numero>();

            if (validarDatos())
            {
                calcularIntervalos(calcularNumerosAleatoriosLenguaje());
            }
        }


        public void calcularIntervalos(List<double> lista)
        {
            olTablaFrec = new List<Frecuencia>();
            lista = lista.GetRange(0, lista.Count);
            Double Paso = 0;
            var intervalo = 0;
            Int32 CantidadAleatorios = Int32.Parse(txt_muestra.Text);
            if (rd_10.Checked)
            { intervalo = 10; }
            else if (rd_15.Checked)
            { intervalo = 15; }
            else if (rd_20.Checked)
            { intervalo = 20; }

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
            btnGraficar2.Enabled = true;
            lblSumChi.Text = "La sumatoria de Chi Cuadrado es: " + sumChi;
        }



        public List<double> calcularNumerosAleatoriosLenguaje()
        {
            double nroRandom;
            for (int i = 0; i < Int32.Parse(txt_muestra.Text); i++)
            {
                Numero numero = new Numero();
                Random rnd = new Random(i);
                var valor = rnd.NextDouble();
                nroRandom = Math.Round(valor, 4);
                while (nroRandom >= 1)
                {
                    nroRandom = rnd.NextDouble();
                    nroRandom = Math.Round(nroRandom, 4);
                }
                numero.indice = i + 1;
                numero.numero_aleatorio = nroRandom;
                lista_aleatorios.Add(numero);
                lista_numeros.Add(nroRandom);

            }
            dgwDatos.DataSource = lista_aleatorios;
            return lista_numeros;
        }

        public bool validarDatos()
        {
            if (String.IsNullOrEmpty(txt_muestra.Text))
            {
                MessageBox.Show("Debe ingresar una cantidad");
                return false;
            }
            else
            {
                if (Int32.Parse(txt_muestra.Text) < 0 || Int32.Parse(txt_muestra.Text) > 500000)
                {
                    MessageBox.Show("La muestra debe ser mayor a cero y menor a 500000");
                    return false;
                }
            }

            return true;
        }

        private void txt_muestra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnGraficar2_Click(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Las grillas de numeros aleatorios e intervalos no puede estar vacia");
            }

        }

        private void btnLimpiarGrafico_Click(object sender, EventArgs e)
        {
            grafico.DataSource = null;
            grafico.Series.Clear();
            grafico.Titles.Clear();
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {

        }
    }
}
