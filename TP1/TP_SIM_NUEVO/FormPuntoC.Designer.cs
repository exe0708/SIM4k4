
namespace TP_SIM_NUEVO
{
    partial class FormPuntoC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgwIntervalos = new System.Windows.Forms.DataGridView();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgwDatos = new System.Windows.Forms.DataGridView();
            this.btn_graficar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gb_datos = new System.Windows.Forms.GroupBox();
            this.txt_intervalos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_m = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_semilla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sumchi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIntervalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatos)).BeginInit();
            this.gb_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwIntervalos
            // 
            this.dgwIntervalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIntervalos.Location = new System.Drawing.Point(15, 458);
            this.dgwIntervalos.Name = "dgwIntervalos";
            this.dgwIntervalos.Size = new System.Drawing.Size(349, 310);
            this.dgwIntervalos.TabIndex = 34;
            // 
            // grafico
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(367, 113);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Esperada";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Observada";
            this.grafico.Series.Add(series1);
            this.grafico.Series.Add(series2);
            this.grafico.Size = new System.Drawing.Size(885, 655);
            this.grafico.TabIndex = 33;
            this.grafico.Text = "chart1";
            // 
            // dgwDatos
            // 
            this.dgwDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDatos.Location = new System.Drawing.Point(12, 113);
            this.dgwDatos.Name = "dgwDatos";
            this.dgwDatos.Size = new System.Drawing.Size(349, 330);
            this.dgwDatos.TabIndex = 31;
            // 
            // btn_graficar
            // 
            this.btn_graficar.Location = new System.Drawing.Point(669, 68);
            this.btn_graficar.Name = "btn_graficar";
            this.btn_graficar.Size = new System.Drawing.Size(111, 39);
            this.btn_graficar.TabIndex = 37;
            this.btn_graficar.Text = "Graficar";
            this.btn_graficar.UseVisualStyleBackColor = true;
            this.btn_graficar.Click += new System.EventHandler(this.btn_graficar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(669, 23);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 36);
            this.btnLimpiar.TabIndex = 35;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gb_datos
            // 
            this.gb_datos.Controls.Add(this.txt_intervalos);
            this.gb_datos.Controls.Add(this.label6);
            this.gb_datos.Controls.Add(this.btn_generar);
            this.gb_datos.Controls.Add(this.txt_cantidad);
            this.gb_datos.Controls.Add(this.label5);
            this.gb_datos.Controls.Add(this.txt_c);
            this.gb_datos.Controls.Add(this.label4);
            this.gb_datos.Controls.Add(this.txt_m);
            this.gb_datos.Controls.Add(this.label3);
            this.gb_datos.Controls.Add(this.txt_a);
            this.gb_datos.Controls.Add(this.label2);
            this.gb_datos.Controls.Add(this.tx_semilla);
            this.gb_datos.Controls.Add(this.label1);
            this.gb_datos.Location = new System.Drawing.Point(16, 12);
            this.gb_datos.Name = "gb_datos";
            this.gb_datos.Size = new System.Drawing.Size(647, 95);
            this.gb_datos.TabIndex = 39;
            this.gb_datos.TabStop = false;
            this.gb_datos.Text = "Datos ";
            // 
            // txt_intervalos
            // 
            this.txt_intervalos.Location = new System.Drawing.Point(567, 22);
            this.txt_intervalos.Name = "txt_intervalos";
            this.txt_intervalos.Size = new System.Drawing.Size(67, 20);
            this.txt_intervalos.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Intervalos:";
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(351, 53);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(290, 23);
            this.btn_generar.TabIndex = 40;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(421, 22);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(67, 20);
            this.txt_cantidad.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad de \r\nnumeros:";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(270, 53);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(66, 20);
            this.txt_c.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Constante \r\nAditiva [c]:";
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(94, 53);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(66, 20);
            this.txt_m.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modulo [m]:";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(270, 22);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(66, 20);
            this.txt_a.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Constante \r\nMultiplicativa [a]:";
            // 
            // tx_semilla
            // 
            this.tx_semilla.Location = new System.Drawing.Point(94, 21);
            this.tx_semilla.Name = "tx_semilla";
            this.tx_semilla.Size = new System.Drawing.Size(66, 20);
            this.tx_semilla.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seimilla [x0]:";
            // 
            // lbl_sumchi
            // 
            this.lbl_sumchi.AutoSize = true;
            this.lbl_sumchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sumchi.Location = new System.Drawing.Point(799, 23);
            this.lbl_sumchi.Name = "lbl_sumchi";
            this.lbl_sumchi.Size = new System.Drawing.Size(25, 31);
            this.lbl_sumchi.TabIndex = 40;
            this.lbl_sumchi.Text = "*";
            // 
            // FormPuntoC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 845);
            this.Controls.Add(this.lbl_sumchi);
            this.Controls.Add(this.gb_datos);
            this.Controls.Add(this.btn_graficar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgwIntervalos);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.dgwDatos);
            this.Name = "FormPuntoC";
            this.Text = "FormPuntoC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgwIntervalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatos)).EndInit();
            this.gb_datos.ResumeLayout(false);
            this.gb_datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwIntervalos;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.DataGridView dgwDatos;
        private System.Windows.Forms.Button btn_graficar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gb_datos;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_semilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.TextBox txt_intervalos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_sumchi;
    }
}