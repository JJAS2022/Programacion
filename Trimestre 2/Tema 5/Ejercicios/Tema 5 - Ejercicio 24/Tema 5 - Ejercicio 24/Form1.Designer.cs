﻿namespace Tema_5___Ejercicio_24
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
            this.btnRellenar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRellenar
            // 
            this.btnRellenar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRellenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRellenar.Location = new System.Drawing.Point(51, 43);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(155, 76);
            this.btnRellenar.TabIndex = 0;
            this.btnRellenar.Text = "Rellenar matriz e indicar si es simétrica";
            this.btnRellenar.UseVisualStyleBackColor = false;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(242, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar matriz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 173);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRellenar);
            this.Name = "Form1";
            this.Text = "Ejercicio 24";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.Button button1;
    }
}
