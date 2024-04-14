namespace Tema_5___Ejercicio_9
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
            this.btnInvertir = new System.Windows.Forms.Button();
            this.btnMostrarInicial = new System.Windows.Forms.Button();
            this.btnMostrarInvertido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRellenar
            // 
            this.btnRellenar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRellenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRellenar.Location = new System.Drawing.Point(74, 69);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(116, 66);
            this.btnRellenar.TabIndex = 0;
            this.btnRellenar.Text = "Rellenar vector";
            this.btnRellenar.UseVisualStyleBackColor = false;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // btnInvertir
            // 
            this.btnInvertir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvertir.Location = new System.Drawing.Point(270, 69);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(116, 66);
            this.btnInvertir.TabIndex = 1;
            this.btnInvertir.Text = "Invertir vector";
            this.btnInvertir.UseVisualStyleBackColor = false;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // btnMostrarInicial
            // 
            this.btnMostrarInicial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarInicial.Location = new System.Drawing.Point(74, 167);
            this.btnMostrarInicial.Name = "btnMostrarInicial";
            this.btnMostrarInicial.Size = new System.Drawing.Size(116, 66);
            this.btnMostrarInicial.TabIndex = 2;
            this.btnMostrarInicial.Text = "Mostrar vector inicial";
            this.btnMostrarInicial.UseVisualStyleBackColor = false;
            this.btnMostrarInicial.Click += new System.EventHandler(this.btnMostrarInicial_Click);
            // 
            // btnMostrarInvertido
            // 
            this.btnMostrarInvertido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarInvertido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarInvertido.Location = new System.Drawing.Point(270, 167);
            this.btnMostrarInvertido.Name = "btnMostrarInvertido";
            this.btnMostrarInvertido.Size = new System.Drawing.Size(116, 66);
            this.btnMostrarInvertido.TabIndex = 3;
            this.btnMostrarInvertido.Text = "Mostrar vector invertido";
            this.btnMostrarInvertido.UseVisualStyleBackColor = false;
            this.btnMostrarInvertido.Click += new System.EventHandler(this.btnMostrarInvertido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 277);
            this.Controls.Add(this.btnMostrarInvertido);
            this.Controls.Add(this.btnMostrarInicial);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.btnRellenar);
            this.Name = "Form1";
            this.Text = "Ejercicio 9";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Button btnMostrarInicial;
        private System.Windows.Forms.Button btnMostrarInvertido;
    }
}

