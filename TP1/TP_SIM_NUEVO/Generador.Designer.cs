
namespace TP_SIM_NUEVO
{
    partial class Generador
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
            this.gb_metodoGenerador = new System.Windows.Forms.GroupBox();
            this.rb_mult = new System.Windows.Forms.RadioButton();
            this.rb_mixto = new System.Windows.Forms.RadioButton();
            this.gb_datos = new System.Windows.Forms.GroupBox();
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
            this.btn_generar = new System.Windows.Forms.Button();
            this.dgv_numeros = new System.Windows.Forms.DataGridView();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.gb_dgv = new System.Windows.Forms.GroupBox();
            this.lbl_pagina = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_puntob = new System.Windows.Forms.Button();
            this.btn_puntoc = new System.Windows.Forms.Button();
            this.gb_metodoGenerador.SuspendLayout();
            this.gb_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).BeginInit();
            this.gb_dgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_metodoGenerador
            // 
            this.gb_metodoGenerador.Controls.Add(this.rb_mult);
            this.gb_metodoGenerador.Controls.Add(this.rb_mixto);
            this.gb_metodoGenerador.Location = new System.Drawing.Point(12, 12);
            this.gb_metodoGenerador.Name = "gb_metodoGenerador";
            this.gb_metodoGenerador.Size = new System.Drawing.Size(220, 63);
            this.gb_metodoGenerador.TabIndex = 0;
            this.gb_metodoGenerador.TabStop = false;
            this.gb_metodoGenerador.Text = "Metodo Generador";
            // 
            // rb_mult
            // 
            this.rb_mult.AutoSize = true;
            this.rb_mult.Location = new System.Drawing.Point(6, 42);
            this.rb_mult.Name = "rb_mult";
            this.rb_mult.Size = new System.Drawing.Size(190, 17);
            this.rb_mult.TabIndex = 1;
            this.rb_mult.TabStop = true;
            this.rb_mult.Text = "Metodo Congruencial Multiplicativo";
            this.rb_mult.UseVisualStyleBackColor = true;
            // 
            // rb_mixto
            // 
            this.rb_mixto.AutoSize = true;
            this.rb_mixto.Location = new System.Drawing.Point(6, 19);
            this.rb_mixto.Name = "rb_mixto";
            this.rb_mixto.Size = new System.Drawing.Size(154, 17);
            this.rb_mixto.TabIndex = 0;
            this.rb_mixto.TabStop = true;
            this.rb_mixto.Text = "Metodo Congruencial Mixto";
            this.rb_mixto.UseVisualStyleBackColor = true;
            this.rb_mixto.CheckedChanged += new System.EventHandler(this.rb_mixto_CheckedChanged);
            // 
            // gb_datos
            // 
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
            this.gb_datos.Location = new System.Drawing.Point(12, 92);
            this.gb_datos.Name = "gb_datos";
            this.gb_datos.Size = new System.Drawing.Size(220, 208);
            this.gb_datos.TabIndex = 1;
            this.gb_datos.TabStop = false;
            this.gb_datos.Text = "Datos ";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(93, 166);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(67, 20);
            this.txt_cantidad.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad de \r\nnumeros:";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(94, 128);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(66, 20);
            this.txt_c.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Constante \r\nAditiva [c]:";
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(94, 89);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(66, 20);
            this.txt_m.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modulo [m]:";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(94, 53);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(66, 20);
            this.txt_a.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
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
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(12, 317);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(220, 23);
            this.btn_generar.TabIndex = 9;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // dgv_numeros
            // 
            this.dgv_numeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_numeros.Location = new System.Drawing.Point(268, 17);
            this.dgv_numeros.Name = "dgv_numeros";
            this.dgv_numeros.Size = new System.Drawing.Size(365, 482);
            this.dgv_numeros.TabIndex = 14;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(6, 44);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(91, 22);
            this.btn_siguiente.TabIndex = 11;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(6, 19);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(91, 22);
            this.btn_anterior.TabIndex = 12;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // gb_dgv
            // 
            this.gb_dgv.Controls.Add(this.lbl_pagina);
            this.gb_dgv.Controls.Add(this.label7);
            this.gb_dgv.Controls.Add(this.label6);
            this.gb_dgv.Controls.Add(this.txt_hasta);
            this.gb_dgv.Controls.Add(this.txt_desde);
            this.gb_dgv.Controls.Add(this.btn_ultimo);
            this.gb_dgv.Controls.Add(this.btn_anterior);
            this.gb_dgv.Controls.Add(this.btn_siguiente);
            this.gb_dgv.Location = new System.Drawing.Point(268, 514);
            this.gb_dgv.Name = "gb_dgv";
            this.gb_dgv.Size = new System.Drawing.Size(354, 74);
            this.gb_dgv.TabIndex = 6;
            this.gb_dgv.TabStop = false;
            this.gb_dgv.Text = "Paginar";
            // 
            // lbl_pagina
            // 
            this.lbl_pagina.AutoSize = true;
            this.lbl_pagina.Location = new System.Drawing.Point(247, 11);
            this.lbl_pagina.Name = "lbl_pagina";
            this.lbl_pagina.Size = new System.Drawing.Size(11, 13);
            this.lbl_pagina.TabIndex = 12;
            this.lbl_pagina.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Desde:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad:";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(157, 47);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(66, 20);
            this.txt_hasta.TabIndex = 8;
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(157, 21);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(66, 20);
            this.txt_desde.TabIndex = 7;
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.Location = new System.Drawing.Point(250, 44);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(91, 22);
            this.btn_ultimo.TabIndex = 13;
            this.btn_ultimo.Text = "Ultimo";
            this.btn_ultimo.UseVisualStyleBackColor = true;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(12, 346);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(220, 22);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(12, 374);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(220, 22);
            this.btn_salir.TabIndex = 15;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_puntob
            // 
            this.btn_puntob.Location = new System.Drawing.Point(12, 533);
            this.btn_puntob.Name = "btn_puntob";
            this.btn_puntob.Size = new System.Drawing.Size(220, 22);
            this.btn_puntob.TabIndex = 16;
            this.btn_puntob.Text = "Punto B";
            this.btn_puntob.UseVisualStyleBackColor = true;
            this.btn_puntob.Click += new System.EventHandler(this.btn_graficar_Click);
            // 
            // btn_puntoc
            // 
            this.btn_puntoc.Location = new System.Drawing.Point(12, 561);
            this.btn_puntoc.Name = "btn_puntoc";
            this.btn_puntoc.Size = new System.Drawing.Size(220, 22);
            this.btn_puntoc.TabIndex = 17;
            this.btn_puntoc.Text = "Punto C";
            this.btn_puntoc.UseVisualStyleBackColor = true;
            this.btn_puntoc.Click += new System.EventHandler(this.btn_puntoc_Click);
            // 
            // Generador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 608);
            this.Controls.Add(this.btn_puntoc);
            this.Controls.Add(this.btn_puntob);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.gb_dgv);
            this.Controls.Add(this.dgv_numeros);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.gb_datos);
            this.Controls.Add(this.gb_metodoGenerador);
            this.Name = "Generador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador";
            this.gb_metodoGenerador.ResumeLayout(false);
            this.gb_metodoGenerador.PerformLayout();
            this.gb_datos.ResumeLayout(false);
            this.gb_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).EndInit();
            this.gb_dgv.ResumeLayout(false);
            this.gb_dgv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_metodoGenerador;
        private System.Windows.Forms.RadioButton rb_mult;
        private System.Windows.Forms.RadioButton rb_mixto;
        private System.Windows.Forms.GroupBox gb_datos;
        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_semilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.DataGridView dgv_numeros;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.GroupBox gb_dgv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label lbl_pagina;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_puntob;
        private System.Windows.Forms.Button btn_puntoc;
    }
}