namespace Tema_5___Ejercicio_17
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMenorMayor = new System.Windows.Forms.Button();
            this.btnMayorMenor = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRellenar
            // 
            this.btnRellenar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRellenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRellenar.Location = new System.Drawing.Point(72, 40);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(193, 26);
            this.btnRellenar.TabIndex = 0;
            this.btnRellenar.Text = "Rellenar vector";
            this.btnRellenar.UseVisualStyleBackColor = false;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(72, 200);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 61);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar posición en la que se encuentra el elemento";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMenorMayor
            // 
            this.btnMenorMayor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMenorMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenorMayor.Location = new System.Drawing.Point(72, 93);
            this.btnMenorMayor.Name = "btnMenorMayor";
            this.btnMenorMayor.Size = new System.Drawing.Size(193, 26);
            this.btnMenorMayor.TabIndex = 2;
            this.btnMenorMayor.Text = "Ordenar vector de menor a mayor";
            this.btnMenorMayor.UseVisualStyleBackColor = false;
            this.btnMenorMayor.Click += new System.EventHandler(this.btnMenorMayor_Click);
            // 
            // btnMayorMenor
            // 
            this.btnMayorMenor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMayorMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMayorMenor.Location = new System.Drawing.Point(72, 147);
            this.btnMayorMenor.Name = "btnMayorMenor";
            this.btnMayorMenor.Size = new System.Drawing.Size(193, 26);
            this.btnMayorMenor.TabIndex = 3;
            this.btnMayorMenor.Text = "Ordenar vector de mayor a menor";
            this.btnMayorMenor.UseVisualStyleBackColor = false;
            this.btnMayorMenor.Click += new System.EventHandler(this.btnMayorMenor_Click);
            // 
            // txtNum
            // 
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum.Location = new System.Drawing.Point(195, 222);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(70, 20);
            this.txtNum.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 295);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnMayorMenor);
            this.Controls.Add(this.btnMenorMayor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRellenar);
            this.Name = "Form1";
            this.Text = "Ejercicio 17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMenorMayor;
        private System.Windows.Forms.Button btnMayorMenor;
        private System.Windows.Forms.TextBox txtNum;
    }
}

