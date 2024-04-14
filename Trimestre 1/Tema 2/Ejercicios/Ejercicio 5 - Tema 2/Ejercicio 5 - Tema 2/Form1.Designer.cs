namespace Ejercicio_5___Tema_2
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
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.BoxNum1 = new System.Windows.Forms.TextBox();
            this.BoxNum2 = new System.Windows.Forms.TextBox();
            this.BoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSum.Location = new System.Drawing.Point(264, 67);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(93, 34);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Suma";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSubstract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubstract.Location = new System.Drawing.Point(264, 137);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(93, 34);
            this.btnSubstract.TabIndex = 1;
            this.btnSubstract.Text = "Resta";
            this.btnSubstract.UseVisualStyleBackColor = false;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(42, 50);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(53, 13);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "Número 1";
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(42, 113);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(53, 13);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "Número 2";
            this.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(42, 180);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Resultado";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BoxNum1
            // 
            this.BoxNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxNum1.Location = new System.Drawing.Point(102, 48);
            this.BoxNum1.Name = "BoxNum1";
            this.BoxNum1.Size = new System.Drawing.Size(100, 20);
            this.BoxNum1.TabIndex = 5;
            // 
            // BoxNum2
            // 
            this.BoxNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxNum2.Location = new System.Drawing.Point(102, 111);
            this.BoxNum2.Name = "BoxNum2";
            this.BoxNum2.Size = new System.Drawing.Size(100, 20);
            this.BoxNum2.TabIndex = 6;
            // 
            // BoxResult
            // 
            this.BoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxResult.Location = new System.Drawing.Point(102, 178);
            this.BoxResult.Name = "BoxResult";
            this.BoxResult.Size = new System.Drawing.Size(100, 20);
            this.BoxResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 239);
            this.Controls.Add(this.BoxResult);
            this.Controls.Add(this.BoxNum2);
            this.Controls.Add(this.BoxNum1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnSum);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Ejercicio 5 - Tema 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox BoxNum1;
        private System.Windows.Forms.TextBox BoxNum2;
        private System.Windows.Forms.TextBox BoxResult;
    }
}

