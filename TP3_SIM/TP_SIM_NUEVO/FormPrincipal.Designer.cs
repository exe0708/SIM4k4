
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgwDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_poisson = new System.Windows.Forms.GroupBox();
            this.txt_lambda_poisson = new System.Windows.Forms.TextBox();
            this.lb_lambda_poison = new System.Windows.Forms.Label();
            this.gb_normal = new System.Windows.Forms.GroupBox();
            this.txt_media_normal = new System.Windows.Forms.TextBox();
            this.lb_media_normal = new System.Windows.Forms.Label();
            this.txt_desv_est = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_exponencial = new System.Windows.Forms.GroupBox();
            this.txt_media_exp = new System.Windows.Forms.TextBox();
            this.lb_media_exp = new System.Windows.Forms.Label();
            this.txt_lambda = new System.Windows.Forms.TextBox();
            this.lb_lambda = new System.Windows.Forms.Label();
            this.gb_uniforme = new System.Windows.Forms.GroupBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.lb_b = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.lb_a = new System.Windows.Forms.Label();
            this.gb_muestra = new System.Windows.Forms.GroupBox();
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_disrtribucion = new System.Windows.Forms.GroupBox();
            this.rb_poisson = new System.Windows.Forms.RadioButton();
            this.lb_distribucion = new System.Windows.Forms.Label();
            this.rb_uniforme = new System.Windows.Forms.RadioButton();
            this.rb_exponencial = new System.Windows.Forms.RadioButton();
            this.rb_normal = new System.Windows.Forms.RadioButton();
            this.btnGraficar2 = new System.Windows.Forms.Button();
            this.gb_intervalos = new System.Windows.Forms.GroupBox();
            this.txt_intervalos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.lblSumChi = new System.Windows.Forms.Label();
            this.btnLimpiarGrafico = new System.Windows.Forms.Button();
            this.dgwIntervalos = new System.Windows.Forms.DataGridView();
            this.lb_chi_cuadrado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_poisson.SuspendLayout();
            this.gb_normal.SuspendLayout();
            this.gb_exponencial.SuspendLayout();
            this.gb_uniforme.SuspendLayout();
            this.gb_muestra.SuspendLayout();
            this.gb_disrtribucion.SuspendLayout();
            this.gb_intervalos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIntervalos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDatos
            // 
            this.dgwDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDatos.Location = new System.Drawing.Point(13, 135);
            this.dgwDatos.Name = "dgwDatos";
            this.dgwDatos.ReadOnly = true;
            this.dgwDatos.Size = new System.Drawing.Size(459, 254);
            this.dgwDatos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gb_poisson);
            this.groupBox1.Controls.Add(this.gb_normal);
            this.groupBox1.Controls.Add(this.gb_exponencial);
            this.groupBox1.Controls.Add(this.gb_uniforme);
            this.groupBox1.Controls.Add(this.gb_muestra);
            this.groupBox1.Controls.Add(this.gb_disrtribucion);
            this.groupBox1.Controls.Add(this.btnGraficar2);
            this.groupBox1.Controls.Add(this.gb_intervalos);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1337, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // gb_poisson
            // 
            this.gb_poisson.Controls.Add(this.txt_lambda_poisson);
            this.gb_poisson.Controls.Add(this.lb_lambda_poison);
            this.gb_poisson.Location = new System.Drawing.Point(831, 20);
            this.gb_poisson.Name = "gb_poisson";
            this.gb_poisson.Size = new System.Drawing.Size(176, 81);
            this.gb_poisson.TabIndex = 31;
            this.gb_poisson.TabStop = false;
            this.gb_poisson.Text = "Poisson";
            // 
            // txt_lambda_poisson
            // 
            this.txt_lambda_poisson.Location = new System.Drawing.Point(70, 23);
            this.txt_lambda_poisson.Name = "txt_lambda_poisson";
            this.txt_lambda_poisson.Size = new System.Drawing.Size(100, 20);
            this.txt_lambda_poisson.TabIndex = 2;
            // 
            // lb_lambda_poison
            // 
            this.lb_lambda_poison.AutoSize = true;
            this.lb_lambda_poison.Location = new System.Drawing.Point(18, 24);
            this.lb_lambda_poison.Name = "lb_lambda_poison";
            this.lb_lambda_poison.Size = new System.Drawing.Size(48, 13);
            this.lb_lambda_poison.TabIndex = 0;
            this.lb_lambda_poison.Text = "Lambda:";
            // 
            // gb_normal
            // 
            this.gb_normal.Controls.Add(this.txt_media_normal);
            this.gb_normal.Controls.Add(this.lb_media_normal);
            this.gb_normal.Controls.Add(this.txt_desv_est);
            this.gb_normal.Controls.Add(this.label2);
            this.gb_normal.Location = new System.Drawing.Point(667, 19);
            this.gb_normal.Name = "gb_normal";
            this.gb_normal.Size = new System.Drawing.Size(158, 83);
            this.gb_normal.TabIndex = 30;
            this.gb_normal.TabStop = false;
            this.gb_normal.Text = "Normal";
            // 
            // txt_media_normal
            // 
            this.txt_media_normal.Location = new System.Drawing.Point(51, 53);
            this.txt_media_normal.MaxLength = 8;
            this.txt_media_normal.Name = "txt_media_normal";
            this.txt_media_normal.Size = new System.Drawing.Size(51, 20);
            this.txt_media_normal.TabIndex = 17;
            // 
            // lb_media_normal
            // 
            this.lb_media_normal.AutoSize = true;
            this.lb_media_normal.Location = new System.Drawing.Point(6, 56);
            this.lb_media_normal.Name = "lb_media_normal";
            this.lb_media_normal.Size = new System.Drawing.Size(39, 13);
            this.lb_media_normal.TabIndex = 18;
            this.lb_media_normal.Text = "Media:";
            // 
            // txt_desv_est
            // 
            this.txt_desv_est.Location = new System.Drawing.Point(92, 28);
            this.txt_desv_est.MaxLength = 8;
            this.txt_desv_est.Name = "txt_desv_est";
            this.txt_desv_est.Size = new System.Drawing.Size(51, 20);
            this.txt_desv_est.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Desv. Estandar:";
            // 
            // gb_exponencial
            // 
            this.gb_exponencial.Controls.Add(this.txt_media_exp);
            this.gb_exponencial.Controls.Add(this.lb_media_exp);
            this.gb_exponencial.Controls.Add(this.txt_lambda);
            this.gb_exponencial.Controls.Add(this.lb_lambda);
            this.gb_exponencial.Location = new System.Drawing.Point(539, 19);
            this.gb_exponencial.Name = "gb_exponencial";
            this.gb_exponencial.Size = new System.Drawing.Size(127, 83);
            this.gb_exponencial.TabIndex = 29;
            this.gb_exponencial.TabStop = false;
            this.gb_exponencial.Text = "Exponencial";
            // 
            // txt_media_exp
            // 
            this.txt_media_exp.Location = new System.Drawing.Point(60, 52);
            this.txt_media_exp.MaxLength = 8;
            this.txt_media_exp.Name = "txt_media_exp";
            this.txt_media_exp.Size = new System.Drawing.Size(51, 20);
            this.txt_media_exp.TabIndex = 17;
            this.txt_media_exp.TextChanged += new System.EventHandler(this.txt_media_exp_TextChanged);
            // 
            // lb_media_exp
            // 
            this.lb_media_exp.AutoSize = true;
            this.lb_media_exp.Location = new System.Drawing.Point(6, 56);
            this.lb_media_exp.Name = "lb_media_exp";
            this.lb_media_exp.Size = new System.Drawing.Size(39, 13);
            this.lb_media_exp.TabIndex = 18;
            this.lb_media_exp.Text = "Media:";
            // 
            // txt_lambda
            // 
            this.txt_lambda.Location = new System.Drawing.Point(60, 26);
            this.txt_lambda.MaxLength = 8;
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(51, 20);
            this.txt_lambda.TabIndex = 15;
            // 
            // lb_lambda
            // 
            this.lb_lambda.AutoSize = true;
            this.lb_lambda.Location = new System.Drawing.Point(6, 29);
            this.lb_lambda.Name = "lb_lambda";
            this.lb_lambda.Size = new System.Drawing.Size(48, 13);
            this.lb_lambda.TabIndex = 16;
            this.lb_lambda.Text = "Lambda:";
            // 
            // gb_uniforme
            // 
            this.gb_uniforme.Controls.Add(this.txt_b);
            this.gb_uniforme.Controls.Add(this.lb_b);
            this.gb_uniforme.Controls.Add(this.txt_a);
            this.gb_uniforme.Controls.Add(this.lb_a);
            this.gb_uniforme.Location = new System.Drawing.Point(453, 20);
            this.gb_uniforme.Name = "gb_uniforme";
            this.gb_uniforme.Size = new System.Drawing.Size(80, 83);
            this.gb_uniforme.TabIndex = 28;
            this.gb_uniforme.TabStop = false;
            this.gb_uniforme.Text = "Uniforme";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(29, 51);
            this.txt_b.MaxLength = 8;
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(35, 20);
            this.txt_b.TabIndex = 17;
            // 
            // lb_b
            // 
            this.lb_b.AutoSize = true;
            this.lb_b.Location = new System.Drawing.Point(6, 54);
            this.lb_b.Name = "lb_b";
            this.lb_b.Size = new System.Drawing.Size(17, 13);
            this.lb_b.TabIndex = 18;
            this.lb_b.Text = "B:";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(29, 23);
            this.txt_a.MaxLength = 8;
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(35, 20);
            this.txt_a.TabIndex = 15;
            // 
            // lb_a
            // 
            this.lb_a.AutoSize = true;
            this.lb_a.Location = new System.Drawing.Point(6, 28);
            this.lb_a.Name = "lb_a";
            this.lb_a.Size = new System.Drawing.Size(17, 13);
            this.lb_a.TabIndex = 16;
            this.lb_a.Text = "A:";
            // 
            // gb_muestra
            // 
            this.gb_muestra.Controls.Add(this.txtMuestra);
            this.gb_muestra.Controls.Add(this.label5);
            this.gb_muestra.Location = new System.Drawing.Point(307, 19);
            this.gb_muestra.Name = "gb_muestra";
            this.gb_muestra.Size = new System.Drawing.Size(140, 83);
            this.gb_muestra.TabIndex = 27;
            this.gb_muestra.TabStop = false;
            this.gb_muestra.Text = "Muestra";
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(61, 25);
            this.txtMuestra.MaxLength = 8;
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(73, 20);
            this.txtMuestra.TabIndex = 15;
            this.txtMuestra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMuestra_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Muestra:";
            // 
            // gb_disrtribucion
            // 
            this.gb_disrtribucion.Controls.Add(this.rb_poisson);
            this.gb_disrtribucion.Controls.Add(this.lb_distribucion);
            this.gb_disrtribucion.Controls.Add(this.rb_uniforme);
            this.gb_disrtribucion.Controls.Add(this.rb_exponencial);
            this.gb_disrtribucion.Controls.Add(this.rb_normal);
            this.gb_disrtribucion.Location = new System.Drawing.Point(6, 19);
            this.gb_disrtribucion.Name = "gb_disrtribucion";
            this.gb_disrtribucion.Size = new System.Drawing.Size(295, 101);
            this.gb_disrtribucion.TabIndex = 26;
            this.gb_disrtribucion.TabStop = false;
            this.gb_disrtribucion.Text = "Distribuciones";
            // 
            // rb_poisson
            // 
            this.rb_poisson.AutoSize = true;
            this.rb_poisson.Location = new System.Drawing.Point(102, 80);
            this.rb_poisson.Name = "rb_poisson";
            this.rb_poisson.Size = new System.Drawing.Size(62, 17);
            this.rb_poisson.TabIndex = 14;
            this.rb_poisson.TabStop = true;
            this.rb_poisson.Text = "Poisson";
            this.rb_poisson.UseVisualStyleBackColor = true;
            // 
            // lb_distribucion
            // 
            this.lb_distribucion.AutoSize = true;
            this.lb_distribucion.Location = new System.Drawing.Point(6, 28);
            this.lb_distribucion.Name = "lb_distribucion";
            this.lb_distribucion.Size = new System.Drawing.Size(65, 13);
            this.lb_distribucion.TabIndex = 9;
            this.lb_distribucion.Text = "Distribucion:";
            // 
            // rb_uniforme
            // 
            this.rb_uniforme.AutoSize = true;
            this.rb_uniforme.Location = new System.Drawing.Point(102, 11);
            this.rb_uniforme.Name = "rb_uniforme";
            this.rb_uniforme.Size = new System.Drawing.Size(67, 17);
            this.rb_uniforme.TabIndex = 11;
            this.rb_uniforme.TabStop = true;
            this.rb_uniforme.Text = "Uniforme";
            this.rb_uniforme.UseVisualStyleBackColor = true;
            this.rb_uniforme.CheckedChanged += new System.EventHandler(this.rb_uniforme_CheckedChanged);
            // 
            // rb_exponencial
            // 
            this.rb_exponencial.AutoSize = true;
            this.rb_exponencial.Location = new System.Drawing.Point(102, 34);
            this.rb_exponencial.Name = "rb_exponencial";
            this.rb_exponencial.Size = new System.Drawing.Size(129, 17);
            this.rb_exponencial.TabIndex = 12;
            this.rb_exponencial.TabStop = true;
            this.rb_exponencial.Text = "Exponencial Negativa";
            this.rb_exponencial.UseVisualStyleBackColor = true;
            // 
            // rb_normal
            // 
            this.rb_normal.AutoSize = true;
            this.rb_normal.Location = new System.Drawing.Point(102, 57);
            this.rb_normal.Name = "rb_normal";
            this.rb_normal.Size = new System.Drawing.Size(58, 17);
            this.rb_normal.TabIndex = 13;
            this.rb_normal.TabStop = true;
            this.rb_normal.Text = "Normal";
            this.rb_normal.UseVisualStyleBackColor = true;
            this.rb_normal.CheckedChanged += new System.EventHandler(this.rb_normal_CheckedChanged);
            // 
            // btnGraficar2
            // 
            this.btnGraficar2.Location = new System.Drawing.Point(1205, 19);
            this.btnGraficar2.Name = "btnGraficar2";
            this.btnGraficar2.Size = new System.Drawing.Size(104, 35);
            this.btnGraficar2.TabIndex = 27;
            this.btnGraficar2.Text = "Graficar";
            this.btnGraficar2.UseVisualStyleBackColor = true;
            this.btnGraficar2.Click += new System.EventHandler(this.btnGraficar2_Click);
            // 
            // gb_intervalos
            // 
            this.gb_intervalos.Controls.Add(this.txt_intervalos);
            this.gb_intervalos.Controls.Add(this.label7);
            this.gb_intervalos.Location = new System.Drawing.Point(1013, 19);
            this.gb_intervalos.Name = "gb_intervalos";
            this.gb_intervalos.Size = new System.Drawing.Size(157, 82);
            this.gb_intervalos.TabIndex = 25;
            this.gb_intervalos.TabStop = false;
            this.gb_intervalos.Text = "Intervalos";
            // 
            // txt_intervalos
            // 
            this.txt_intervalos.Location = new System.Drawing.Point(19, 49);
            this.txt_intervalos.Name = "txt_intervalos";
            this.txt_intervalos.Size = new System.Drawing.Size(100, 20);
            this.txt_intervalos.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad Intervalos:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(1205, 58);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(104, 36);
            this.btnGenerar.TabIndex = 21;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
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
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafico.Legends.Add(legend2);
            this.grafico.Location = new System.Drawing.Point(496, 139);
            this.grafico.Name = "grafico";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Esperada";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Observada";
            this.grafico.Series.Add(series3);
            this.grafico.Series.Add(series4);
            this.grafico.Size = new System.Drawing.Size(855, 521);
            this.grafico.TabIndex = 26;
            this.grafico.Text = "chart1";
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.Location = new System.Drawing.Point(13, 666);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(104, 23);
            this.btnLimpiar2.TabIndex = 23;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // lblSumChi
            // 
            this.lblSumChi.AutoSize = true;
            this.lblSumChi.Location = new System.Drawing.Point(889, 671);
            this.lblSumChi.Name = "lblSumChi";
            this.lblSumChi.Size = new System.Drawing.Size(0, 13);
            this.lblSumChi.TabIndex = 28;
            // 
            // btnLimpiarGrafico
            // 
            this.btnLimpiarGrafico.Location = new System.Drawing.Point(123, 666);
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
            this.dgwIntervalos.Location = new System.Drawing.Point(15, 406);
            this.dgwIntervalos.Name = "dgwIntervalos";
            this.dgwIntervalos.ReadOnly = true;
            this.dgwIntervalos.Size = new System.Drawing.Size(457, 254);
            this.dgwIntervalos.TabIndex = 30;
            // 
            // lb_chi_cuadrado
            // 
            this.lb_chi_cuadrado.AutoSize = true;
            this.lb_chi_cuadrado.Location = new System.Drawing.Point(1008, 676);
            this.lb_chi_cuadrado.Name = "lb_chi_cuadrado";
            this.lb_chi_cuadrado.Size = new System.Drawing.Size(0, 13);
            this.lb_chi_cuadrado.TabIndex = 31;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1396, 779);
            this.Controls.Add(this.lb_chi_cuadrado);
            this.Controls.Add(this.dgwIntervalos);
            this.Controls.Add(this.btnLimpiarGrafico);
            this.Controls.Add(this.lblSumChi);
            this.Controls.Add(this.btnLimpiar2);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwDatos);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP 3 - Grupo A Carranza Exequiel Carranza Agustin Marandino Giopvanna Fransisco Z" +
    "apata";
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gb_poisson.ResumeLayout(false);
            this.gb_poisson.PerformLayout();
            this.gb_normal.ResumeLayout(false);
            this.gb_normal.PerformLayout();
            this.gb_exponencial.ResumeLayout(false);
            this.gb_exponencial.PerformLayout();
            this.gb_uniforme.ResumeLayout(false);
            this.gb_uniforme.PerformLayout();
            this.gb_muestra.ResumeLayout(false);
            this.gb_muestra.PerformLayout();
            this.gb_disrtribucion.ResumeLayout(false);
            this.gb_disrtribucion.PerformLayout();
            this.gb_intervalos.ResumeLayout(false);
            this.gb_intervalos.PerformLayout();
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
        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnGraficar2;
        private System.Windows.Forms.Label lblSumChi;
        private System.Windows.Forms.Button btnLimpiarGrafico;
        private System.Windows.Forms.DataGridView dgwIntervalos;
        private System.Windows.Forms.GroupBox gb_disrtribucion;
        private System.Windows.Forms.Label lb_distribucion;
        private System.Windows.Forms.RadioButton rb_uniforme;
        private System.Windows.Forms.RadioButton rb_exponencial;
        private System.Windows.Forms.RadioButton rb_normal;
        private System.Windows.Forms.GroupBox gb_intervalos;
        private System.Windows.Forms.GroupBox gb_uniforme;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label lb_b;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label lb_a;
        private System.Windows.Forms.GroupBox gb_muestra;
        private System.Windows.Forms.GroupBox gb_exponencial;
        private System.Windows.Forms.TextBox txt_media_exp;
        private System.Windows.Forms.Label lb_media_exp;
        private System.Windows.Forms.TextBox txt_lambda;
        private System.Windows.Forms.Label lb_lambda;
        private System.Windows.Forms.GroupBox gb_normal;
        private System.Windows.Forms.TextBox txt_media_normal;
        private System.Windows.Forms.Label lb_media_normal;
        private System.Windows.Forms.TextBox txt_desv_est;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_poisson;
        private System.Windows.Forms.TextBox txt_lambda_poisson;
        private System.Windows.Forms.Label lb_lambda_poison;
        private System.Windows.Forms.RadioButton rb_poisson;
        private System.Windows.Forms.Label lb_chi_cuadrado;
        private System.Windows.Forms.TextBox txt_intervalos;
    }
}

