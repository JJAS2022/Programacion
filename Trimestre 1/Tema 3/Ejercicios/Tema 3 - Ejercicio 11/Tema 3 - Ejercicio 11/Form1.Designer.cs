namespace Tema_3___Ejercicio_11
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnNextTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(59, 57);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(33, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Hora:";
            // 
            // txtHour
            // 
            this.txtHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHour.Location = new System.Drawing.Point(98, 55);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(100, 20);
            this.txtHour.TabIndex = 1;
            // 
            // txtMinute
            // 
            this.txtMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinute.Location = new System.Drawing.Point(98, 107);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(100, 20);
            this.txtMinute.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(45, 109);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(47, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Minutos:";
            // 
            // txtSecond
            // 
            this.txtSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecond.Location = new System.Drawing.Point(98, 160);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 20);
            this.txtSecond.TabIndex = 5;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(34, 162);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(58, 13);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Segundos:";
            // 
            // btnNextTime
            // 
            this.btnNextTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNextTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTime.Location = new System.Drawing.Point(98, 215);
            this.btnNextTime.Name = "btnNextTime";
            this.btnNextTime.Size = new System.Drawing.Size(90, 50);
            this.btnNextTime.TabIndex = 6;
            this.btnNextTime.Text = "Calcular hora siguiente";
            this.btnNextTime.UseVisualStyleBackColor = false;
            this.btnNextTime.Click += new System.EventHandler(this.btnNextTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 316);
            this.Controls.Add(this.btnNextTime);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Ejercicio 11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnNextTime;
    }
}

