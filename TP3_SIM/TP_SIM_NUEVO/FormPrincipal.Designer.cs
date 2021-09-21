
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.dgwDatos.Location = new System.Drawing.Point(17, 166);
            this.dgwDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgwDatos.Name = "dgwDatos";
            this.dgwDatos.ReadOnly = true;
            this.dgwDatos.RowHeadersWidth = 51;
            this.dgwDatos.Size = new System.Drawing.Size(612, 313);
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
            this.groupBox1.Location = new System.Drawing.Point(17, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1783, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // gb_poisson
            // 
            this.gb_poisson.Controls.Add(this.txt_lambda_poisson);
            this.gb_poisson.Controls.Add(this.lb_lambda_poison);
            this.gb_poisson.Location = new System.Drawing.Point(1108, 25);
            this.gb_poisson.Margin = new System.Windows.Forms.Padding(4);
            this.gb_poisson.Name = "gb_poisson";
            this.gb_poisson.Padding = new System.Windows.Forms.Padding(4);
            this.gb_poisson.Size = new System.Drawing.Size(235, 100);
            this.gb_poisson.TabIndex = 31;
            this.gb_poisson.TabStop = false;
            this.gb_poisson.Text = "Poisson";
            // 
            // txt_lambda_poisson
            // 
            this.txt_lambda_poisson.Location = new System.Drawing.Point(93, 28);
            this.txt_lambda_poisson.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lambda_poisson.Name = "txt_lambda_poisson";
            this.txt_lambda_poisson.Size = new System.Drawing.Size(132, 22);
            this.txt_lambda_poisson.TabIndex = 2;
            // 
            // lb_lambda_poison
            // 
            this.lb_lambda_poison.AutoSize = true;
            this.lb_lambda_poison.Location = new System.Drawing.Point(24, 30);
            this.lb_lambda_poison.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lambda_poison.Name = "lb_lambda_poison";
            this.lb_lambda_poison.Size = new System.Drawing.Size(63, 17);
            this.lb_lambda_poison.TabIndex = 0;
            this.lb_lambda_poison.Text = "Lambda:";
            // 
            // gb_normal
            // 
            this.gb_normal.Controls.Add(this.txt_media_normal);
            this.gb_normal.Controls.Add(this.lb_media_normal);
            this.gb_normal.Controls.Add(this.txt_desv_est);
            this.gb_normal.Controls.Add(this.label2);
            this.gb_normal.Location = new System.Drawing.Point(889, 23);
            this.gb_normal.Margin = new System.Windows.Forms.Padding(4);
            this.gb_normal.Name = "gb_normal";
            this.gb_normal.Padding = new System.Windows.Forms.Padding(4);
            this.gb_normal.Size = new System.Drawing.Size(211, 102);
            this.gb_normal.TabIndex = 30;
            this.gb_normal.TabStop = false;
            this.gb_normal.Text = "Normal";
            // 
            // txt_media_normal
            // 
            this.txt_media_normal.Location = new System.Drawing.Point(68, 65);
            this.txt_media_normal.Margin = new System.Windows.Forms.Padding(4);
            this.txt_media_normal.MaxLength = 8;
            this.txt_media_normal.Name = "txt_media_normal";
            this.txt_media_normal.Size = new System.Drawing.Size(67, 22);
            this.txt_media_normal.TabIndex = 17;
            // 
            // lb_media_normal
            // 
            this.lb_media_normal.AutoSize = true;
            this.lb_media_normal.Location = new System.Drawing.Point(8, 69);
            this.lb_media_normal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_media_normal.Name = "lb_media_normal";
            this.lb_media_normal.Size = new System.Drawing.Size(50, 17);
            this.lb_media_normal.TabIndex = 18;
            this.lb_media_normal.Text = "Media:";
            // 
            // txt_desv_est
            // 
            this.txt_desv_est.Location = new System.Drawing.Point(123, 34);
            this.txt_desv_est.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desv_est.MaxLength = 8;
            this.txt_desv_est.Name = "txt_desv_est";
            this.txt_desv_est.Size = new System.Drawing.Size(67, 22);
            this.txt_desv_est.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Desv. Estandar:";
            // 
            // gb_exponencial
            // 
            this.gb_exponencial.Controls.Add(this.txt_media_exp);
            this.gb_exponencial.Controls.Add(this.lb_media_exp);
            this.gb_exponencial.Controls.Add(this.txt_lambda);
            this.gb_exponencial.Controls.Add(this.lb_lambda);
            this.gb_exponencial.Location = new System.Drawing.Point(719, 23);
            this.gb_exponencial.Margin = new System.Windows.Forms.Padding(4);
            this.gb_exponencial.Name = "gb_exponencial";
            this.gb_exponencial.Padding = new System.Windows.Forms.Padding(4);
            this.gb_exponencial.Size = new System.Drawing.Size(169, 102);
            this.gb_exponencial.TabIndex = 29;
            this.gb_exponencial.TabStop = false;
            this.gb_exponencial.Text = "Exponencial";
            // 
            // txt_media_exp
            // 
            this.txt_media_exp.Location = new System.Drawing.Point(80, 64);
            this.txt_media_exp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_media_exp.MaxLength = 8;
            this.txt_media_exp.Name = "txt_media_exp";
            this.txt_media_exp.Size = new System.Drawing.Size(67, 22);
            this.txt_media_exp.TabIndex = 17;
            this.txt_media_exp.TextChanged += new System.EventHandler(this.txt_media_exp_TextChanged);
            // 
            // lb_media_exp
            // 
            this.lb_media_exp.AutoSize = true;
            this.lb_media_exp.Location = new System.Drawing.Point(8, 69);
            this.lb_media_exp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_media_exp.Name = "lb_media_exp";
            this.lb_media_exp.Size = new System.Drawing.Size(50, 17);
            this.lb_media_exp.TabIndex = 18;
            this.lb_media_exp.Text = "Media:";
            // 
            // txt_lambda
            // 
            this.txt_lambda.Location = new System.Drawing.Point(80, 32);
            this.txt_lambda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lambda.MaxLength = 8;
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(67, 22);
            this.txt_lambda.TabIndex = 15;
            // 
            // lb_lambda
            // 
            this.lb_lambda.AutoSize = true;
            this.lb_lambda.Location = new System.Drawing.Point(8, 36);
            this.lb_lambda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lambda.Name = "lb_lambda";
            this.lb_lambda.Size = new System.Drawing.Size(63, 17);
            this.lb_lambda.TabIndex = 16;
            this.lb_lambda.Text = "Lambda:";
            // 
            // gb_uniforme
            // 
            this.gb_uniforme.Controls.Add(this.txt_b);
            this.gb_uniforme.Controls.Add(this.lb_b);
            this.gb_uniforme.Controls.Add(this.txt_a);
            this.gb_uniforme.Controls.Add(this.lb_a);
            this.gb_uniforme.Location = new System.Drawing.Point(604, 25);
            this.gb_uniforme.Margin = new System.Windows.Forms.Padding(4);
            this.gb_uniforme.Name = "gb_uniforme";
            this.gb_uniforme.Padding = new System.Windows.Forms.Padding(4);
            this.gb_uniforme.Size = new System.Drawing.Size(107, 102);
            this.gb_uniforme.TabIndex = 28;
            this.gb_uniforme.TabStop = false;
            this.gb_uniforme.Text = "Uniforme";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(39, 63);
            this.txt_b.Margin = new System.Windows.Forms.Padding(4);
            this.txt_b.MaxLength = 8;
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(45, 22);
            this.txt_b.TabIndex = 17;
            // 
            // lb_b
            // 
            this.lb_b.AutoSize = true;
            this.lb_b.Location = new System.Drawing.Point(8, 66);
            this.lb_b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_b.Name = "lb_b";
            this.lb_b.Size = new System.Drawing.Size(21, 17);
            this.lb_b.TabIndex = 18;
            this.lb_b.Text = "B:";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(39, 28);
            this.txt_a.Margin = new System.Windows.Forms.Padding(4);
            this.txt_a.MaxLength = 8;
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(45, 22);
            this.txt_a.TabIndex = 15;
            // 
            // lb_a
            // 
            this.lb_a.AutoSize = true;
            this.lb_a.Location = new System.Drawing.Point(8, 34);
            this.lb_a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_a.Name = "lb_a";
            this.lb_a.Size = new System.Drawing.Size(21, 17);
            this.lb_a.TabIndex = 16;
            this.lb_a.Text = "A:";
            // 
            // gb_muestra
            // 
            this.gb_muestra.Controls.Add(this.txtMuestra);
            this.gb_muestra.Controls.Add(this.label5);
            this.gb_muestra.Location = new System.Drawing.Point(409, 23);
            this.gb_muestra.Margin = new System.Windows.Forms.Padding(4);
            this.gb_muestra.Name = "gb_muestra";
            this.gb_muestra.Padding = new System.Windows.Forms.Padding(4);
            this.gb_muestra.Size = new System.Drawing.Size(187, 102);
            this.gb_muestra.TabIndex = 27;
            this.gb_muestra.TabStop = false;
            this.gb_muestra.Text = "Muestra";
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(81, 31);
            this.txtMuestra.Margin = new System.Windows.Forms.Padding(4);
            this.txtMuestra.MaxLength = 8;
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(96, 22);
            this.txtMuestra.TabIndex = 15;
            this.txtMuestra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMuestra_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
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
            this.gb_disrtribucion.Location = new System.Drawing.Point(8, 23);
            this.gb_disrtribucion.Margin = new System.Windows.Forms.Padding(4);
            this.gb_disrtribucion.Name = "gb_disrtribucion";
            this.gb_disrtribucion.Padding = new System.Windows.Forms.Padding(4);
            this.gb_disrtribucion.Size = new System.Drawing.Size(393, 124);
            this.gb_disrtribucion.TabIndex = 26;
            this.gb_disrtribucion.TabStop = false;
            this.gb_disrtribucion.Text = "Distribuciones";
            // 
            // rb_poisson
            // 
            this.rb_poisson.AutoSize = true;
            this.rb_poisson.Location = new System.Drawing.Point(136, 98);
            this.rb_poisson.Margin = new System.Windows.Forms.Padding(4);
            this.rb_poisson.Name = "rb_poisson";
            this.rb_poisson.Size = new System.Drawing.Size(79, 21);
            this.rb_poisson.TabIndex = 14;
            this.rb_poisson.TabStop = true;
            this.rb_poisson.Text = "Poisson";
            this.rb_poisson.UseVisualStyleBackColor = true;
            // 
            // lb_distribucion
            // 
            this.lb_distribucion.AutoSize = true;
            this.lb_distribucion.Location = new System.Drawing.Point(8, 34);
            this.lb_distribucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_distribucion.Name = "lb_distribucion";
            this.lb_distribucion.Size = new System.Drawing.Size(86, 17);
            this.lb_distribucion.TabIndex = 9;
            this.lb_distribucion.Text = "Distribucion:";
            // 
            // rb_uniforme
            // 
            this.rb_uniforme.AutoSize = true;
            this.rb_uniforme.Location = new System.Drawing.Point(136, 14);
            this.rb_uniforme.Margin = new System.Windows.Forms.Padding(4);
            this.rb_uniforme.Name = "rb_uniforme";
            this.rb_uniforme.Size = new System.Drawing.Size(86, 21);
            this.rb_uniforme.TabIndex = 11;
            this.rb_uniforme.TabStop = true;
            this.rb_uniforme.Text = "Uniforme";
            this.rb_uniforme.UseVisualStyleBackColor = true;
            this.rb_uniforme.CheckedChanged += new System.EventHandler(this.rb_uniforme_CheckedChanged);
            // 
            // rb_exponencial
            // 
            this.rb_exponencial.AutoSize = true;
            this.rb_exponencial.Location = new System.Drawing.Point(136, 42);
            this.rb_exponencial.Margin = new System.Windows.Forms.Padding(4);
            this.rb_exponencial.Name = "rb_exponencial";
            this.rb_exponencial.Size = new System.Drawing.Size(165, 21);
            this.rb_exponencial.TabIndex = 12;
            this.rb_exponencial.TabStop = true;
            this.rb_exponencial.Text = "Exponencial Negativa";
            this.rb_exponencial.UseVisualStyleBackColor = true;
            // 
            // rb_normal
            // 
            this.rb_normal.AutoSize = true;
            this.rb_normal.Location = new System.Drawing.Point(136, 70);
            this.rb_normal.Margin = new System.Windows.Forms.Padding(4);
            this.rb_normal.Name = "rb_normal";
            this.rb_normal.Size = new System.Drawing.Size(74, 21);
            this.rb_normal.TabIndex = 13;
            this.rb_normal.TabStop = true;
            this.rb_normal.Text = "Normal";
            this.rb_normal.UseVisualStyleBackColor = true;
            this.rb_normal.CheckedChanged += new System.EventHandler(this.rb_normal_CheckedChanged);
            // 
            // btnGraficar2
            // 
            this.btnGraficar2.Location = new System.Drawing.Point(1607, 23);
            this.btnGraficar2.Margin = new System.Windows.Forms.Padding(4);
            this.btnGraficar2.Name = "btnGraficar2";
            this.btnGraficar2.Size = new System.Drawing.Size(139, 43);
            this.btnGraficar2.TabIndex = 27;
            this.btnGraficar2.Text = "Graficar";
            this.btnGraficar2.UseVisualStyleBackColor = true;
            this.btnGraficar2.Click += new System.EventHandler(this.btnGraficar2_Click);
            // 
            // gb_intervalos
            // 
            this.gb_intervalos.Controls.Add(this.txt_intervalos);
            this.gb_intervalos.Controls.Add(this.label7);
            this.gb_intervalos.Location = new System.Drawing.Point(1351, 23);
            this.gb_intervalos.Margin = new System.Windows.Forms.Padding(4);
            this.gb_intervalos.Name = "gb_intervalos";
            this.gb_intervalos.Padding = new System.Windows.Forms.Padding(4);
            this.gb_intervalos.Size = new System.Drawing.Size(209, 101);
            this.gb_intervalos.TabIndex = 25;
            this.gb_intervalos.TabStop = false;
            this.gb_intervalos.Text = "Intervalos";
            // 
            // txt_intervalos
            // 
            this.txt_intervalos.Location = new System.Drawing.Point(25, 60);
            this.txt_intervalos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_intervalos.Name = "txt_intervalos";
            this.txt_intervalos.Size = new System.Drawing.Size(132, 22);
            this.txt_intervalos.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad Intervalos:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(1607, 71);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(139, 44);
            this.btnGenerar.TabIndex = 21;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // grafico
            // 
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grafico.Legends.Add(legend3);
            this.grafico.Location = new System.Drawing.Point(661, 171);
            this.grafico.Margin = new System.Windows.Forms.Padding(4);
            this.grafico.Name = "grafico";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Esperada";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Observada";
            this.grafico.Series.Add(series5);
            this.grafico.Series.Add(series6);
            this.grafico.Size = new System.Drawing.Size(1140, 641);
            this.grafico.TabIndex = 26;
            this.grafico.Text = "chart1";
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.Location = new System.Drawing.Point(17, 820);
            this.btnLimpiar2.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLimpiar2.Size = new System.Drawing.Size(139, 28);
            this.btnLimpiar2.TabIndex = 50;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // lblSumChi
            // 
            this.lblSumChi.AutoSize = true;
            this.lblSumChi.Location = new System.Drawing.Point(1185, 826);
            this.lblSumChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumChi.Name = "lblSumChi";
            this.lblSumChi.Size = new System.Drawing.Size(0, 17);
            this.lblSumChi.TabIndex = 28;
            // 
            // btnLimpiarGrafico
            // 
            this.btnLimpiarGrafico.Location = new System.Drawing.Point(164, 820);
            this.btnLimpiarGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarGrafico.Name = "btnLimpiarGrafico";
            this.btnLimpiarGrafico.Size = new System.Drawing.Size(139, 28);
            this.btnLimpiarGrafico.TabIndex = 29;
            this.btnLimpiarGrafico.Text = "Limpiar Grafico";
            this.btnLimpiarGrafico.UseVisualStyleBackColor = true;
            this.btnLimpiarGrafico.Click += new System.EventHandler(this.btnLimpiarGrafico_Click);
            // 
            // dgwIntervalos
            // 
            this.dgwIntervalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIntervalos.Location = new System.Drawing.Point(20, 500);
            this.dgwIntervalos.Margin = new System.Windows.Forms.Padding(4);
            this.dgwIntervalos.Name = "dgwIntervalos";
            this.dgwIntervalos.ReadOnly = true;
            this.dgwIntervalos.RowHeadersWidth = 51;
            this.dgwIntervalos.Size = new System.Drawing.Size(609, 313);
            this.dgwIntervalos.TabIndex = 30;
            // 
            // lb_chi_cuadrado
            // 
            this.lb_chi_cuadrado.AutoSize = true;
            this.lb_chi_cuadrado.Location = new System.Drawing.Point(1344, 832);
            this.lb_chi_cuadrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_chi_cuadrado.Name = "lb_chi_cuadrado";
            this.lb_chi_cuadrado.Size = new System.Drawing.Size(0, 17);
            this.lb_chi_cuadrado.TabIndex = 31;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1861, 1009);
            this.Controls.Add(this.lb_chi_cuadrado);
            this.Controls.Add(this.dgwIntervalos);
            this.Controls.Add(this.btnLimpiarGrafico);
            this.Controls.Add(this.lblSumChi);
            this.Controls.Add(this.btnLimpiar2);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwDatos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP 3 - Grupo A Carranza Exequiel Carranza Agustin Marandino Giopvanna Fransisco Z" +
    "apata";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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

