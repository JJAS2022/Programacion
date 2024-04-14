namespace Tema_7___Ejercicio_3
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
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnyo = new System.Windows.Forms.TextBox();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDia
            // 
            this.txtDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDia.Location = new System.Drawing.Point(46, 46);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(33, 20);
            this.txtDia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Día";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mes";
            // 
            // txtMes
            // 
            this.txtMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMes.Location = new System.Drawing.Point(93, 46);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(33, 20);
            this.txtMes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año";
            // 
            // txtAnyo
            // 
            this.txtAnyo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnyo.Location = new System.Drawing.Point(141, 46);
            this.txtAnyo.Name = "txtAnyo";
            this.txtAnyo.Size = new System.Drawing.Size(33, 20);
            this.txtAnyo.TabIndex = 4;
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAnyadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnyadir.Location = new System.Drawing.Point(46, 93);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(128, 37);
            this.btnAnyadir.TabIndex = 6;
            this.btnAnyadir.Text = "Añadir nueva fecha";
            this.btnAnyadir.UseVisualStyleBackColor = false;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.Location = new System.Drawing.Point(46, 153);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(128, 42);
            this.btnOrdenar.TabIndex = 7;
            this.btnOrdenar.Text = "Ordenar fechas cronológicamente";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Location = new System.Drawing.Point(46, 218);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(128, 37);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar lista de fechas";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 283);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnAnyadir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnyo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDia);
            this.Name = "Form1";
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnyo;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnMostrar;
    }
}

