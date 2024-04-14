namespace Tema_6___Ejercicio_2
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
            this.btn_Rellenar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Copiar = new System.Windows.Forms.Button();
            this.btn_Mover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Rellenar
            // 
            this.btn_Rellenar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Rellenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rellenar.Location = new System.Drawing.Point(59, 39);
            this.btn_Rellenar.Name = "btn_Rellenar";
            this.btn_Rellenar.Size = new System.Drawing.Size(113, 49);
            this.btn_Rellenar.TabIndex = 0;
            this.btn_Rellenar.Text = "Rellenar lista";
            this.btn_Rellenar.UseVisualStyleBackColor = false;
            this.btn_Rellenar.Click += new System.EventHandler(this.btn_Rellenar_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mostrar.Location = new System.Drawing.Point(59, 120);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(113, 49);
            this.btn_Mostrar.TabIndex = 1;
            this.btn_Mostrar.Text = "Mostrar lista";
            this.btn_Mostrar.UseVisualStyleBackColor = false;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_Copiar
            // 
            this.btn_Copiar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Copiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Copiar.Location = new System.Drawing.Point(229, 39);
            this.btn_Copiar.Name = "btn_Copiar";
            this.btn_Copiar.Size = new System.Drawing.Size(113, 49);
            this.btn_Copiar.TabIndex = 2;
            this.btn_Copiar.Text = "Copiar pares";
            this.btn_Copiar.UseVisualStyleBackColor = false;
            this.btn_Copiar.Click += new System.EventHandler(this.btn_Copiar_Click);
            // 
            // btn_Mover
            // 
            this.btn_Mover.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Mover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mover.Location = new System.Drawing.Point(229, 120);
            this.btn_Mover.Name = "btn_Mover";
            this.btn_Mover.Size = new System.Drawing.Size(113, 49);
            this.btn_Mover.TabIndex = 3;
            this.btn_Mover.Text = "Mover pares";
            this.btn_Mover.UseVisualStyleBackColor = false;
            this.btn_Mover.Click += new System.EventHandler(this.btn_Mover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 205);
            this.Controls.Add(this.btn_Mover);
            this.Controls.Add(this.btn_Copiar);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.btn_Rellenar);
            this.Name = "Form1";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Rellenar;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_Copiar;
        private System.Windows.Forms.Button btn_Mover;
    }
}

