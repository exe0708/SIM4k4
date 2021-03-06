using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            rb_uniforme.Checked = true;
            btnGraficar2.Enabled = false;
            txt_lambda.ReadOnly = true;

        }
        public void cambioDeSeleccion()
        {
            txtMuestra.Text = "";
            if (rb_normal.Checked)
            {
                gb_uniforme.Visible = false;
                gb_exponencial.Visible = false;
                gb_normal.Visible = true;
                txt_desv_est.Text = "";
                txt_media_normal.Text = "";
            
            }
            else if (rb_exponencial.Checked)
            {
                gb_uniforme.Visible = false;
                gb_exponencial.Visible = true;
                gb_normal.Visible = false;
                txt_lambda.Text = "";
                txt_media_exp.Text = "";
            }
            else
            {
                gb_uniforme.Visible = true;
                gb_exponencial.Visible = false;
                gb_normal.Visible = false;
                txt_a.Text = "";
                txt_b.Text = "";
            }

        }


        public void calcularIntervalos(List<double> lista)
        {
            int cant_intervalos = 0;
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
                cant_intervalos = int.Parse(rd_10.Text);
            }
            else if (rd_15.Checked)
            {
                cant_intervalos = int.Parse(rd_15.Text);

            }
            else if (rd_20.Checked)
            {
                cant_intervalos = int.Parse(rd_20.Text);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un intervalo");
            }

            Double Min = Math.Round(olRandom.Min(), 4);
            Double Max = Math.Round(olRandom.Max(), 4);
            Double Paso = Math.Round((Max - Min) / cant_intervalos, 4);
            Double Frecuencia = CantidadAleatorios / cant_intervalos;


            for (int i = 0; i < cant_intervalos; i++)
            {
                Frecuencia oFrecuencia = new Frecuencia();
                oFrecuencia.LimInferior = Math.Round(Min, 4);
                Double Maximo = Math.Round(Min + Paso, 4);
                oFrecuencia.LimSuperior = Maximo;
                if (i == cant_intervalos - 1)
                {
                    oFrecuencia.FrecObservada = olRandom.Count(p => (p >= oFrecuencia.LimInferior)
                    && (p <= oFrecuencia.LimSuperior + 0.1));

                }
                else
                {
                    oFrecuencia.FrecObservada = olRandom.Count(p => (p >= oFrecuencia.LimInferior)
                    && (p < oFrecuencia.LimSuperior));
                }
                oFrecuencia.FrecEsperado = Frecuencia;
                oFrecuencia.indice = i + 1;
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


        }

        // ACA ME TENO QUE PARAR CON EL RANDOM 𝑋 = 𝐴 + 𝑅𝑁𝐷(𝐵 − 𝐴)
        public List<double> calcularNumerosAleatoriosLenguaje()
        {
            double lambda, media, desv_estandar;
            int distribucion = 0;
            int muestra = Int32.Parse(txtMuestra.Text);
            if (rb_uniforme.Checked)
            {
                distribucion = 1;
            }
            else if (rb_exponencial.Checked)
            {
                distribucion = 2;
            }
            else
            {
                distribucion = 3;
            }
            dgwDatos.DataSource = null;
            dgwDatos.Refresh();
            olNumero.Clear();
            numeroAleatoriocs.Clear();
            double nroRandom, nroRandom2;
            int decremento = muestra;
            Random rnd = new Random(0);
            Random rnd2 = new Random(decremento);
            for (int i = 0; i < muestra; i++)
            {
                NumeroAleatoriocs numero = new NumeroAleatoriocs();
                var valor = rnd.NextDouble();
                var valor2 = rnd2.NextDouble();
                nroRandom = valor;
                nroRandom2 = valor2;
                while (nroRandom == 0 || nroRandom == 1)
                {
                    valor = rnd.NextDouble();
                    nroRandom = Math.Round(valor, 4);
                }

                numero.Indice = i;
                numero.NroRandom = valor;
                numero.NroRandom2 = valor2;
                numeroAleatoriocs.Add(numero);
                olNumero.Add(numero.NroRandom);
            }

            switch (distribucion)
            {
                //UNIFORME [A;B]
                case 1:
                    int a = int.Parse(txt_a.Text);
                    int b = int.Parse(txt_b.Text);
                    for (int i = 0; i < olNumero.Count; i++)
                    {
                        double uniforme_ab = 0;
                        uniforme_ab = a + olNumero[i] * (b - a);
                        uniforme_ab = Math.Round(uniforme_ab, 4);
                        numeroAleatoriocs[i].Variable_Aleatoria = uniforme_ab;
                        olNumero[i] = uniforme_ab;
                        numeroAleatoriocs[i].NroRandom = Math.Round(numeroAleatoriocs[i].NroRandom, 4);
                        numeroAleatoriocs[i].NroRandom2 = Math.Round(numeroAleatoriocs[i].NroRandom2, 4);
                    }
                    break;
                //EXPONENCIAL
                case 2:
                    media = double.Parse(txt_media_exp.Text);
                    lambda = 1 / media;
                    for (int i = 0; i < olNumero.Count; i++)
                    {
                        double argumento, exponencial = 0;
                        argumento = 1 - olNumero[i];
                        exponencial = ((-1) / lambda) * Math.Log(argumento);
                        exponencial = Math.Round(exponencial, 4);
                        numeroAleatoriocs[i].Variable_Aleatoria = exponencial;
                        olNumero[i] = exponencial;
                        numeroAleatoriocs[i].NroRandom = Math.Round(numeroAleatoriocs[i].NroRandom, 4);
                        numeroAleatoriocs[i].NroRandom2 = Math.Round(numeroAleatoriocs[i].NroRandom2, 4);
                    }
                    break;
                //NORMAL
                case 3:
                    media = double.Parse(txt_media_normal.Text);
                    desv_estandar = double.Parse(txt_desv_est.Text);
                    int siguiente = 0, primero;
                    for (int i = 0; i < olNumero.Count / 2; i++)
                    {
                        double n1, n2, valor_raiz, valor_ln, valor_argCosSen, cos, sen, mult_cos_raiz, mult_sin_raiz;

                        valor_ln = -2 * Math.Log(numeroAleatoriocs[i].NroRandom);
                        valor_raiz = Math.Sqrt(valor_ln);
                        valor_argCosSen = 2 * Math.PI * numeroAleatoriocs[i].NroRandom2;
                        cos = Math.Round(Math.Cos(valor_argCosSen), 2);
                        sen = Math.Round(Math.Sin(valor_argCosSen), 2);
                        mult_cos_raiz = valor_raiz * cos;
                        mult_sin_raiz = valor_raiz * sen;
                        n1 = Math.Round((mult_cos_raiz * desv_estandar) + media, 4);
                        n2 = Math.Round((mult_sin_raiz * desv_estandar) + media, 4);

                        if (i == 0)
                        {
                            primero = 0;
                            siguiente = primero + 1;
                        }
                        else
                        {
                            primero = siguiente + 1;
                            siguiente = primero + 1;
                        }
                        olNumero[primero] = n1;
                        olNumero[siguiente] = n2;
                        numeroAleatoriocs[primero].Variable_Aleatoria = n1;
                        numeroAleatoriocs[siguiente].Variable_Aleatoria = n2;
                        numeroAleatoriocs[i].NroRandom = Math.Round(numeroAleatoriocs[primero].NroRandom, 4);
                        numeroAleatoriocs[i].NroRandom = Math.Round(numeroAleatoriocs[siguiente].NroRandom, 4);
                        numeroAleatoriocs[i].NroRandom2 = Math.Round(numeroAleatoriocs[primero].NroRandom2, 4);
                        numeroAleatoriocs[i].NroRandom2 = Math.Round(numeroAleatoriocs[siguiente].NroRandom2, 4);

                    }
                    break;
                default:
                    break;
            }

            dgwDatos.DataSource = numeroAleatoriocs;
            dgwDatos.Refresh();
            return olNumero;

        }
        public void calcularFrecuenciasEsperadas()
        {
            
            double distribucion = 0;
            double promedio, frecEsperada;
            double limInf, limSup;
            double N = double.Parse(txtMuestra.Text);
            if (rb_uniforme.Checked)
            {
                distribucion = 1;
            }
            else if (rb_exponencial.Checked)
            {
                distribucion = 2;
            }
            else
            {
                distribucion = 3;
            }
            double lambda, media;
            switch (distribucion)
            {
                case 1:
                    for (int j = 0; j < olTablaFrec.Count; j++)
                    {
                        
                        limInf = olTablaFrec[j].LimInferior;
                        limSup = olTablaFrec[j].LimSuperior;
                        double marca = double.Parse(txt_b.Text) - double.Parse(txt_a.Text);
                        promedio = ((limSup - double.Parse(txt_a.Text)) / marca) - ((limInf - double.Parse(txt_a.Text)) 
                            / marca);

                        promedio = Math.Round(promedio, 4);
                        frecEsperada = promedio * N;
                        frecEsperada = Math.Round(frecEsperada, 4);
                        olTablaFrec[j].FrecEsperado = frecEsperada;
                        dgwIntervalos.DataSource = olTablaFrec;
                        dgwIntervalos.Refresh();
                    }
                    break;
                case 2:
                    media = double.Parse(txt_media_exp.Text);
                    lambda = 1 / media;
                    txt_lambda.Text = lambda.ToString();

                    for (int j = 0; j < olTablaFrec.Count; j++)
                    {
                        limInf = olTablaFrec[j].LimInferior;
                        limSup = olTablaFrec[j].LimSuperior;
                        promedio = (1 - Math.Exp(-lambda * limSup)) - (1 - Math.Exp(-lambda * limInf));
                        frecEsperada = promedio * N;
                        frecEsperada = Math.Round(frecEsperada, 4);
                        olTablaFrec[j].FrecEsperado = frecEsperada;
                        dgwIntervalos.DataSource = olTablaFrec;
                        dgwIntervalos.Refresh();

                    }
                    break;
                case 3:
                    double marc, argumento, desvEst;
                    desvEst = double.Parse(txt_desv_est.Text);
                    media = double.Parse(txt_media_normal.Text);
                    for (int j = 0; j < olTablaFrec.Count; j++)
                    {
                        limInf = olTablaFrec[j].LimInferior;
                        limSup = olTablaFrec[j].LimSuperior;
                        marc = (limInf + limSup) / 2;
                        double ayu = (marc - media) / desvEst;
                        double inter = (Math.Pow(ayu, 2)) * (-0.5);
                        argumento = Math.Exp(inter);
                        double previa = argumento / ((Math.Sqrt(2 * Math.PI)) * desvEst);                   
                        //esta multiplicacion se hace para conocer la probabilidad de cada intervalo
                        //disminuis el margen de error
                        promedio = previa * (limSup - limInf);
                        frecEsperada = promedio * N;
                        frecEsperada = Math.Round(frecEsperada, 4);
                        olTablaFrec[j].FrecEsperado = frecEsperada;
                        dgwIntervalos.DataSource = olTablaFrec;
                        dgwIntervalos.Refresh();

                    }
                    break;

            }


        }



        private void btnGraficar2_Click(object sender, EventArgs e)
        {
            grafico.DataSource = null;
            grafico.Series.Clear();
            grafico.Titles.Clear();
            
            if (!(dgwDatos.DataSource == null && dgwIntervalos.DataSource == null))
            {

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
            btnGraficar2.Enabled = false;
            dgwDatos.DataSource = null;
            dgwIntervalos.DataSource = null;
            txtMuestra.Text = "";

        }

        private void btnLimpiarGrafico_Click(object sender, EventArgs e)
        {
            grafico.DataSource = null;
            grafico.Legends.Clear();
            grafico.Series.Clear();
            grafico.Titles.Clear();

        }
        public Boolean validacion()
        {
            Boolean ret = true;

            if (rb_normal.Checked)
            {
                if (txt_desv_est.Text == "")
                {
                    MessageBox.Show("Debe ingresar una Desviacion Estandar");
                    txt_desv_est.Focus();
                    ret = false;
                }
                else if (txt_media_normal.Text == "")
                {
                    MessageBox.Show("Debe ingresar una Media");
                    txt_media_normal.Focus();
                    ret = false;
                }
            }
            else if (rb_exponencial.Checked)
            {
                if (txt_media_exp.Text != "") 
                {
                    ret = true;
                }
                else
                {
                    MessageBox.Show("Debe ingresar la media");
                    ret = false;
                }
            }
            else
            {
                if (txt_a.Text == "")
                {
                    MessageBox.Show("Debe ingresar un Limite Inferior");
                    txt_a.Focus();
                    ret = false;
                }
                else if (txt_b.Text == "")
                {
                    MessageBox.Show("Debe ingresar un Limite Superior");
                    txt_b.Focus();
                    ret = false;
                }

            }
            return ret;

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                if (txtMuestra.Text == "")
                {
                    MessageBox.Show("Debe Ingresar una Muestra");
                    txtMuestra.Focus();
                    
                }
                else
                {
                    calcularIntervalos(calcularNumerosAleatoriosLenguaje());
                    btnGraficar2.Enabled = true;
                    calcularFrecuenciasEsperadas();
                }
            }
            else
            {
                MessageBox.Show("Complete los campos faltantes antes de continuar");
            }

        }

        private void rb_uniforme_CheckedChanged(object sender, EventArgs e)
        {
            cambioDeSeleccion();
        }

        private void rb_normal_CheckedChanged(object sender, EventArgs e)
        {
            cambioDeSeleccion();
        }


        // Seccion para Prohibir que se ingresen letras en los text box
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

        private void txt_media_exp_TextChanged(object sender, EventArgs e)
        {
            if (txt_media_exp.Text != "") 
            {
                var media = double.Parse(txt_media_exp.Text);
                double lambda = 1 / media;
                lambda = Math.Round(lambda, 4);
                txt_lambda.Text = lambda.ToString();
            }
            else
            {
                txt_lambda.Text = "";
            }
            
        }
    }
}
