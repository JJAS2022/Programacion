namespace Ejercicio_1___Tema_8
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
            this.btnCrearCirculo = new System.Windows.Forms.Button();
            this.btnCrearCuadrado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearCirculo
            // 
            this.btnCrearCirculo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCrearCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCirculo.Location = new System.Drawing.Point(45, 49);
            this.btnCrearCirculo.Name = "btnCrearCirculo";
            this.btnCrearCirculo.Size = new System.Drawing.Size(115, 112);
            this.btnCrearCirculo.TabIndex = 0;
            this.btnCrearCirculo.Text = "Crear y mostrar un objeto de tipo Círculo";
            this.btnCrearCirculo.UseVisualStyleBackColor = false;
            this.btnCrearCirculo.Click += new System.EventHandler(this.btnCrearCirculo_Click);
            // 
            // btnCrearCuadrado
            // 
            this.btnCrearCuadrado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCrearCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuadrado.Location = new System.Drawing.Point(227, 49);
            this.btnCrearCuadrado.Name = "btnCrearCuadrado";
            this.btnCrearCuadrado.Size = new System.Drawing.Size(115, 112);
            this.btnCrearCuadrado.TabIndex = 1;
            this.btnCrearCuadrado.Text = "Crear y mostrar un objeto de tipo Cuadrado";
            this.btnCrearCuadrado.UseVisualStyleBackColor = false;
            this.btnCrearCuadrado.Click += new System.EventHandler(this.btnCrearCuadrado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 214);
            this.Controls.Add(this.btnCrearCuadrado);
            this.Controls.Add(this.btnCrearCirculo);
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCirculo;
        private System.Windows.Forms.Button btnCrearCuadrado;
    }
}

