namespace Tema_6___Ejercicio_6
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
            this.btnRellenar1 = new System.Windows.Forms.Button();
            this.btnRellenar2 = new System.Windows.Forms.Button();
            this.btnMostrar1 = new System.Windows.Forms.Button();
            this.btnMostrar2 = new System.Windows.Forms.Button();
            this.btnIntercalarCopia = new System.Windows.Forms.Button();
            this.btnIntercalarMover = new System.Windows.Forms.Button();
            this.btnMostrar3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRellenar1
            // 
            this.btnRellenar1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRellenar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRellenar1.Location = new System.Drawing.Point(44, 29);
            this.btnRellenar1.Name = "btnRellenar1";
            this.btnRellenar1.Size = new System.Drawing.Size(133, 60);
            this.btnRellenar1.TabIndex = 0;
            this.btnRellenar1.Text = "Rellenar lista 1";
            this.btnRellenar1.UseVisualStyleBackColor = false;
            this.btnRellenar1.Click += new System.EventHandler(this.btnRellenar1_Click);
            // 
            // btnRellenar2
            // 
            this.btnRellenar2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRellenar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRellenar2.Location = new System.Drawing.Point(44, 120);
            this.btnRellenar2.Name = "btnRellenar2";
            this.btnRellenar2.Size = new System.Drawing.Size(133, 60);
            this.btnRellenar2.TabIndex = 1;
            this.btnRellenar2.Text = "Rellenar lista 2";
            this.btnRellenar2.UseVisualStyleBackColor = false;
            this.btnRellenar2.Click += new System.EventHandler(this.btnRellenar2_Click);
            // 
            // btnMostrar1
            // 
            this.btnMostrar1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar1.Location = new System.Drawing.Point(217, 29);
            this.btnMostrar1.Name = "btnMostrar1";
            this.btnMostrar1.Size = new System.Drawing.Size(133, 60);
            this.btnMostrar1.TabIndex = 2;
            this.btnMostrar1.Text = "Mostrar lista 1";
            this.btnMostrar1.UseVisualStyleBackColor = false;
            this.btnMostrar1.Click += new System.EventHandler(this.btnMostrar1_Click);
            // 
            // btnMostrar2
            // 
            this.btnMostrar2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar2.Location = new System.Drawing.Point(217, 120);
            this.btnMostrar2.Name = "btnMostrar2";
            this.btnMostrar2.Size = new System.Drawing.Size(133, 60);
            this.btnMostrar2.TabIndex = 3;
            this.btnMostrar2.Text = "Mostrar lista 2";
            this.btnMostrar2.UseVisualStyleBackColor = false;
            this.btnMostrar2.Click += new System.EventHandler(this.btnMostrar2_Click);
            // 
            // btnIntercalarCopia
            // 
            this.btnIntercalarCopia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIntercalarCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntercalarCopia.Location = new System.Drawing.Point(397, 29);
            this.btnIntercalarCopia.Name = "btnIntercalarCopia";
            this.btnIntercalarCopia.Size = new System.Drawing.Size(133, 60);
            this.btnIntercalarCopia.TabIndex = 4;
            this.btnIntercalarCopia.Text = "Intercalar listas copiando elementos no repetidos";
            this.btnIntercalarCopia.UseVisualStyleBackColor = false;
            this.btnIntercalarCopia.Click += new System.EventHandler(this.btnIntercalarCopia_Click);
            // 
            // btnIntercalarMover
            // 
            this.btnIntercalarMover.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIntercalarMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntercalarMover.Location = new System.Drawing.Point(397, 120);
            this.btnIntercalarMover.Name = "btnIntercalarMover";
            this.btnIntercalarMover.Size = new System.Drawing.Size(133, 60);
            this.btnIntercalarMover.TabIndex = 5;
            this.btnIntercalarMover.Text = "Intercalar listas moviendo elementos no repetidos";
            this.btnIntercalarMover.UseVisualStyleBackColor = false;
            this.btnIntercalarMover.Click += new System.EventHandler(this.btnIntercalarMover_Click);
            // 
            // btnMostrar3
            // 
            this.btnMostrar3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar3.Location = new System.Drawing.Point(569, 70);
            this.btnMostrar3.Name = "btnMostrar3";
            this.btnMostrar3.Size = new System.Drawing.Size(133, 60);
            this.btnMostrar3.TabIndex = 6;
            this.btnMostrar3.Text = "Mostrar lista 3";
            this.btnMostrar3.UseVisualStyleBackColor = false;
            this.btnMostrar3.Click += new System.EventHandler(this.btnMostrar3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 214);
            this.Controls.Add(this.btnMostrar3);
            this.Controls.Add(this.btnIntercalarMover);
            this.Controls.Add(this.btnIntercalarCopia);
            this.Controls.Add(this.btnMostrar2);
            this.Controls.Add(this.btnMostrar1);
            this.Controls.Add(this.btnRellenar2);
            this.Controls.Add(this.btnRellenar1);
            this.Name = "Form1";
            this.Text = "Ejercicio 6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRellenar1;
        private System.Windows.Forms.Button btnRellenar2;
        private System.Windows.Forms.Button btnMostrar1;
        private System.Windows.Forms.Button btnMostrar2;
        private System.Windows.Forms.Button btnIntercalarCopia;
        private System.Windows.Forms.Button btnIntercalarMover;
        private System.Windows.Forms.Button btnMostrar3;
    }
}

