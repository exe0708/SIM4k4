using LinqStatistics;
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
    public partial class frmTP : Form
    {
        List<eNumero> olNumero = new List<eNumero>();
        

        public frmTP()
        {
            InitializeComponent();       
        }

        private void BtGenerar_Click(object sender, EventArgs e)
        {
            if (!cb_lenguaje.Checked)
            {
                if (ValidarDatos()) 
                {
                    CalcularNumAleatorios();
                }
            }
            else
            {
                calcularNumerosAleatoriosLenguaje();
            }
        }
        private bool ValidarDatos()
        {
            bool Result = false;
            try
            {
                if (String.IsNullOrEmpty(txRaiz.Text) || String.IsNullOrEmpty(txA.Text) || String.IsNullOrEmpty(txC.Text) || String.IsNullOrEmpty(txM.Text))
                {
                    MessageBox.Show("Debe ingresar la raiz y las constantes para poder aplicar los metodos");
                }
                else
                {
                    if (Int32.Parse(txM.Text) == 0)
                    {
                        MessageBox.Show("El modulo debe ser un numero superiro a 0");
                    }
                    else
                    {
                        if (chLineal.Checked || chMultiplicativo.Checked)
                        {
                            Result = true;
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar alguno de los metodos");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return Result;
        }


        private void CalcularNumAleatorios()
        {
            oGrilla.DataSource = null;
            oGrilla.Refresh();
            olNumero.Clear();

            int r, x, a, c, m;
            x = Int32.Parse(txRaiz.Text);
            a = Int32.Parse(txA.Text);
            c = Int32.Parse(txC.Text);
            m = Int32.Parse(txM.Text);
            double nroRandom = 0;
            for (int i = 1; i < 1000001; i++)
            {
                if (chLineal.Checked)
                    r = (a * x + c) % m;
                else
                    r = (a * x) % m;
                

                    nroRandom = Convert.ToDouble(x) / Convert.ToDouble(m);
                eNumero oNumero = new eNumero();
                oNumero.Nro = i;
                oNumero.Raiz = x;
                oNumero.NroRandom = Math.Round(nroRandom, 4);
                olNumero.Add(oNumero);
                x = r;
            }
            oGrilla.DataSource = olNumero;
            oGrilla.Refresh();
        }

        public void calcularNumerosAleatoriosLenguaje() 
        {
            oGrilla.DataSource = null;
            oGrilla.Refresh();
            olNumero.Clear();
            double nroRandom;

            for (int i = 1; i < 1000001; i++)
            {
                Random rnd = new Random();
                nroRandom = rnd.NextDouble();
                eNumero oNumero = new eNumero();
                oNumero.Nro = i;
                oNumero.NroRandom = Math.Round(nroRandom, 4);
                olNumero.Add(oNumero);                
            }
            oGrilla.DataSource = olNumero;
            oGrilla.Refresh();
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

        private void TxA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxM_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cb_lenguaje_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_lenguaje.Checked == true) 
            {
                chLineal.Checked = false;
                chMultiplicativo.Checked = false;
                txA.Enabled = false;
                txC.Enabled = false;
                txM.Enabled = false;
                txRaiz.Enabled = false;
            }
        }

        private void ChMultiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            if (chMultiplicativo.Checked == true)
            {
                chLineal.Checked = false;
                cb_lenguaje.Checked = false;
                txA.Enabled = true;
                txC.Enabled = true;
                txM.Enabled = true;
                txRaiz.Enabled = true;
            }
        }

        private void chLineal_CheckedChanged(object sender, EventArgs e)
        {
            if (chLineal.Checked == true)
            {
                cb_lenguaje.Checked = false;
                chMultiplicativo.Checked = false;
                txA.Enabled = true;
                txC.Enabled = true;
                txM.Enabled = true;
                txRaiz.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            oGrilla.DataSource = null;
            oGrilla.Refresh();
            txA.Clear();
            txC.Clear();
            txM.Clear();
            txRaiz.Clear();
        }

        

        private void BtChi_Click(object sender, EventArgs e)
        {
            Form2 oForm = new Form2();
            oForm.Show();
        }

        private void BtMX_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
