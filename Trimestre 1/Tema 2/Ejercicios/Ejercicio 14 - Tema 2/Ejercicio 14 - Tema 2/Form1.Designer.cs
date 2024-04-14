namespace Ejercicio_14___Tema_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHigher = new System.Windows.Forms.Button();
            this.btnSmaller = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnNotEqual = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(153, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(153, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número 2:";
            // 
            // btnHigher
            // 
            this.btnHigher.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHigher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHigher.Location = new System.Drawing.Point(71, 70);
            this.btnHigher.Name = "btnHigher";
            this.btnHigher.Size = new System.Drawing.Size(37, 30);
            this.btnHigher.TabIndex = 4;
            this.btnHigher.Text = ">";
            this.btnHigher.UseVisualStyleBackColor = false;
            this.btnHigher.Click += new System.EventHandler(this.btnHigher_Click);
            // 
            // btnSmaller
            // 
            this.btnSmaller.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSmaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmaller.Location = new System.Drawing.Point(133, 70);
            this.btnSmaller.Name = "btnSmaller";
            this.btnSmaller.Size = new System.Drawing.Size(37, 30);
            this.btnSmaller.TabIndex = 5;
            this.btnSmaller.Text = "<";
            this.btnSmaller.UseVisualStyleBackColor = false;
            this.btnSmaller.Click += new System.EventHandler(this.btnSmaller_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Location = new System.Drawing.Point(197, 70);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(37, 30);
            this.btnEqual.TabIndex = 6;
            this.btnEqual.Text = "==";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnNotEqual
            // 
            this.btnNotEqual.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNotEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotEqual.Location = new System.Drawing.Point(259, 70);
            this.btnNotEqual.Name = "btnNotEqual";
            this.btnNotEqual.Size = new System.Drawing.Size(37, 30);
            this.btnNotEqual.TabIndex = 7;
            this.btnNotEqual.Text = "!=";
            this.btnNotEqual.UseVisualStyleBackColor = false;
            this.btnNotEqual.Click += new System.EventHandler(this.btnNotEqual_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(153, 167);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 212);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnNotEqual);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnSmaller);
            this.Controls.Add(this.btnHigher);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio 14 - Tema 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHigher;
        private System.Windows.Forms.Button btnSmaller;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnNotEqual;
        private System.Windows.Forms.Label lblResult;
    }
}

