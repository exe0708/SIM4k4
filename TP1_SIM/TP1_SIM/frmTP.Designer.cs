namespace TP1_SIM
{
    partial class frmTP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_lenguaje = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chMultiplicativo = new System.Windows.Forms.CheckBox();
            this.chLineal = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btGenerar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txRaiz = new System.Windows.Forms.TextBox();
            this.lbRaiz = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btChi = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.plContenedor = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.oGrilla = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.plContenedor.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 70);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(156, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(274, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Constantes:";
            // 
            // txM
            // 
            this.txM.Location = new System.Drawing.Point(210, 24);
            this.txM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txM.Name = "txM";
            this.txM.Size = new System.Drawing.Size(56, 23);
            this.txM.TabIndex = 2;
            this.txM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxM_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "M:";
            // 
            // txC
            // 
            this.txC.Location = new System.Drawing.Point(120, 24);
            this.txC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txC.Name = "txC";
            this.txC.Size = new System.Drawing.Size(53, 23);
            this.txC.TabIndex = 1;
            this.txC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxC_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "C:";
            // 
            // txA
            // 
            this.txA.Location = new System.Drawing.Point(34, 24);
            this.txA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txA.Name = "txA";
            this.txA.Size = new System.Drawing.Size(52, 23);
            this.txA.TabIndex = 0;
            this.txA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "A:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cb_lenguaje);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.chMultiplicativo);
            this.panel4.Controls.Add(this.chLineal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(430, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 70);
            this.panel4.TabIndex = 0;
            // 
            // cb_lenguaje
            // 
            this.cb_lenguaje.AutoSize = true;
            this.cb_lenguaje.Location = new System.Drawing.Point(139, 20);
            this.cb_lenguaje.Name = "cb_lenguaje";
            this.cb_lenguaje.Size = new System.Drawing.Size(74, 19);
            this.cb_lenguaje.TabIndex = 17;
            this.cb_lenguaje.Text = "Aleatorio";
            this.cb_lenguaje.UseVisualStyleBackColor = true;
            this.cb_lenguaje.CheckedChanged += new System.EventHandler(this.cb_lenguaje_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Metodo:";
            // 
            // chMultiplicativo
            // 
            this.chMultiplicativo.AutoSize = true;
            this.chMultiplicativo.Location = new System.Drawing.Point(8, 45);
            this.chMultiplicativo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chMultiplicativo.Name = "chMultiplicativo";
            this.chMultiplicativo.Size = new System.Drawing.Size(165, 19);
            this.chMultiplicativo.TabIndex = 1;
            this.chMultiplicativo.Text = "Congruente Multiplicativo";
            this.chMultiplicativo.UseVisualStyleBackColor = true;
            this.chMultiplicativo.CheckedChanged += new System.EventHandler(this.ChMultiplicativo_CheckedChanged);
            // 
            // chLineal
            // 
            this.chLineal.AutoSize = true;
            this.chLineal.Checked = true;
            this.chLineal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chLineal.Location = new System.Drawing.Point(8, 20);
            this.chLineal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chLineal.Name = "chLineal";
            this.chLineal.Size = new System.Drawing.Size(123, 19);
            this.chLineal.TabIndex = 0;
            this.chLineal.Text = "Congruente Lineal";
            this.chLineal.UseVisualStyleBackColor = true;
            this.chLineal.CheckedChanged += new System.EventHandler(this.chLineal_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btGenerar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(681, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 70);
            this.panel3.TabIndex = 4;
            // 
            // btGenerar
            // 
            this.btGenerar.Location = new System.Drawing.Point(15, 20);
            this.btGenerar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(88, 27);
            this.btGenerar.TabIndex = 0;
            this.btGenerar.Text = "Generar";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.BtGenerar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txRaiz);
            this.panel2.Controls.Add(this.lbRaiz);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 70);
            this.panel2.TabIndex = 3;
            // 
            // txRaiz
            // 
            this.txRaiz.Location = new System.Drawing.Point(57, 23);
            this.txRaiz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txRaiz.Name = "txRaiz";
            this.txRaiz.Size = new System.Drawing.Size(82, 23);
            this.txRaiz.TabIndex = 0;
            this.txRaiz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // lbRaiz
            // 
            this.lbRaiz.AutoSize = true;
            this.lbRaiz.Location = new System.Drawing.Point(14, 27);
            this.lbRaiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRaiz.Name = "lbRaiz";
            this.lbRaiz.Size = new System.Drawing.Size(31, 15);
            this.lbRaiz.TabIndex = 2;
            this.lbRaiz.Text = "Raiz:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btChi);
            this.panel5.Controls.Add(this.btnLimpiar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 361);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(798, 38);
            this.panel5.TabIndex = 1;
            // 
            // btChi
            // 
            this.btChi.Location = new System.Drawing.Point(682, 6);
            this.btChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btChi.Name = "btChi";
            this.btChi.Size = new System.Drawing.Size(103, 27);
            this.btChi.TabIndex = 2;
            this.btChi.Text = "Chi-Cuadrado";
            this.btChi.UseVisualStyleBackColor = true;
            this.btChi.Click += new System.EventHandler(this.BtChi_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(13, 6);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 27);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // plContenedor
            // 
            this.plContenedor.Controls.Add(this.richTextBox1);
            this.plContenedor.Controls.Add(this.panel6);
            this.plContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContenedor.Location = new System.Drawing.Point(0, 70);
            this.plContenedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plContenedor.Name = "plContenedor";
            this.plContenedor.Size = new System.Drawing.Size(798, 291);
            this.plContenedor.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(588, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(210, 291);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Integrantes:\nChabodano Jorgelina 54729\nCarranza Exequiel 60848\nMarandino, Giovann" +
    "a 79110\nMigotti, Franco 60546\nMoyano Paz Gonzalo 64542\nZapata, Francisco Matías " +
    "73315";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.oGrilla);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(588, 291);
            this.panel6.TabIndex = 0;
            // 
            // oGrilla
            // 
            this.oGrilla.AllowUserToAddRows = false;
            this.oGrilla.AllowUserToDeleteRows = false;
            this.oGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oGrilla.Location = new System.Drawing.Point(0, 0);
            this.oGrilla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.oGrilla.Name = "oGrilla";
            this.oGrilla.ReadOnly = true;
            this.oGrilla.Size = new System.Drawing.Size(588, 291);
            this.oGrilla.TabIndex = 1;
            // 
            // frmTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 399);
            this.Controls.Add(this.plContenedor);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP1 - Grupo I";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.plContenedor.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txRaiz;
        private System.Windows.Forms.Label lbRaiz;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chMultiplicativo;
        private System.Windows.Forms.CheckBox chLineal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel plContenedor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btChi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView oGrilla;
        private System.Windows.Forms.CheckBox cb_lenguaje;
    }
}

