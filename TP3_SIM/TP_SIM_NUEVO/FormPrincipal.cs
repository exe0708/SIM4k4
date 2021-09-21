using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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
            rb_uniforme.Checked = true;
            btnGraficar2.Enabled = false;
            txt_lambda.ReadOnly = true;
            lb_chi_cuadrado.Visible = false;
        }

        public void cambioDeSeleccion()
        {
            txtMuestra.Text = "";
            //Seleccion: NORMAL
            if (rb_normal.Checked)
            {
                gb_uniforme.Visible = false;
                gb_exponencial.Visible = false;
                gb_normal.Visible = true;
                gb_poisson.Visible = false;
                txt_desv_est.Text = "";
                txt_media_normal.Text = "";

            }
            //EXPONCIAL
            else if (rb_exponencial.Checked)
            {
                gb_uniforme.Visible = false;
                gb_exponencial.Visible = true;
                gb_normal.Visible = false;
                gb_poisson.Visible = false;
                txt_lambda.Text = "";
                txt_media_exp.Text = "";
            }
            //UNIFORME
            else if (rb_uniforme.Checked)
            {
                gb_uniforme.Visible = true;
                gb_exponencial.Visible = false;
                gb_normal.Visible = false;
                gb_poisson.Visible = false;
                txt_a.Text = "";
                txt_b.Text = "";
            }
            //POISSON
            else
            {
                gb_uniforme.Visible = false;
                gb_exponencial.Visible = false;
                gb_normal.Visible = false;
                gb_poisson.Visible = true;
                txt_lambda_poisson.Text = "";
            }

        }

        //Paso 1: Calculo numeros aletorios.
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
            else if (rb_normal.Checked)
            {
                distribucion = 3;
            }
            else
            {
                distribucion = 4;
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
                //POISSON
                case 4:
                    int x = 0;
                    double h = 0;
                    int n = 0;
                    double p = 1;
                    double lambda2 = double.Parse(txt_lambda_poisson.Text);
                    
                    for (int i = 0; i < olNumero.Count; i++)
                    {
                        olNumero[i] = calcularPoison2(n,p);
                        //olNumero[i] = calcularPoison(x, h);
                        //System.Threading.Thread.Sleep(Interval);
                        numeroAleatoriocs[i].Variable_Aleatoria = olNumero[i];
                        numeroAleatoriocs[i].NroRandom = Math.Round(numeroAleatoriocs[i].NroRandom, 4);
                        numeroAleatoriocs[i].NroRandom2 = Math.Round(numeroAleatoriocs[i].NroRandom2, 4);
                        n = 0;
                        p = 1;
                        h = 0;
                        x = 0;
                    }
                    

                    break;

                default:
                    break;
            }

            dgwDatos.DataSource = numeroAleatoriocs;
            dgwDatos.Refresh();
            return olNumero;

        }

        int calcularPoison2(int n, double p)
        {
            
            bool band = true;
            var lambda = double.Parse(txt_lambda_poisson.Text);
            double comparador = Math.Exp(-lambda);
            do
            {
                Random random2 = new Random();
                Random random = new Random(random2.Next());
                var numerorandom = random.NextDouble();
                while (numerorandom == 0)
                { numerorandom = random.NextDouble(); }
                if (band)
                {
                    
                    p = p * numerorandom;
                    band = false;
                }
                else
                {
                    n = n + 1;
                    p = p * numerorandom;
                }

            }
            while (p > comparador);
            return n;
        }

            int calcularPoison(int x, double h)
            {
                var lambda = double.Parse(txt_lambda_poisson.Text);
                while (h < 1)
                {

                    Random random2 = new Random();
                    Random random = new Random(random2.Next());
                    var numerorandom = random.NextDouble();
                    var argumento = 1 - numerorandom;
                    var exponencial = -(1 / lambda) * Math.Log(argumento);
                    h = h + exponencial;
                    x = x + 1;

                }

                return x;
            }

            //Paso 2: Calculo los intervalos con la lista devuelta por el metodo del paso 1.
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
                if (int.Parse(txt_intervalos.Text) > 0)
                {
                    cant_intervalos = int.Parse(txt_intervalos.Text);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un intervalo");
                }

                Double Min = Math.Round(olRandom.Min(), 2);
                Double Max = Math.Round(olRandom.Max(), 2);
                Double Paso = Math.Round((Max - Min) / cant_intervalos, 2);
                Double Frecuencia = CantidadAleatorios / cant_intervalos;
                Double sumChi = 0;


                for (int i = 0; i < cant_intervalos; i++)
                {
                    Frecuencia oFrecuencia = new Frecuencia();
                    oFrecuencia.LimInferior = Math.Round(Min, 2);
                    Double Maximo = Math.Round(Min + Paso, 2);
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
                    var chiTemp = ((oFrecuencia.FrecEsperado - oFrecuencia.FrecObservada) * (oFrecuencia.FrecEsperado - oFrecuencia.FrecObservada)) / oFrecuencia.FrecEsperado;
                    oFrecuencia.Chi = Math.Round(chiTemp, 2);
                    sumChi = sumChi + oFrecuencia.Chi;
                    oFrecuencia.SumChi = Math.Round(sumChi, 2);
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
                lb_chi_cuadrado.Text += "El valor de chi cuadrado es: " + sumChi;

            }

            //Paso 3: Calculo frecuencias esperadas
            public void calcularFrecuenciasEsperadas()
            {

                double distribucion = 0;
                double promedio, frecEsperada;
                double limInf, limSup;
                double N = double.Parse(txtMuestra.Text);

                //Tomo los valores del radio button para luego tomarlos en un case
                if (rb_uniforme.Checked)
                {
                    distribucion = 1;
                }
                else if (rb_exponencial.Checked)
                {
                    distribucion = 2;
                }
                else if (rb_normal.Checked)
                {
                    distribucion = 3;
                }
                else
                {
                    distribucion = 4;
                }

                double lambda, media;
                switch (distribucion)
                {
                    //UNIFORME
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
                            //Cargo los datos con la frecuencia.
                            dgwIntervalos.DataSource = olTablaFrec;
                            dgwIntervalos.Refresh();
                        }
                        break;
                    //EXPONENCIAL
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
                    //NORMAL
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
                    case 4:

                        lambda = double.Parse(txt_lambda_poisson.Text);
                        /*for (int j = 0; j < olTablaFrec.Count; j++)
                        {
                            double poison;
                            int factorial = 1;
                            /*for (int k = 1; k <= olNumero[j]; k++)
                            {
                                factorial = factorial * j;
                            }
                            //int factorial = Enumerable.Range(1, x).Aggregate(1, (p, item) => p * item);
                            poison = Math.Exp(-lambda) * Math.Pow(lambda, olNumero[j]) / factorial;
                            frecEsperada = olNumero[j] * N;
                            frecEsperada = Math.Round(frecEsperada, 4);
                            olTablaFrec[j].FrecEsperado = frecEsperada;
                            dgwIntervalos.DataSource = olTablaFrec;
                            dgwIntervalos.Refresh();

                        }*/
                        break;
                }


            }


            // Grafico
            private void btnGraficar2_Click(object sender, EventArgs e)
            {
                //Inicializar la grilla.
                grafico.DataSource = null;
                grafico.Series.Clear();
                grafico.Titles.Clear();

                if (!(dgwDatos.DataSource == null && dgwIntervalos.DataSource == null))
                {
                    //Argego columnas y le seteo los nombres.
                    grafico.Series.Add("Esperada");
                    grafico.Series.Add("Observada");
                    grafico.Series["Esperada"].LegendText = "Esperada";
                    grafico.Series["Observada"].LegendText = "Observada";

                    int[] pointsArray = { };
                    grafico.Titles.Add("Histograma");

                    foreach (var item in olTablaFrecGrafico)
                    {
                        //Cargo datos de las frecuencias en el grafico.
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
                //Limpio los valores de la tabla.

                btnGraficar2.Enabled = false;
                SizeF prueba = new SizeF();
                grafico.Scale(prueba);
                dgwDatos.DataSource = null;
                dgwIntervalos.DataSource = null;

                txtMuestra.Text = "";

            }

            private void btnLimpiarGrafico_Click(object sender, EventArgs e)
            {
                //Limpio el grafico.
                SizeF prueba = new SizeF();
                grafico.Scale(prueba);
                dgwDatos.DataSource = null;
                dgwIntervalos.DataSource = null;

            }
            public Boolean validacion()
            {
                Boolean ret = true;

                //Realizo validacion de que esten seleccionados/ingresados los valores
                //Validacion para Normal.
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
                //Validacion para Exponencial
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
                //Uniforme
                else if (rb_uniforme.Checked)
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
                else
                {

                double lambda = double.Parse(txt_lambda_poisson.Text);    
                if (txt_lambda_poisson.Text == "" && lambda > 0)
                    {
                        MessageBox.Show("Ingrese un lambda con un valos mayor a 0");
                        txt_lambda_poisson.Focus();
                        ret = false;
                    }
                }
                return ret;

            }

            private void btnGenerar_Click(object sender, EventArgs e)
            {
                lb_chi_cuadrado.Visible = true;
                lb_chi_cuadrado.Text = "";
                //Llamo al metodo que valida que esten ingresado todos los valores.
                if (validacion())
                {
                    //Si no ingreso ninguna muestra se le solicita que cargue una.
                    if (txtMuestra.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar una Muestra");
                        txtMuestra.Focus();

                    }
                    else
                    {
                        //Si todos los datos estan cargados, llamo al metodo que calcula los intervalos.

                        calcularIntervalos(calcularNumerosAleatoriosLenguaje());
                        btnGraficar2.Enabled = true;
                        //Una vez calculado los intervalos y numeros aleatorios calculo las frecuentcias.
                        calcularFrecuenciasEsperadas();
                        //calucularChiCuadrado();
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
                if (media > 0)
                {
                    double lambda = 1 / media;
                    lambda = Math.Round(lambda, 4);
                    txt_lambda.Text = lambda.ToString();
                }
                else
                    MessageBox.Show("La media no puede ser 0");
            }
                else
                {
                    txt_lambda.Text = "";
                }

            }
        }
    }
