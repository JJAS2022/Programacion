namespace Notas_test
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
            this.txtPreguntas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAciertos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAciertos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFallos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotaPreguntas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotaDiez = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoContestadas = new System.Windows.Forms.TextBox();
            this.CalcularNotas = new System.Windows.Forms.Button();
            this.btnCalcularAciertosFallos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPreguntas
            // 
            this.txtPreguntas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreguntas.Location = new System.Drawing.Point(151, 40);
            this.txtPreguntas.Name = "txtPreguntas";
            this.txtPreguntas.Size = new System.Drawing.Size(67, 20);
            this.txtPreguntas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de preguntas";
            // 
            // lblAciertos
            // 
            this.lblAciertos.AutoSize = true;
            this.lblAciertos.Location = new System.Drawing.Point(334, 150);
            this.lblAciertos.Name = "lblAciertos";
            this.lblAciertos.Size = new System.Drawing.Size(0, 13);
            this.lblAciertos.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Número de aciertos";
            // 
            // txtAciertos
            // 
            this.txtAciertos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAciertos.Location = new System.Drawing.Point(376, 135);
            this.txtAciertos.Name = "txtAciertos";
            this.txtAciertos.Size = new System.Drawing.Size(67, 20);
            this.txtAciertos.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Número de fallos";
            // 
            // txtFallos
            // 
            this.txtFallos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFallos.Location = new System.Drawing.Point(151, 137);
            this.txtFallos.Name = "txtFallos";
            this.txtFallos.Size = new System.Drawing.Size(67, 20);
            this.txtFallos.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nota sobre preguntas";
            // 
            // txtNotaPreguntas
            // 
            this.txtNotaPreguntas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotaPreguntas.Location = new System.Drawing.Point(376, 40);
            this.txtNotaPreguntas.Name = "txtNotaPreguntas";
            this.txtNotaPreguntas.Size = new System.Drawing.Size(67, 20);
            this.txtNotaPreguntas.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nota sobre 10";
            // 
            // txtNotaDiez
            // 
            this.txtNotaDiez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotaDiez.Location = new System.Drawing.Point(376, 89);
            this.txtNotaDiez.Name = "txtNotaDiez";
            this.txtNotaDiez.Size = new System.Drawing.Size(67, 20);
            this.txtNotaDiez.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Preguntas no contestadas";
            // 
            // txtNoContestadas
            // 
            this.txtNoContestadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoContestadas.Location = new System.Drawing.Point(151, 87);
            this.txtNoContestadas.Name = "txtNoContestadas";
            this.txtNoContestadas.Size = new System.Drawing.Size(67, 20);
            this.txtNoContestadas.TabIndex = 24;
            // 
            // CalcularNotas
            // 
            this.CalcularNotas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CalcularNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcularNotas.Location = new System.Drawing.Point(61, 210);
            this.CalcularNotas.Name = "CalcularNotas";
            this.CalcularNotas.Size = new System.Drawing.Size(135, 61);
            this.CalcularNotas.TabIndex = 23;
            this.CalcularNotas.Text = "Calcular notas";
            this.CalcularNotas.UseVisualStyleBackColor = false;
            this.CalcularNotas.Click += new System.EventHandler(this.CalcularNotas_Click);
            // 
            // btnCalcularAciertosFallos
            // 
            this.btnCalcularAciertosFallos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalcularAciertosFallos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularAciertosFallos.Location = new System.Drawing.Point(299, 210);
            this.btnCalcularAciertosFallos.Name = "btnCalcularAciertosFallos";
            this.btnCalcularAciertosFallos.Size = new System.Drawing.Size(135, 61);
            this.btnCalcularAciertosFallos.TabIndex = 0;
            this.btnCalcularAciertosFallos.Text = "Calcular número de aciertos y fallos";
            this.btnCalcularAciertosFallos.UseVisualStyleBackColor = false;
            this.btnCalcularAciertosFallos.Click += new System.EventHandler(this.btnCalcularAciertosFallos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 317);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoContestadas);
            this.Controls.Add(this.CalcularNotas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNotaDiez);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNotaPreguntas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFallos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAciertos);
            this.Controls.Add(this.lblAciertos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPreguntas);
            this.Controls.Add(this.btnCalcularAciertosFallos);
            this.Name = "Form1";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPreguntas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAciertos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAciertos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFallos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotaPreguntas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotaDiez;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoContestadas;
        private System.Windows.Forms.Button CalcularNotas;
        private System.Windows.Forms.Button btnCalcularAciertosFallos;
    }
}

