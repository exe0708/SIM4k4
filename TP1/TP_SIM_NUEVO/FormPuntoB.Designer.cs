
namespace TP_SIM_NUEVO
{
    partial class FormPuntoB
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgwDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_intervalos = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_muestra = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSumChi = new System.Windows.Forms.Label();
            this.dgwIntervalos = new System.Windows.Forms.DataGridView();
            this.lbl_chi = new System.Windows.Forms.Label();
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
            this.dgwDatos.Size = new System.Drawing.Size(349, 330);
            this.dgwDatos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_intervalos);
            this.groupBox1.Controls.Add(this.btnGenerar);
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
            // txt_intervalos
            // 
            this.txt_intervalos.Location = new System.Drawing.Point(113, 47);
            this.txt_intervalos.Name = "txt_intervalos";
            this.txt_intervalos.Size = new System.Drawing.Size(74, 20);
            this.txt_intervalos.TabIndex = 22;
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
            this.btnLimpiar.Location = new System.Drawing.Point(370, 22);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 32);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(370, 60);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(111, 30);
            this.btnGraficar.TabIndex = 24;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // grafico
            // 
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grafico.Legends.Add(legend3);
            this.grafico.Location = new System.Drawing.Point(370, 115);
            this.grafico.Name = "grafico";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Esperada";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Observada";
            this.grafico.Series.Add(series5);
            this.grafico.Series.Add(series6);
            this.grafico.Size = new System.Drawing.Size(885, 614);
            this.grafico.TabIndex = 26;
            this.grafico.Text = "chart1";
            // 
            // lblSumChi
            // 
            this.lblSumChi.AutoSize = true;
            this.lblSumChi.Location = new System.Drawing.Point(888, 651);
            this.lblSumChi.Name = "lblSumChi";
            this.lblSumChi.Size = new System.Drawing.Size(0, 13);
            this.lblSumChi.TabIndex = 28;
            // 
            // dgwIntervalos
            // 
            this.dgwIntervalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIntervalos.Location = new System.Drawing.Point(15, 460);
            this.dgwIntervalos.Name = "dgwIntervalos";
            this.dgwIntervalos.Size = new System.Drawing.Size(349, 310);
            this.dgwIntervalos.TabIndex = 30;
            // 
            // lbl_chi
            // 
            this.lbl_chi.AutoSize = true;
            this.lbl_chi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chi.Location = new System.Drawing.Point(515, 22);
            this.lbl_chi.Name = "lbl_chi";
            this.lbl_chi.Size = new System.Drawing.Size(25, 31);
            this.lbl_chi.TabIndex = 31;
            this.lbl_chi.Text = "*";
            // 
            // FormPuntoB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 804);
            this.Controls.Add(this.lbl_chi);
            this.Controls.Add(this.dgwIntervalos);
            this.Controls.Add(this.lblSumChi);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwDatos);
            this.MaximizeBox = false;
            this.Name = "FormPuntoB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Punto B";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Label lblSumChi;
        private System.Windows.Forms.DataGridView dgwIntervalos;
        private System.Windows.Forms.TextBox txt_intervalos;
        private System.Windows.Forms.Label lbl_chi;
    }
}

