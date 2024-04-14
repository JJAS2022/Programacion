namespace Tema_6___Ejercicio_4
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
            this.btnBases = new System.Windows.Forms.Button();
            this.btnMostrarBases = new System.Windows.Forms.Button();
            this.btnExponentes = new System.Windows.Forms.Button();
            this.btnMostrarExponentes = new System.Windows.Forms.Button();
            this.btnPotencias = new System.Windows.Forms.Button();
            this.btnMostrarPotencias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBases
            // 
            this.btnBases.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBases.Location = new System.Drawing.Point(47, 38);
            this.btnBases.Name = "btnBases";
            this.btnBases.Size = new System.Drawing.Size(115, 52);
            this.btnBases.TabIndex = 0;
            this.btnBases.Text = "Rellenar bases";
            this.btnBases.UseVisualStyleBackColor = false;
            this.btnBases.Click += new System.EventHandler(this.btnBases_Click);
            // 
            // btnMostrarBases
            // 
            this.btnMostrarBases.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarBases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarBases.Location = new System.Drawing.Point(47, 119);
            this.btnMostrarBases.Name = "btnMostrarBases";
            this.btnMostrarBases.Size = new System.Drawing.Size(115, 52);
            this.btnMostrarBases.TabIndex = 1;
            this.btnMostrarBases.Text = "Mostrar bases";
            this.btnMostrarBases.UseVisualStyleBackColor = false;
            this.btnMostrarBases.Click += new System.EventHandler(this.btnMostrarBases_Click);
            // 
            // btnExponentes
            // 
            this.btnExponentes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExponentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExponentes.Location = new System.Drawing.Point(200, 38);
            this.btnExponentes.Name = "btnExponentes";
            this.btnExponentes.Size = new System.Drawing.Size(115, 52);
            this.btnExponentes.TabIndex = 2;
            this.btnExponentes.Text = "Rellenar exponentes";
            this.btnExponentes.UseVisualStyleBackColor = false;
            this.btnExponentes.Click += new System.EventHandler(this.btnExponentes_Click);
            // 
            // btnMostrarExponentes
            // 
            this.btnMostrarExponentes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarExponentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarExponentes.Location = new System.Drawing.Point(200, 119);
            this.btnMostrarExponentes.Name = "btnMostrarExponentes";
            this.btnMostrarExponentes.Size = new System.Drawing.Size(115, 52);
            this.btnMostrarExponentes.TabIndex = 3;
            this.btnMostrarExponentes.Text = "Mostrar exponentes";
            this.btnMostrarExponentes.UseVisualStyleBackColor = false;
            this.btnMostrarExponentes.Click += new System.EventHandler(this.btnMostrarExponentes_Click);
            // 
            // btnPotencias
            // 
            this.btnPotencias.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPotencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotencias.Location = new System.Drawing.Point(350, 38);
            this.btnPotencias.Name = "btnPotencias";
            this.btnPotencias.Size = new System.Drawing.Size(115, 52);
            this.btnPotencias.TabIndex = 4;
            this.btnPotencias.Text = "Calcular potencias";
            this.btnPotencias.UseVisualStyleBackColor = false;
            this.btnPotencias.Click += new System.EventHandler(this.btnPotencias_Click);
            // 
            // btnMostrarPotencias
            // 
            this.btnMostrarPotencias.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarPotencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPotencias.Location = new System.Drawing.Point(350, 119);
            this.btnMostrarPotencias.Name = "btnMostrarPotencias";
            this.btnMostrarPotencias.Size = new System.Drawing.Size(115, 52);
            this.btnMostrarPotencias.TabIndex = 5;
            this.btnMostrarPotencias.Text = "Mostrar potencias";
            this.btnMostrarPotencias.UseVisualStyleBackColor = false;
            this.btnMostrarPotencias.Click += new System.EventHandler(this.btnMostrarPotencias_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 200);
            this.Controls.Add(this.btnMostrarPotencias);
            this.Controls.Add(this.btnPotencias);
            this.Controls.Add(this.btnMostrarExponentes);
            this.Controls.Add(this.btnExponentes);
            this.Controls.Add(this.btnMostrarBases);
            this.Controls.Add(this.btnBases);
            this.Name = "Form1";
            this.Text = "Ejercicio 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBases;
        private System.Windows.Forms.Button btnMostrarBases;
        private System.Windows.Forms.Button btnExponentes;
        private System.Windows.Forms.Button btnMostrarExponentes;
        private System.Windows.Forms.Button btnPotencias;
        private System.Windows.Forms.Button btnMostrarPotencias;
    }
}

