using System.Collections.Generic;

namespace TP_4
{
    partial class Form1
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
            this.gb_datos = new System.Windows.Forms.GroupBox();
            this.btn_simular = new System.Windows.Forms.Button();
            this.txt_minutos = new System.Windows.Forms.TextBox();
            this.lb_semanas = new System.Windows.Forms.Label();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.lb_ventas = new System.Windows.Forms.Label();
            this.lb_cantObreros = new System.Windows.Forms.Label();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.dg_simulacion = new System.Windows.Forms.DataGridView();
            this.gb_eventos = new System.Windows.Forms.GroupBox();
            this.dg_eventos = new System.Windows.Forms.DataGridView();
            this.gb_objetos = new System.Windows.Forms.GroupBox();
            this.dg_objetos = new System.Windows.Forms.DataGridView();
            this.gb_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_simulacion)).BeginInit();
            this.gb_eventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_eventos)).BeginInit();
            this.gb_objetos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_objetos)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_datos
            // 
            this.gb_datos.Controls.Add(this.btn_simular);
            this.gb_datos.Controls.Add(this.txt_minutos);
            this.gb_datos.Controls.Add(this.lb_semanas);
            this.gb_datos.Controls.Add(this.txt_hasta);
            this.gb_datos.Controls.Add(this.lb_ventas);
            this.gb_datos.Controls.Add(this.lb_cantObreros);
            this.gb_datos.Controls.Add(this.txt_desde);
            this.gb_datos.Location = new System.Drawing.Point(12, 12);
            this.gb_datos.Name = "gb_datos";
            this.gb_datos.Size = new System.Drawing.Size(335, 114);
            this.gb_datos.TabIndex = 2;
            this.gb_datos.TabStop = false;
            this.gb_datos.Text = "Datos";
            // 
            // btn_simular
            // 
            this.btn_simular.Location = new System.Drawing.Point(152, 19);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(85, 27);
            this.btn_simular.TabIndex = 7;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // txt_minutos
            // 
            this.txt_minutos.Location = new System.Drawing.Point(53, 23);
            this.txt_minutos.Name = "txt_minutos";
            this.txt_minutos.Size = new System.Drawing.Size(78, 20);
            this.txt_minutos.TabIndex = 16;
            // 
            // lb_semanas
            // 
            this.lb_semanas.AutoSize = true;
            this.lb_semanas.Location = new System.Drawing.Point(6, 26);
            this.lb_semanas.Name = "lb_semanas";
            this.lb_semanas.Size = new System.Drawing.Size(47, 13);
            this.lb_semanas.TabIndex = 15;
            this.lb_semanas.Text = "Minutos:";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(53, 76);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(78, 20);
            this.txt_hasta.TabIndex = 9;
            // 
            // lb_ventas
            // 
            this.lb_ventas.AutoSize = true;
            this.lb_ventas.Location = new System.Drawing.Point(2, 79);
            this.lb_ventas.Name = "lb_ventas";
            this.lb_ventas.Size = new System.Drawing.Size(55, 13);
            this.lb_ventas.TabIndex = 12;
            this.lb_ventas.Text = "Cantidad: ";
            // 
            // lb_cantObreros
            // 
            this.lb_cantObreros.AutoSize = true;
            this.lb_cantObreros.Location = new System.Drawing.Point(6, 53);
            this.lb_cantObreros.Name = "lb_cantObreros";
            this.lb_cantObreros.Size = new System.Drawing.Size(41, 13);
            this.lb_cantObreros.TabIndex = 1;
            this.lb_cantObreros.Text = "Desde:";
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(53, 49);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(78, 20);
            this.txt_desde.TabIndex = 0;
            // 
            // dg_simulacion
            // 
            this.dg_simulacion.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dg_simulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_simulacion.Location = new System.Drawing.Point(12, 228);
            this.dg_simulacion.Name = "dg_simulacion";
            this.dg_simulacion.ReadOnly = true;
            this.dg_simulacion.Size = new System.Drawing.Size(1159, 387);
            this.dg_simulacion.TabIndex = 5;
            // 
            // gb_eventos
            // 
            this.gb_eventos.Controls.Add(this.dg_eventos);
            this.gb_eventos.Location = new System.Drawing.Point(739, 12);
            this.gb_eventos.Name = "gb_eventos";
            this.gb_eventos.Size = new System.Drawing.Size(432, 182);
            this.gb_eventos.TabIndex = 7;
            this.gb_eventos.TabStop = false;
            this.gb_eventos.Text = "Eventos";
            // 
            // dg_eventos
            // 
            this.dg_eventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_eventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_eventos.Location = new System.Drawing.Point(3, 16);
            this.dg_eventos.Name = "dg_eventos";
            this.dg_eventos.ReadOnly = true;
            this.dg_eventos.Size = new System.Drawing.Size(426, 163);
            this.dg_eventos.TabIndex = 9;
            // 
            // gb_objetos
            // 
            this.gb_objetos.Controls.Add(this.dg_objetos);
            this.gb_objetos.Location = new System.Drawing.Point(363, 12);
            this.gb_objetos.Name = "gb_objetos";
            this.gb_objetos.Size = new System.Drawing.Size(373, 182);
            this.gb_objetos.TabIndex = 3;
            this.gb_objetos.TabStop = false;
            this.gb_objetos.Text = "Objetos";
            // 
            // dg_objetos
            // 
            this.dg_objetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_objetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_objetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_objetos.Location = new System.Drawing.Point(3, 16);
            this.dg_objetos.Name = "dg_objetos";
            this.dg_objetos.ReadOnly = true;
            this.dg_objetos.Size = new System.Drawing.Size(367, 163);
            this.dg_objetos.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 644);
            this.Controls.Add(this.gb_eventos);
            this.Controls.Add(this.dg_simulacion);
            this.Controls.Add(this.gb_objetos);
            this.Controls.Add(this.gb_datos);
            this.Name = "Form1";
            this.Text = "TP 4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gb_datos.ResumeLayout(false);
            this.gb_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_simulacion)).EndInit();
            this.gb_eventos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_eventos)).EndInit();
            this.gb_objetos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_objetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_datos;
        private System.Windows.Forms.TextBox txt_minutos;
        private System.Windows.Forms.Label lb_semanas;
        private System.Windows.Forms.DataGridView dg_simulacion;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.Label lb_ventas;
        private System.Windows.Forms.Label lb_cantObreros;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.GroupBox gb_eventos;
        private System.Windows.Forms.DataGridView dg_eventos;
        private System.Windows.Forms.GroupBox gb_objetos;
        private System.Windows.Forms.DataGridView dg_objetos;
    }
}

