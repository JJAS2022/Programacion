namespace Tema_5___Ejercicio_11
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
            this.btnRotar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRellenar
            // 
            this.btnRellenar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRellenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRellenar.Location = new System.Drawing.Point(65, 65);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(136, 104);
            this.btnRellenar.TabIndex = 0;
            this.btnRellenar.Text = "Rellenar vector";
            this.btnRellenar.UseVisualStyleBackColor = false;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // btnRotar
            // 
            this.btnRotar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotar.Location = new System.Drawing.Point(293, 65);
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(136, 104);
            this.btnRotar.TabIndex = 1;
            this.btnRotar.Text = "Rotar vector 1 posición y mostrar rotado";
            this.btnRotar.UseVisualStyleBackColor = false;
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 242);
            this.Controls.Add(this.btnRotar);
            this.Controls.Add(this.btnRellenar);
            this.Name = "Form1";
            this.Text = "Ejercicio 11";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.Button btnRotar;
    }
}

