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
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnMostrarCírculos = new System.Windows.Forms.Button();
            this.btnMostrarCuadrados = new System.Windows.Forms.Button();
            this.btnCrearCirculo = new System.Windows.Forms.Button();
            this.btnCrearCuadrado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Location = new System.Drawing.Point(267, 54);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(167, 76);
            this.btnMostrarTodos.TabIndex = 2;
            this.btnMostrarTodos.Text = "Mostrar todas los objetos de tipo Figura";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnMostrarCírculos
            // 
            this.btnMostrarCírculos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarCírculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarCírculos.Location = new System.Drawing.Point(267, 169);
            this.btnMostrarCírculos.Name = "btnMostrarCírculos";
            this.btnMostrarCírculos.Size = new System.Drawing.Size(167, 76);
            this.btnMostrarCírculos.TabIndex = 3;
            this.btnMostrarCírculos.Text = "Mostrar todas los objetos de tipo Círculo";
            this.btnMostrarCírculos.UseVisualStyleBackColor = false;
            this.btnMostrarCírculos.Click += new System.EventHandler(this.btnMostrarCírculos_Click);
            // 
            // btnMostrarCuadrados
            // 
            this.btnMostrarCuadrados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarCuadrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarCuadrados.Location = new System.Drawing.Point(267, 281);
            this.btnMostrarCuadrados.Name = "btnMostrarCuadrados";
            this.btnMostrarCuadrados.Size = new System.Drawing.Size(167, 76);
            this.btnMostrarCuadrados.TabIndex = 4;
            this.btnMostrarCuadrados.Text = "Mostrar todas los objetos de tipo Cuadrado";
            this.btnMostrarCuadrados.UseVisualStyleBackColor = false;
            this.btnMostrarCuadrados.Click += new System.EventHandler(this.btnMostrarCuadrados_Click);
            // 
            // btnCrearCirculo
            // 
            this.btnCrearCirculo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCrearCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCirculo.Location = new System.Drawing.Point(49, 79);
            this.btnCrearCirculo.Name = "btnCrearCirculo";
            this.btnCrearCirculo.Size = new System.Drawing.Size(147, 112);
            this.btnCrearCirculo.TabIndex = 5;
            this.btnCrearCirculo.Text = "Crear objeto de tipo Círculo";
            this.btnCrearCirculo.UseVisualStyleBackColor = false;
            this.btnCrearCirculo.Click += new System.EventHandler(this.btnCrearCirculo_Click);
            // 
            // btnCrearCuadrado
            // 
            this.btnCrearCuadrado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCrearCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuadrado.Location = new System.Drawing.Point(49, 228);
            this.btnCrearCuadrado.Name = "btnCrearCuadrado";
            this.btnCrearCuadrado.Size = new System.Drawing.Size(147, 112);
            this.btnCrearCuadrado.TabIndex = 6;
            this.btnCrearCuadrado.Text = "Crear objeto de tipo Cuadrado";
            this.btnCrearCuadrado.UseVisualStyleBackColor = false;
            this.btnCrearCuadrado.Click += new System.EventHandler(this.btnCrearCuadrado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 412);
            this.Controls.Add(this.btnCrearCuadrado);
            this.Controls.Add(this.btnCrearCirculo);
            this.Controls.Add(this.btnMostrarCuadrados);
            this.Controls.Add(this.btnMostrarCírculos);
            this.Controls.Add(this.btnMostrarTodos);
            this.Name = "Form1";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnMostrarCírculos;
        private System.Windows.Forms.Button btnMostrarCuadrados;
        private System.Windows.Forms.Button btnCrearCirculo;
        private System.Windows.Forms.Button btnCrearCuadrado;
    }
}

