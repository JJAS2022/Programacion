namespace Ejercicio_3___Tema_8
{
    partial class FormInicial
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
            this.btnMostrarTodas = new System.Windows.Forms.Button();
            this.btnMostrarCirculos = new System.Windows.Forms.Button();
            this.btnMostrarCuadrados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearCirculo
            // 
            this.btnCrearCirculo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCrearCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCirculo.Location = new System.Drawing.Point(55, 60);
            this.btnCrearCirculo.Name = "btnCrearCirculo";
            this.btnCrearCirculo.Size = new System.Drawing.Size(104, 89);
            this.btnCrearCirculo.TabIndex = 0;
            this.btnCrearCirculo.Text = "Crear un nuevo círculo";
            this.btnCrearCirculo.UseVisualStyleBackColor = false;
            this.btnCrearCirculo.Click += new System.EventHandler(this.btnCrearCirculo_Click);
            // 
            // btnCrearCuadrado
            // 
            this.btnCrearCuadrado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCrearCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuadrado.Location = new System.Drawing.Point(55, 189);
            this.btnCrearCuadrado.Name = "btnCrearCuadrado";
            this.btnCrearCuadrado.Size = new System.Drawing.Size(104, 89);
            this.btnCrearCuadrado.TabIndex = 1;
            this.btnCrearCuadrado.Text = "Crear un nuevo cuadrado";
            this.btnCrearCuadrado.UseVisualStyleBackColor = false;
            this.btnCrearCuadrado.Click += new System.EventHandler(this.btnCrearCuadrado_Click);
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodas.Location = new System.Drawing.Point(226, 60);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(163, 48);
            this.btnMostrarTodas.TabIndex = 2;
            this.btnMostrarTodas.Text = "Mostrar todas las figuras";
            this.btnMostrarTodas.UseVisualStyleBackColor = false;
            this.btnMostrarTodas.Click += new System.EventHandler(this.btnMostrarTodas_Click);
            // 
            // btnMostrarCirculos
            // 
            this.btnMostrarCirculos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarCirculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarCirculos.Location = new System.Drawing.Point(226, 145);
            this.btnMostrarCirculos.Name = "btnMostrarCirculos";
            this.btnMostrarCirculos.Size = new System.Drawing.Size(163, 48);
            this.btnMostrarCirculos.TabIndex = 3;
            this.btnMostrarCirculos.Text = "Mostrar los círculos";
            this.btnMostrarCirculos.UseVisualStyleBackColor = false;
            this.btnMostrarCirculos.Click += new System.EventHandler(this.btnMostrarCirculos_Click);
            // 
            // btnMostrarCuadrados
            // 
            this.btnMostrarCuadrados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarCuadrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarCuadrados.Location = new System.Drawing.Point(226, 230);
            this.btnMostrarCuadrados.Name = "btnMostrarCuadrados";
            this.btnMostrarCuadrados.Size = new System.Drawing.Size(163, 48);
            this.btnMostrarCuadrados.TabIndex = 4;
            this.btnMostrarCuadrados.Text = "Mostrar los cuadrados";
            this.btnMostrarCuadrados.UseVisualStyleBackColor = false;
            this.btnMostrarCuadrados.Click += new System.EventHandler(this.btnMostrarCuadrados_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 347);
            this.Controls.Add(this.btnMostrarCuadrados);
            this.Controls.Add(this.btnMostrarCirculos);
            this.Controls.Add(this.btnMostrarTodas);
            this.Controls.Add(this.btnCrearCuadrado);
            this.Controls.Add(this.btnCrearCirculo);
            this.Name = "FormInicial";
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCirculo;
        private System.Windows.Forms.Button btnCrearCuadrado;
        private System.Windows.Forms.Button btnMostrarTodas;
        private System.Windows.Forms.Button btnMostrarCirculos;
        private System.Windows.Forms.Button btnMostrarCuadrados;
    }
}

