namespace TP1_SIM
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btPrueba = new System.Windows.Forms.Button();
            this.txCantNro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txCantIntervalo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.oGridFrec = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btGraficar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oGridFrec)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txCantNro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txCantIntervalo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 58);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btPrueba);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(569, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 58);
            this.panel4.TabIndex = 4;
            // 
            // btPrueba
            // 
            this.btPrueba.Location = new System.Drawing.Point(27, 18);
            this.btPrueba.Name = "btPrueba";
            this.btPrueba.Size = new System.Drawing.Size(132, 23);
            this.btPrueba.TabIndex = 0;
            this.btPrueba.Text = "Prueba de Frecuencia";
            this.btPrueba.UseVisualStyleBackColor = true;
            this.btPrueba.Click += new System.EventHandler(this.BtPrueba_Click);
            // 
            // txCantNro
            // 
            this.txCantNro.Location = new System.Drawing.Point(172, 20);
            this.txCantNro.Name = "txCantNro";
            this.txCantNro.Size = new System.Drawing.Size(62, 20);
            this.txCantNro.TabIndex = 0;
            this.txCantNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxCantNro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cant. Nro. Pseudo-aleatorios:";
            // 
            // txCantIntervalo
            // 
            this.txCantIntervalo.Location = new System.Drawing.Point(386, 20);
            this.txCantIntervalo.Name = "txCantIntervalo";
            this.txCantIntervalo.Size = new System.Drawing.Size(62, 20);
            this.txCantIntervalo.TabIndex = 1;
            this.txCantIntervalo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad Intervalos:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 50);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.oGridFrec);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 202);
            this.panel3.TabIndex = 2;
            // 
            // oGridFrec
            // 
            this.oGridFrec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oGridFrec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oGridFrec.Location = new System.Drawing.Point(0, 0);
            this.oGridFrec.Name = "oGridFrec";
            this.oGridFrec.Size = new System.Drawing.Size(740, 202);
            this.oGridFrec.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btGraficar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(596, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(144, 50);
            this.panel5.TabIndex = 0;
            // 
            // btGraficar
            // 
            this.btGraficar.Location = new System.Drawing.Point(57, 15);
            this.btGraficar.Name = "btGraficar";
            this.btGraficar.Size = new System.Drawing.Size(75, 23);
            this.btGraficar.TabIndex = 0;
            this.btGraficar.Text = "Graficar";
            this.btGraficar.UseVisualStyleBackColor = true;
            this.btGraficar.Click += new System.EventHandler(this.BtGraficar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 310);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Chi - Cuadrado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oGridFrec)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txCantIntervalo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txCantNro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView oGridFrec;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btPrueba;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btGraficar;
    }
}