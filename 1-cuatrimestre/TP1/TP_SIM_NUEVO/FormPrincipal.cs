using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP_SIM_NUEVO
{
    public partial class FormPrincipal : Form
    {
        List<Frecuencia> olTablaFrec = new List<Frecuencia>();
        List<Frecuencia> olTablaFrecGrafico = new List<Frecuencia>();
        List<double> olNumero = new List<double>();
        List<NumeroAleatoriocs> numeroAleatoriocs = new List<NumeroAleatoriocs>();
        bool flag = true;
        public FormPrincipal()
        {
            InitializeComponent();
            rd_10.Checked = true;
            DesHabilitarBotonesNuevos();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!cbAleatorio.Checked)
            {
                if (validarDatos())
                {
                    calcularIntervalos(CalcularNumAleatorios());
                    HabilitarBotonNuevoNormal();
                }
                else
                {

                }
            }
            else
            {
                if (!String.IsNullOrEmpty(txtMuestra.Text))
                {
                    if (!(Int32.Parse(txtMuestra.Text) > 1000000 || Int32.Parse(txtMuestra.Text) <= 0))
                    {
                        calcularIntervalos(calcularNumerosAleatoriosLenguaje());
                        HabilitarBotonNuevoAleatorio();
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un tamaño de muestra mayor a cero y menor a un millon");
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar la muestra para poder aplicar los metodos");
                }

            }

        }

        public void calcularIntervalos(List<double> lista)
        {
            List<Double> olRandom = new List<double>();
            olRandom = lista.ToList();
            olRandom.Sort();
            Int32 CantidadAleatorios = Int32.Parse(txtMuestra.Text);
            dgwIntervalos.DataSource = null;
            dgwIntervalos.Refresh();
            dgwIntervalos.Rows.Clear();
            olTablaFrec.Clear();
            if (rd_10.Checked == true)
            {
                Double Min = olRandom.Min();
                Double Max = olRandom.Max();
                Double Paso = (Max - Min) / 10;
                Double Frecuencia = CantidadAleatorios / 10;
                Double sumChi = 0;

                for (int i = 0; i < 10; i++)
                {
                    Frecuencia oFrecuencia = new Frecuencia();
                    oFrecuencia.LimInferior = Math.Round(Min, 4);
                    Double Maximo = Min + Paso;
                    oFrecuencia.LimSuperior = Math.Round(Maximo, 4);
                    if (i == 9)
                    {
                        oFrecuencia.FrecObservada = olRandom.Count(p => (p >= oFrecuencia.LimInferior)
                        && (p <= oFrecuencia.LimSuperior));

                    }
                    else
                    {
                        oFrecuencia.FrecObservada = olRandom.Count(p => (p >= oFrecuencia.LimInferior)
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

                if (flag)
                {
                    flag = false;
                }
                else
                {

                    dgwIntervalos.DataSource = null;
                    dgwIntervalos.Rows.Clear();
                }

                dgwIntervalos.DataSource = olTablaFrec;
                olTablaFrecGrafico = olTablaFrec;
                dgwIntervalos.Refresh();
                btnGraficar2.Enabled = true;
                lblSumChi.Text = "La sumatoria de Chi Cuadrado es: " + sumChi;
            }
            else if (rd_15.Checked == true)
            {
                Double Min = olRandom.Min();
                Double Max = olRandom.Max();
                Double Paso = (Max - Min) / 15;
                Double Frecuencia = CantidadAleatorios / 15;
                Double sumChi = 0;


                for (int i = 0; i < 15; i++)
                {
                    Frecuencia oFrecuencia = new Frecuencia();
                    oFrecuencia.LimInferior = Math.Round(Min, 4);
                    Double Maximo = Min + Paso;
                    oFrecuencia.LimSuperior = Math.Round(Maximo, 4);

                    if (i == 14)
                    {
                        oFrecuencia.FrecObservada = olRandom.Count(p => (p >= oFrecuencia.LimInferior)
                        && (p <= oFrecuencia.LimSuperior));
                    }
                    else
                    {
                        oFrecuencia.FrecObservada = olRandom.Count(p => (p >= oFrecuencia.LimInferior)
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

                if (flag)
                {
                    flag = false;
                }
                else
                {

                    dgwIntervalos.DataSource = null;
                    dgwIntervalos.Rows.Clear();
                }

                dgwIntervalos.DataSource = olTablaFrec;
                olTablaFrecGrafico = olTablaFrec;
                dgwIntervalos.Refresh();
                btnGraficar2.Enabled = true;
                lblSumChi.Text = "La sumatoria de Chi Cuadrado es: " + sumChi;
            }
            else if (rd_20.Checked == true)
            {
                Double Min = olRandom.Min();
                Double Max = olRandom.Max();
                Double Paso = (Max - Min) / 20;
                Double Frecuencia = CantidadAleatorios / 20;
                Double sumChi = 0;

                for (int i = 0; i < 20; i++)
                {
                    Frecuencia oFrecuencia = new Frecuencia();
                    oFrecuencia.LimInferior = Math.Round(Min, 4);
                    Double Maximo = Min + Paso;
                    oFrecuencia.LimSuperior = Math.Round(Maximo, 4);
                    if (i == 19)
                    {
                        oFrecuencia.FrecObservada = olRandom.Count(p => (p >= oFrecuencia.LimInferior)
                         && (p <= oFrecuencia.LimSuperior));
                    }
                    else
                    {
                        oFrecuencia.FrecObservada = olRandom.Count(p => (p >= oFrecuencia.LimInferior)
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

                if (flag)
                {
                    flag = false;
                }
                else
                {

                    dgwIntervalos.DataSource = null;
                    dgwIntervalos.Rows.Clear();
                }

                dgwIntervalos.DataSource = olTablaFrec;
                olTablaFrecGrafico = olTablaFrec;
                dgwIntervalos.Refresh();
                btnGraficar2.Enabled = true;
                lblSumChi.Text = "La sumatoria de Chi Cuadrado es: " + sumChi;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un intervalo");
            }


        }



        public List<double> calcularNumerosAleatoriosLenguaje()
        {
            dgwDatos.DataSource = null;
            dgwDatos.Refresh();
            olNumero.Clear();
            numeroAleatoriocs.Clear();
            double nroRandom;


            for (int i = 1; i < Int32.Parse(txtMuestra.Text) + 1; i++)
            {
                NumeroAleatoriocs numero = new NumeroAleatoriocs();
                Random rnd = new Random(i);
                var valor = rnd.NextDouble();
                //while (olNumero.Contains(valor)) 
                //{
                //    valor = rnd.NextDouble();

                //}
                nroRandom = Math.Round(valor, 4);
                //int var = (int)valor;
                while (nroRandom >= 1)
                {
                    nroRandom = rnd.NextDouble();
                    nroRandom = Math.Round(nroRandom, 4);
                }
                numero.Indice = i;
                numero.Raiz = 0;
                numero.NroRandom = nroRandom;
                numeroAleatoriocs.Add(numero);
                olNumero.Add(nroRandom);

            }
            //olNumero.Sort();
            dgwDatos.DataSource = numeroAleatoriocs;
            dgwDatos.Refresh();
            return olNumero;

        }

        private List<double> CalcularNumAleatorios()
        {
            int r, x, a, c, m, res;
            double nroRandom;
            dgwDatos.DataSource = null;
            dgwDatos.Refresh();
            olNumero.Clear();
            x = Int32.Parse(txtSemilla.Text);
            c = Int32.Parse(txtC.Text);


            for (int i = 1; i < Int32.Parse(txtMuestra.Text) + 1; i++)
            {
                NumeroAleatoriocs numero = new NumeroAleatoriocs();
                if (cbLineal.Checked)
                {
                    a = 1 + 4 * Int32.Parse(txtK.Text);
                    m = (int)Math.Pow(2, Int32.Parse(txtG.Text));
                    res = (a * x + c);
                    r = res % m;

                }
                else
                {
                    a = 5 + 8 * Int32.Parse(txtK.Text);
                    m = (int)Math.Pow(2, Int32.Parse(txtG.Text));
                    res = (a * x);
                    r = res % m;
                }
                //Genero numeros pseudo aleatorios entre 0 y 1
                x = r;
                nroRandom = (double)r / m;
                nroRandom = Math.Round(nroRandom, 4);
                numero.Indice = i;
                numero.Raiz = x;
                numero.NroRandom = nroRandom;

                numeroAleatoriocs.Add(numero);
                olNumero.Add(nroRandom);

            }
            olNumero.Sort();
            dgwDatos.DataSource = numeroAleatoriocs;
            dgwDatos.Refresh();
            return olNumero;
        }

        public bool validarDatos()
        {
            bool Result;
            try
            {
                if (String.IsNullOrEmpty(txtSemilla.Text) || String.IsNullOrEmpty(txtK.Text)
                    || String.IsNullOrEmpty(txtC.Text) || String.IsNullOrEmpty(txtG.Text)
                    || String.IsNullOrEmpty(txtMuestra.Text))
                {
                    MessageBox.Show("Debe ingresar la raiz, las constantes, y la muestra para poder aplicar los metodos");
                    Result = false;
                }
                else
                {
                    if (Int32.Parse(txtMuestra.Text) < 0 || Int32.Parse(txtMuestra.Text) > 1000000)
                    {
                        MessageBox.Show("La muestra debe ser mayor a cero y menor a un millón");
                        Result = false;
                    }
                    Result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        private void cbLineal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLineal.Checked == true)
            {
                cbAleatorio.Checked = false;
                cbMultiplicativo.Checked = false;
                txtK.Enabled = true;
                txtC.Enabled = true;
                txtG.Enabled = true;
                txtSemilla.Enabled = true;
                
            }
        }

        public void HabilitarBotonNuevoNormal() 
        {
            btnNuevo.Enabled = true;
            btnNuevo.Visible = true;
            btnNuevoAleatorio.Visible = false;
            btnNuevoAleatorio.Enabled = false;
        }
        public void HabilitarBotonNuevoAleatorio()
        {
            btnNuevo.Enabled = false;
            btnNuevo.Visible = false;
            btnNuevoAleatorio.Visible = true;
            btnNuevoAleatorio.Enabled = true;
        }
        public void DesHabilitarBotonesNuevos()
        {
            btnNuevo.Enabled = false;
            btnNuevo.Visible = false;
            btnNuevoAleatorio.Visible = false;
            btnNuevoAleatorio.Enabled = false;
        }


        private void cbMultiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMultiplicativo.Checked == true)
            {
                cbLineal.Checked = false;
                cbAleatorio.Checked = false;
                txtK.Enabled = true;
                txtC.Enabled = true;
                txtG.Enabled = true;
                txtSemilla.Enabled = true;
                
            }
        }

        private void cbAleatorio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAleatorio.Checked == true)
            {
                cbLineal.Checked = false;
                cbMultiplicativo.Checked = false;
                txtK.Enabled = false;
                txtC.Enabled = false;
                txtG.Enabled = false;
                txtSemilla.Enabled = false;
                
            }
        }

        private void txtSemilla_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtK_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtG_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMuestra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCantNro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                int r, x, a, c, m, res;
                double nroRandom;
                x = numeroAleatoriocs[olNumero.Count - 1].Raiz;
                c = Int32.Parse(txtC.Text);

                if (cbLineal.Checked)
                {
                    a = 1 + 4 * Int32.Parse(txtK.Text);
                    m = (int)Math.Pow(2, Int32.Parse(txtG.Text));
                    res = (a * x + c);
                    r = res % m;

                }
                else
                {
                    a = 3 + 8 * Int32.Parse(txtK.Text);
                    m = (int)Math.Pow(2, Int32.Parse(txtG.Text));
                    res = (a * x);
                    r = res % m;
                }
                //Genero numeros pseudo aleatorios entre 0 y 1
                x = r;
                nroRandom = (double)r / (m - 1);
                nroRandom = Math.Round(nroRandom, 4);
                NumeroAleatoriocs numero = new NumeroAleatoriocs();
                numero.Indice = olNumero.Count + 1;
                numero.Raiz = x;
                numero.NroRandom = nroRandom;
                numeroAleatoriocs.Add(numero);
                olNumero.Add(nroRandom);
                dgwDatos.DataSource = null;
                dgwDatos.Rows.Clear();
                dgwDatos.DataSource = numeroAleatoriocs;
                dgwDatos.Refresh();
                calcularIntervalos(olNumero);

            }

        }


        public bool Validacion()
        {
            bool resultado = false;
            try
            {
                if (String.IsNullOrEmpty(txtMuestra.Text))
                {
                    MessageBox.Show("Debe ingresar la cantidad de numeros a generar");
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

                foreach (var item in olTablaFrecGrafico)
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

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            dgwDatos.DataSource = null;
            dgwIntervalos.DataSource = null;
            txtSemilla.Text = "";
            txtK.Text = "";
            txtC.Text = "";
            txtG.Text = "";
            txtMuestra.Text = "";
            DesHabilitarBotonesNuevos();
        }

        private void btnLimpiarGrafico_Click(object sender, EventArgs e)
        {
            grafico.DataSource = null;
            grafico.Series.Clear();
            grafico.Titles.Clear();



        }


        private void btnNuevoAleatorio_Click(object sender, EventArgs e)
        {
            double nroRandom;

            NumeroAleatoriocs numero = new NumeroAleatoriocs();
            Random rnd = new Random(olNumero.Count + 1);
            var valor = rnd.NextDouble();
            //while (olNumero.Contains(valor)) 
            //{
            //    valor = rnd.NextDouble();

            //}
            nroRandom = Math.Round(valor, 4);
            //int var = (int)valor;
            while (nroRandom >= 1)
            {
                nroRandom = rnd.NextDouble();
                nroRandom = Math.Round(nroRandom, 4);
            }
            numero.Indice = olNumero.Count + 1;
            numero.Raiz = 0;
            numero.NroRandom = nroRandom;
            numeroAleatoriocs.Add(numero);
            olNumero.Add(nroRandom);
            dgwDatos.DataSource = null;
            dgwDatos.Rows.Clear();
            dgwDatos.DataSource = numeroAleatoriocs;
            dgwDatos.Refresh();
            calcularIntervalos(olNumero);

        }
    }
}
