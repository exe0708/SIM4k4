
namespace TP_SIM_NUEVO
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgwDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_20 = new System.Windows.Forms.RadioButton();
            this.rd_15 = new System.Windows.Forms.RadioButton();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.rd_10 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_muestra = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.btnGraficar2 = new System.Windows.Forms.Button();
            this.lblSumChi = new System.Windows.Forms.Label();
            this.btnLimpiarGrafico = new System.Windows.Forms.Button();
            this.dgwIntervalos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIntervalos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDatos
            // 
            this.dgwDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDatos.Location = new System.Drawing.Point(12, 115);
            this.dgwDatos.Name = "dgwDatos";
            this.dgwDatos.Size = new System.Drawing.Size(329, 254);
            this.dgwDatos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_20);
            this.groupBox1.Controls.Add(this.rd_15);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.rd_10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_muestra);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // rd_20
            // 
            this.rd_20.AutoSize = true;
            this.rd_20.Location = new System.Drawing.Point(187, 48);
            this.rd_20.Name = "rd_20";
            this.rd_20.Size = new System.Drawing.Size(37, 17);
            this.rd_20.TabIndex = 13;
            this.rd_20.TabStop = true;
            this.rd_20.Text = "20";
            this.rd_20.UseVisualStyleBackColor = true;
            // 
            // rd_15
            // 
            this.rd_15.AutoSize = true;
            this.rd_15.Location = new System.Drawing.Point(150, 48);
            this.rd_15.Name = "rd_15";
            this.rd_15.Size = new System.Drawing.Size(37, 17);
            this.rd_15.TabIndex = 12;
            this.rd_15.TabStop = true;
            this.rd_15.Text = "15";
            this.rd_15.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(230, 16);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(96, 61);
            this.btnGenerar.TabIndex = 21;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // rd_10
            // 
            this.rd_10.AutoSize = true;
            this.rd_10.Location = new System.Drawing.Point(113, 48);
            this.rd_10.Name = "rd_10";
            this.rd_10.Size = new System.Drawing.Size(37, 17);
            this.rd_10.TabIndex = 11;
            this.rd_10.TabStop = true;
            this.rd_10.Text = "10";
            this.rd_10.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad Intervalos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Muestra:";
            // 
            // txt_muestra
            // 
            this.txt_muestra.Location = new System.Drawing.Point(60, 16);
            this.txt_muestra.MaxLength = 8;
            this.txt_muestra.Name = "txt_muestra";
            this.txt_muestra.Size = new System.Drawing.Size(73, 20);
            this.txt_muestra.TabIndex = 15;
            this.txt_muestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 776);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 23);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(1211, 776);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(111, 23);
            this.btnGraficar.TabIndex = 24;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            // 
            // grafico
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(347, 26);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Esperada";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Observada";
            this.grafico.Series.Add(series1);
            this.grafico.Series.Add(series2);
            this.grafico.Size = new System.Drawing.Size(905, 614);
            this.grafico.TabIndex = 26;
            this.grafico.Text = "chart1";
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.Location = new System.Drawing.Point(12, 646);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(104, 23);
            this.btnLimpiar2.TabIndex = 23;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // btnGraficar2
            // 
            this.btnGraficar2.Location = new System.Drawing.Point(237, 646);
            this.btnGraficar2.Name = "btnGraficar2";
            this.btnGraficar2.Size = new System.Drawing.Size(104, 23);
            this.btnGraficar2.TabIndex = 27;
            this.btnGraficar2.Text = "Graficar";
            this.btnGraficar2.UseVisualStyleBackColor = true;
            this.btnGraficar2.Click += new System.EventHandler(this.btnGraficar2_Click);
            // 
            // lblSumChi
            // 
            this.lblSumChi.AutoSize = true;
            this.lblSumChi.Location = new System.Drawing.Point(888, 651);
            this.lblSumChi.Name = "lblSumChi";
            this.lblSumChi.Size = new System.Drawing.Size(0, 13);
            this.lblSumChi.TabIndex = 28;
            // 
            // btnLimpiarGrafico
            // 
            this.btnLimpiarGrafico.Location = new System.Drawing.Point(122, 646);
            this.btnLimpiarGrafico.Name = "btnLimpiarGrafico";
            this.btnLimpiarGrafico.Size = new System.Drawing.Size(104, 23);
            this.btnLimpiarGrafico.TabIndex = 29;
            this.btnLimpiarGrafico.Text = "Limpiar Grafico";
            this.btnLimpiarGrafico.UseVisualStyleBackColor = true;
            this.btnLimpiarGrafico.Click += new System.EventHandler(this.btnLimpiarGrafico_Click);
            // 
            // dgwIntervalos
            // 
            this.dgwIntervalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIntervalos.Location = new System.Drawing.Point(12, 386);
            this.dgwIntervalos.Name = "dgwIntervalos";
            this.dgwIntervalos.Size = new System.Drawing.Size(329, 254);
            this.dgwIntervalos.TabIndex = 30;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dgwIntervalos);
            this.Controls.Add(this.btnLimpiarGrafico);
            this.Controls.Add(this.lblSumChi);
            this.Controls.Add(this.btnGraficar2);
            this.Controls.Add(this.btnLimpiar2);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwDatos);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP 1 - Grupo N° 4";
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIntervalos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_muestra;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.RadioButton rd_20;
        private System.Windows.Forms.RadioButton rd_15;
        private System.Windows.Forms.RadioButton rd_10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnGraficar2;
        private System.Windows.Forms.Label lblSumChi;
        private System.Windows.Forms.Button btnLimpiarGrafico;
        private System.Windows.Forms.DataGridView dgwIntervalos;
    }
}

