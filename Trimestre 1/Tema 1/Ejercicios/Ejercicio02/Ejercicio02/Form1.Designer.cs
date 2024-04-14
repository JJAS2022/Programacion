namespace Ejercicio02
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
            this.Title = new System.Windows.Forms.Label();
            this.TBox = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(159, 59);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(155, 19);
            this.Title.TabIndex = 0;
            this.Title.Text = "Mi Primer Formulario";
            this.Title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TBox
            // 
            this.TBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBox.Location = new System.Drawing.Point(119, 106);
            this.TBox.Name = "TBox";
            this.TBox.Size = new System.Drawing.Size(232, 20);
            this.TBox.TabIndex = 1;
            this.TBox.Text = "Escribir aquí";
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Location = new System.Drawing.Point(119, 157);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(232, 23);
            this.B1.TabIndex = 2;
            this.B1.Text = "Muestra el contenido del Cuadro de Texto";
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Location = new System.Drawing.Point(119, 210);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(232, 23);
            this.B2.TabIndex = 3;
            this.B2.Text = "Cambia el color del formulario";
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Location = new System.Drawing.Point(119, 261);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(232, 23);
            this.B3.TabIndex = 4;
            this.B3.Text = "Cambia el color del texto del cuadro";
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 382);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.TBox);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox TBox;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
    }
}

