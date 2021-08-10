
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgwDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_20 = new System.Windows.Forms.RadioButton();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.rd_15 = new System.Windows.Forms.RadioButton();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.rd_10 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAleatorio = new System.Windows.Forms.CheckBox();
            this.cbMultiplicativo = new System.Windows.Forms.CheckBox();
            this.cbLineal = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.btnGraficar2 = new System.Windows.Forms.Button();
            this.lblSumChi = new System.Windows.Forms.Label();
            this.btnLimpiarGrafico = new System.Windows.Forms.Button();
            this.dgwIntervalos = new System.Windows.Forms.DataGridView();
            this.btnNuevoAleatorio = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.btnNuevoAleatorio);
            this.groupBox1.Controls.Add(this.rd_20);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.rd_15);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.rd_10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbAleatorio);
            this.groupBox1.Controls.Add(this.cbMultiplicativo);
            this.groupBox1.Controls.Add(this.cbLineal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMuestra);
            this.groupBox1.Controls.Add(this.txtG);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSemilla);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1239, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // rd_20
            // 
            this.rd_20.AutoSize = true;
            this.rd_20.Location = new System.Drawing.Point(1018, 43);
            this.rd_20.Name = "rd_20";
            this.rd_20.Size = new System.Drawing.Size(37, 17);
            this.rd_20.TabIndex = 13;
            this.rd_20.TabStop = true;
            this.rd_20.Text = "20";
            this.rd_20.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1129, 65);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(104, 23);
            this.btnNuevo.TabIndex = 22;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // rd_15
            // 
            this.rd_15.AutoSize = true;
            this.rd_15.Location = new System.Drawing.Point(981, 43);
            this.rd_15.Name = "rd_15";
            this.rd_15.Size = new System.Drawing.Size(37, 17);
            this.rd_15.TabIndex = 12;
            this.rd_15.TabStop = true;
            this.rd_15.Text = "15";
            this.rd_15.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(1129, 19);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(104, 23);
            this.btnGenerar.TabIndex = 21;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // rd_10
            // 
            this.rd_10.AutoSize = true;
            this.rd_10.Location = new System.Drawing.Point(944, 43);
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
            this.label7.Location = new System.Drawing.Point(837, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad Intervalos:";
            // 
            // cbAleatorio
            // 
            this.cbAleatorio.AutoSize = true;
            this.cbAleatorio.Location = new System.Drawing.Point(725, 43);
            this.cbAleatorio.Name = "cbAleatorio";
            this.cbAleatorio.Size = new System.Drawing.Size(67, 17);
            this.cbAleatorio.TabIndex = 20;
            this.cbAleatorio.Text = "Aleatorio";
            this.cbAleatorio.UseVisualStyleBackColor = true;
            this.cbAleatorio.CheckedChanged += new System.EventHandler(this.cbAleatorio_CheckedChanged);
            // 
            // cbMultiplicativo
            // 
            this.cbMultiplicativo.AutoSize = true;
            this.cbMultiplicativo.Location = new System.Drawing.Point(574, 43);
            this.cbMultiplicativo.Name = "cbMultiplicativo";
            this.cbMultiplicativo.Size = new System.Drawing.Size(145, 17);
            this.cbMultiplicativo.TabIndex = 19;
            this.cbMultiplicativo.Text = "Congruente Multiplicativo";
            this.cbMultiplicativo.UseVisualStyleBackColor = true;
            this.cbMultiplicativo.CheckedChanged += new System.EventHandler(this.cbMultiplicativo_CheckedChanged);
            // 
            // cbLineal
            // 
            this.cbLineal.AutoSize = true;
            this.cbLineal.Checked = true;
            this.cbLineal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLineal.Location = new System.Drawing.Point(456, 43);
            this.cbLineal.Name = "cbLineal";
            this.cbLineal.Size = new System.Drawing.Size(112, 17);
            this.cbLineal.TabIndex = 18;
            this.cbLineal.Text = "Congruente Lineal";
            this.cbLineal.UseVisualStyleBackColor = true;
            this.cbLineal.CheckedChanged += new System.EventHandler(this.cbLineal_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Muestra:";
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(344, 40);
            this.txtMuestra.MaxLength = 8;
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(73, 20);
            this.txtMuestra.TabIndex = 15;
            this.txtMuestra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMuestra_KeyPress);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(181, 61);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(49, 20);
            this.txtG.TabIndex = 11;
            this.txtG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtG_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "G:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(104, 61);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(46, 20);
            this.txtC.TabIndex = 10;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "C:";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(31, 61);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(45, 20);
            this.txtK.TabIndex = 9;
            this.txtK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtK_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "K:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Semilla";
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(52, 23);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(178, 20);
            this.txtSemilla.TabIndex = 0;
            this.txtSemilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSemilla_KeyPress);
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
            chartArea4.AxisX.Interval = 1D;
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.grafico.Legends.Add(legend4);
            this.grafico.Location = new System.Drawing.Point(347, 119);
            this.grafico.Name = "grafico";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Esperada";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Observada";
            this.grafico.Series.Add(series7);
            this.grafico.Series.Add(series8);
            this.grafico.Size = new System.Drawing.Size(905, 521);
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
            this.btnGraficar2.Location = new System.Drawing.Point(1148, 646);
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
            this.btnLimpiarGrafico.Location = new System.Drawing.Point(347, 651);
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
            // btnNuevoAleatorio
            // 
            this.btnNuevoAleatorio.Location = new System.Drawing.Point(1129, 66);
            this.btnNuevoAleatorio.Name = "btnNuevoAleatorio";
            this.btnNuevoAleatorio.Size = new System.Drawing.Size(104, 23);
            this.btnNuevoAleatorio.TabIndex = 23;
            this.btnNuevoAleatorio.Text = "Nuevo";
            this.btnNuevoAleatorio.UseVisualStyleBackColor = true;
            this.btnNuevoAleatorio.Click += new System.EventHandler(this.btnNuevoAleatorio_Click);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.CheckBox cbAleatorio;
        private System.Windows.Forms.CheckBox cbMultiplicativo;
        private System.Windows.Forms.CheckBox cbLineal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Button btnNuevoAleatorio;
    }
}

