using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP_SIM_NUEVO
{
    public partial class Generador : Form
    {
        public MetodoGenerador metodo;

        public List<Numero> lista_numeros;
        public List<Numero> lista_numerosDesdeHasta;
        public int puntero;
        public int pagina;
        public bool usaDesdeHasta;
        public int resto;
        public int desde { get; set; }
        public int hasta { get; set; }

        public Generador()
        {
            usaDesdeHasta = false;
            InitializeComponent();
            btn_anterior.Enabled = false;
            btn_graficar.Enabled = false;
            btn_ultimo.Enabled = false;
            btn_siguiente.Enabled = false;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {

            lista_numeros = new List<Numero>();
            if (validarDatos())
            {
                if (rb_mixto.Checked)
                {
                    metodo = new MetodoGenerador(int.Parse(tx_semilla.Text), int.Parse(txt_a.Text), int.Parse(txt_c.Text), int.Parse(txt_m.Text));
                }
                else
                {
                    metodo = new MetodoGenerador(int.Parse(tx_semilla.Text), int.Parse(txt_a.Text), 0, int.Parse(txt_m.Text));
                }

                generarNumerosAleatorios();
                btn_anterior.Enabled = true;
                btn_graficar.Enabled = true;
                btn_ultimo.Enabled = true;
                btn_siguiente.Enabled = true;
            }

        }

        private void generarNumerosAleatorios()
        {

            desdeHasta();
            var cantidad = int.Parse(txt_cantidad.Text);
            for (int i = 0; i < cantidad; i++)
            {
                Numero aleatorio = new Numero();
                aleatorio.indice = i + 1;
                var residuo = ((metodo.a * metodo.semilla) + metodo.c) % metodo.m;
                aleatorio.numero_aleatorio = Math.Round((double)residuo / metodo.m, 4);
                aleatorio.resto = residuo;
                metodo.semilla = residuo;
                lista_numeros.Add(aleatorio);
            }
            pagina = 1;
            puntero = 0;
            resto = cantidad - 20;
            lbl_pagina.Text = "Pagina: " + pagina.ToString();
            if (usaDesdeHasta)
            {
                lista_numerosDesdeHasta = new List<Numero>();
                lista_numerosDesdeHasta = lista_numeros.GetRange(desde - 1, hasta);
                resto = lista_numerosDesdeHasta.Count - 20;
                if (hasta > 20)
                {
                    puntero = puntero + 20;
                    var lista_parcial = lista_numerosDesdeHasta.GetRange(0, 20);
                    dgv_numeros.DataSource = lista_parcial;
                }
                else
                {
                    puntero = puntero + hasta;
                    var lista_parcial = lista_numerosDesdeHasta.GetRange(0, hasta);
                    dgv_numeros.DataSource = lista_parcial;
                }
            }
            else
            {
                if (cantidad > 20)
                {
                    puntero = puntero + 20;
                    var lista_parcial = lista_numeros.GetRange(0, 20);
                    dgv_numeros.DataSource = lista_parcial;
                }
                else
                {
                    puntero = puntero + cantidad;
                    var lista_parcial = lista_numeros.GetRange(0, cantidad);
                    dgv_numeros.DataSource = lista_parcial;
                }
            }

        }
        private void desdeHasta()
        {
            usaDesdeHasta = false;
            if (!String.IsNullOrEmpty(txt_desde.Text) && !String.IsNullOrEmpty(txt_hasta.Text))
            {
                desde = int.Parse(txt_desde.Text);
                hasta = int.Parse(txt_hasta.Text);
                var cantidad = int.Parse(txt_cantidad.Text);

                if (desde < 0 || hasta < 0)
                {
                    MessageBox.Show("El desde y hasta tienen que ser valores mayores a 0");
                }
                if (desde > cantidad || hasta > cantidad)
                {
                    MessageBox.Show("Ingrese un desde y hasta que corresponda con la cantidad solicitada");
                }
                else
                {
                    usaDesdeHasta = true;
                }
            }

        }
        // Metodo para la pagina Siguiente
        private void btn_siguiente_Click(object sender, EventArgs e)
        {

            if (resto > 20)
            {
                puntero = puntero + 20;
                pagina++;
                cargarTabla(puntero);
            }
            else
            {
                if (resto < 20 && resto > 0)
                {
                    //puntero = puntero + resto;
                    pagina++;
                    cargarTabla(puntero);
                }
                else
                {
                    MessageBox.Show("No hay pagina siguiente");
                }
            }
        }

        // Metodo para pagina Anterior
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (puntero > 0)
            {
                puntero = puntero - 20;
                pagina--;
                if (puntero < 0)
                {
                    puntero = 0;
                    pagina = 1;
                }
                cargarTabla(puntero);
            }
            else
            {
                MessageBox.Show("No hay pagina anterior");
            }
        }
        // Metodo Para ver la ultima Pagina
        private void btn_ultimo_Click(object sender, EventArgs e)
        {

            if (usaDesdeHasta)
            {
                puntero = lista_numerosDesdeHasta.Count - 20;
                pagina = lista_numerosDesdeHasta.Count / 20;

            }
            else
            {
                puntero = lista_numeros.Count - 20;
                pagina = lista_numeros.Count / 20;
            }
            if (puntero < 0)
            {
                puntero = 0;
                pagina = 1;
            }
            cargarTabla(puntero);
            resto = 0;
        }
        // Metodo para cargar la tabla dependiendo si usa Desde y Hasata
        private void cargarTabla(int puntero)
        {

            List<Numero> lista_parcial = new List<Numero>();
            if (usaDesdeHasta)
            {
                resto = lista_numerosDesdeHasta.Count - puntero;
                if (lista_numerosDesdeHasta.Count > 20 && resto > 20)
                {
                    lista_parcial = lista_numerosDesdeHasta.GetRange(puntero, 20);

                }
                else
                {
                    lista_parcial = lista_numerosDesdeHasta.GetRange(puntero, resto);
                    resto = lista_numerosDesdeHasta.Count;

                }

            }
            else
            {
                resto = lista_numeros.Count - puntero;
                if (lista_numeros.Count > 20 && resto > 20)
                {
                    lista_parcial = lista_numeros.GetRange(puntero, 20);

                }
                else
                {
                    lista_parcial = lista_numeros.GetRange(puntero, resto);
                    resto = lista_numeros.Count;
                }
            }

            dgv_numeros.DataSource = lista_parcial;
            lbl_pagina.Text = "Pagina: " + pagina.ToString();
        }
        // Metodo para limpiar formulario
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_a.Text = "";
            txt_c.Text = "";
            txt_m.Text = "";
            tx_semilla.Text = "";
            txt_cantidad.Text = "";
            txt_desde.Text = "";
            txt_hasta.Text = "";
            rb_mixto.Checked = true;
            lista_numeros = new List<Numero>();
            puntero = 0;
            pagina = 0;
            resto = 0;
            usaDesdeHasta = false;
            dgv_numeros.DataSource = null;
            btn_anterior.Enabled = false;
            btn_graficar.Enabled = false;
            btn_ultimo.Enabled = false;
            btn_siguiente.Enabled = false;
        }
        private bool validarDatos()
        {
            if (String.IsNullOrEmpty(txt_a.Text) || String.IsNullOrEmpty(txt_cantidad.Text) || String.IsNullOrEmpty(tx_semilla.Text) || String.IsNullOrEmpty(txt_m.Text) || String.IsNullOrEmpty(txt_cantidad.Text))
            {

                MessageBox.Show("Por favor ingrese todos los valores para el metodo seleccionado");
                return false;
            }
            else
            {
                if (rb_mixto.Checked && String.IsNullOrEmpty(txt_c.Text))
                {
                    MessageBox.Show("Por favor ingrese todos los valores para el metodo seleccionado");
                    if (int.Parse(txt_c.Text) < 0 || int.Parse(txt_c.Text) > int.Parse(txt_m.Text))
                    {
                        MessageBox.Show("Por favor ingrese un [c] mayor 0 y menor a [m]");
                        return false;
                    }
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

        private void rb_mixto_CheckedChanged(object sender, EventArgs e)
        {
            if (!rb_mixto.Checked)
            {
                txt_c.Enabled = false;
                txt_c.Text = "";
            }
            else
            {
                txt_c.Enabled = true;
                txt_c.Text = "";
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void btn_graficar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
