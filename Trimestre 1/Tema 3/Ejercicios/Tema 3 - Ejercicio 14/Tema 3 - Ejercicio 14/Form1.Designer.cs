namespace Tema_3___Ejercicio_14
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
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFor.Location = new System.Drawing.Point(76, 48);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(103, 43);
            this.btnFor.TabIndex = 0;
            this.btnFor.Text = "Suma con for";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnWhile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhile.Location = new System.Drawing.Point(76, 131);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(103, 43);
            this.btnWhile.TabIndex = 1;
            this.btnWhile.Text = "Suma con while";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 239);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Name = "Form1";
            this.Text = "Ejercicio 14";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
    }
}

