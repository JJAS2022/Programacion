namespace Tema_6___Ejercicio_7
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
            this.btnIntroducir = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntroducir
            // 
            this.btnIntroducir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIntroducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntroducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroducir.Location = new System.Drawing.Point(58, 51);
            this.btnIntroducir.Name = "btnIntroducir";
            this.btnIntroducir.Size = new System.Drawing.Size(121, 80);
            this.btnIntroducir.TabIndex = 0;
            this.btnIntroducir.Text = "Introducir palabra";
            this.btnIntroducir.UseVisualStyleBackColor = false;
            this.btnIntroducir.Click += new System.EventHandler(this.btnIntroducir_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(247, 51);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(121, 80);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Comprobar listado de palabras";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 192);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnIntroducir);
            this.Name = "Form1";
            this.Text = "Ejercicio 7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntroducir;
        private System.Windows.Forms.Button btnMostrar;
    }
}

