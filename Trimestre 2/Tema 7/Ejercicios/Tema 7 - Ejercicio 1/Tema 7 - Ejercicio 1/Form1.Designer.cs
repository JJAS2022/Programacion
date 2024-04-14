namespace Tema_7___Ejercicio_1
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntroducir
            // 
            this.btnIntroducir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIntroducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntroducir.Location = new System.Drawing.Point(60, 53);
            this.btnIntroducir.Name = "btnIntroducir";
            this.btnIntroducir.Size = new System.Drawing.Size(113, 71);
            this.btnIntroducir.TabIndex = 0;
            this.btnIntroducir.Text = "Introducir datos";
            this.btnIntroducir.UseVisualStyleBackColor = false;
            this.btnIntroducir.Click += new System.EventHandler(this.btnIntroducir_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeer.Location = new System.Drawing.Point(215, 53);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(113, 71);
            this.btnLeer.TabIndex = 1;
            this.btnLeer.Text = "Leer datos";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 188);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnIntroducir);
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntroducir;
        private System.Windows.Forms.Button btnLeer;
    }
}

