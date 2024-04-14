namespace Tema_5___Ejercicio_10
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
            this.btnMostrarInicial = new System.Windows.Forms.Button();
            this.btnMostrarRotado = new System.Windows.Forms.Button();
            this.btnRotar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRellenar
            // 
            this.btnRellenar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRellenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRellenar.Location = new System.Drawing.Point(85, 45);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(112, 68);
            this.btnRellenar.TabIndex = 0;
            this.btnRellenar.Text = "Rellenar vector";
            this.btnRellenar.UseVisualStyleBackColor = false;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // btnMostrarInicial
            // 
            this.btnMostrarInicial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarInicial.Location = new System.Drawing.Point(85, 152);
            this.btnMostrarInicial.Name = "btnMostrarInicial";
            this.btnMostrarInicial.Size = new System.Drawing.Size(112, 68);
            this.btnMostrarInicial.TabIndex = 1;
            this.btnMostrarInicial.Text = "Mostrar vector inicial";
            this.btnMostrarInicial.UseVisualStyleBackColor = false;
            this.btnMostrarInicial.Click += new System.EventHandler(this.btnMostrarInicial_Click);
            // 
            // btnMostrarRotado
            // 
            this.btnMostrarRotado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarRotado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarRotado.Location = new System.Drawing.Point(270, 152);
            this.btnMostrarRotado.Name = "btnMostrarRotado";
            this.btnMostrarRotado.Size = new System.Drawing.Size(112, 68);
            this.btnMostrarRotado.TabIndex = 2;
            this.btnMostrarRotado.Text = "Mostrar vector rotado";
            this.btnMostrarRotado.UseVisualStyleBackColor = false;
            this.btnMostrarRotado.Click += new System.EventHandler(this.btnMostrarRotado_Click);
            // 
            // btnRotar
            // 
            this.btnRotar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotar.Location = new System.Drawing.Point(270, 45);
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(112, 68);
            this.btnRotar.TabIndex = 3;
            this.btnRotar.Text = "Rotar vector 1 posición a la derecha";
            this.btnRotar.UseVisualStyleBackColor = false;
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 270);
            this.Controls.Add(this.btnRotar);
            this.Controls.Add(this.btnMostrarRotado);
            this.Controls.Add(this.btnMostrarInicial);
            this.Controls.Add(this.btnRellenar);
            this.Name = "Form1";
            this.Text = "Ejercicio 10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.Button btnMostrarInicial;
        private System.Windows.Forms.Button btnMostrarRotado;
        private System.Windows.Forms.Button btnRotar;
    }
}

