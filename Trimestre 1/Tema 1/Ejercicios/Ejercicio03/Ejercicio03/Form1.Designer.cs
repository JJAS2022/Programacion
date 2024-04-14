namespace Ejercicio03
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
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.TBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Location = new System.Drawing.Point(183, 133);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 23);
            this.B1.TabIndex = 0;
            this.B1.Text = "Botón 1";
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Location = new System.Drawing.Point(183, 196);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 23);
            this.B2.TabIndex = 1;
            this.B2.Text = "Botón 2";
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Location = new System.Drawing.Point(339, 164);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 23);
            this.B3.TabIndex = 2;
            this.B3.Text = "Borrar Texto";
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(63, 70);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 17);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Botón Pulsado";
            // 
            // TBox
            // 
            this.TBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBox.Location = new System.Drawing.Point(183, 70);
            this.TBox.Name = "TBox";
            this.TBox.Size = new System.Drawing.Size(231, 20);
            this.TBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(568, 316);
            this.Controls.Add(this.TBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Name = "Form1";
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TBox;
    }
}

