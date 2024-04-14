namespace Ejemplo01
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
            this.BPrimero = new System.Windows.Forms.Button();
            this.BSegundo = new System.Windows.Forms.Button();
            this.TCuadroTexto = new System.Windows.Forms.TextBox();
            this.LEtiqueta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BPrimero
            // 
            this.BPrimero.Location = new System.Drawing.Point(175, 194);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(100, 23);
            this.BPrimero.TabIndex = 0;
            this.BPrimero.Text = "Botón";
            this.BPrimero.UseVisualStyleBackColor = true;
            this.BPrimero.Click += new System.EventHandler(this.BPrimero_Click);
            // 
            // BSegundo
            // 
            this.BSegundo.Location = new System.Drawing.Point(175, 266);
            this.BSegundo.Name = "BSegundo";
            this.BSegundo.Size = new System.Drawing.Size(100, 23);
            this.BSegundo.TabIndex = 1;
            this.BSegundo.Text = "Otro Botón";
            this.BSegundo.UseVisualStyleBackColor = true;
            this.BSegundo.Click += new System.EventHandler(this.BSegundo_Click);
            // 
            // TCuadroTexto
            // 
            this.TCuadroTexto.Location = new System.Drawing.Point(175, 133);
            this.TCuadroTexto.Name = "TCuadroTexto";
            this.TCuadroTexto.Size = new System.Drawing.Size(100, 20);
            this.TCuadroTexto.TabIndex = 2;
            // 
            // LEtiqueta
            // 
            this.LEtiqueta.AutoSize = true;
            this.LEtiqueta.Location = new System.Drawing.Point(175, 85);
            this.LEtiqueta.Name = "LEtiqueta";
            this.LEtiqueta.Size = new System.Drawing.Size(34, 13);
            this.LEtiqueta.TabIndex = 3;
            this.LEtiqueta.Text = "Texto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.LEtiqueta);
            this.Controls.Add(this.TCuadroTexto);
            this.Controls.Add(this.BSegundo);
            this.Controls.Add(this.BPrimero);
            this.Name = "Form1";
            this.Text = "Mi primer programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.Button BSegundo;
        private System.Windows.Forms.TextBox TCuadroTexto;
        private System.Windows.Forms.Label LEtiqueta;
    }
}

