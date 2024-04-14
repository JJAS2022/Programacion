namespace Tema_5___Ejercicio_8
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
            this.btnAccion = new System.Windows.Forms.Button();
            this.btnMostrarVector1 = new System.Windows.Forms.Button();
            this.btnMostrarVector2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRellenar
            // 
            this.btnRellenar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRellenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRellenar.Location = new System.Drawing.Point(78, 43);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(105, 76);
            this.btnRellenar.TabIndex = 0;
            this.btnRellenar.Text = "Rellenar vector";
            this.btnRellenar.UseVisualStyleBackColor = false;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // btnAccion
            // 
            this.btnAccion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccion.Location = new System.Drawing.Point(233, 43);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(105, 76);
            this.btnAccion.TabIndex = 1;
            this.btnAccion.Text = "Leer vector, cambiar repetidos por -1 y mostrar número de cambios";
            this.btnAccion.UseVisualStyleBackColor = false;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // btnMostrarVector1
            // 
            this.btnMostrarVector1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarVector1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarVector1.Location = new System.Drawing.Point(78, 138);
            this.btnMostrarVector1.Name = "btnMostrarVector1";
            this.btnMostrarVector1.Size = new System.Drawing.Size(105, 76);
            this.btnMostrarVector1.TabIndex = 2;
            this.btnMostrarVector1.Text = "Mostrar vector inicial";
            this.btnMostrarVector1.UseVisualStyleBackColor = false;
            this.btnMostrarVector1.Click += new System.EventHandler(this.btnMostrarVector1_Click);
            // 
            // btnMostrarVector2
            // 
            this.btnMostrarVector2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarVector2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarVector2.Location = new System.Drawing.Point(233, 138);
            this.btnMostrarVector2.Name = "btnMostrarVector2";
            this.btnMostrarVector2.Size = new System.Drawing.Size(105, 76);
            this.btnMostrarVector2.TabIndex = 3;
            this.btnMostrarVector2.Text = "Mostrar vector final";
            this.btnMostrarVector2.UseVisualStyleBackColor = false;
            this.btnMostrarVector2.Click += new System.EventHandler(this.btnMostrarVector2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 254);
            this.Controls.Add(this.btnMostrarVector2);
            this.Controls.Add(this.btnMostrarVector1);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.btnRellenar);
            this.Name = "Form1";
            this.Text = "Ejercicio 8";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Button btnMostrarVector1;
        private System.Windows.Forms.Button btnMostrarVector2;
    }
}

