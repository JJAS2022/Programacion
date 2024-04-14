namespace Tema_7___Ejercicio_4
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
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCumpleanyos = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAnyadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnyadir.Location = new System.Drawing.Point(54, 48);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(160, 49);
            this.btnAnyadir.TabIndex = 0;
            this.btnAnyadir.Text = "Nuevo empleado";
            this.btnAnyadir.UseVisualStyleBackColor = false;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Location = new System.Drawing.Point(285, 48);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(160, 49);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar lista de empleados";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCumpleanyos
            // 
            this.btnCumpleanyos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCumpleanyos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCumpleanyos.Location = new System.Drawing.Point(54, 135);
            this.btnCumpleanyos.Name = "btnCumpleanyos";
            this.btnCumpleanyos.Size = new System.Drawing.Size(160, 49);
            this.btnCumpleanyos.TabIndex = 2;
            this.btnCumpleanyos.Text = "Cumpleaños de empleado";
            this.btnCumpleanyos.UseVisualStyleBackColor = false;
            this.btnCumpleanyos.Click += new System.EventHandler(this.btnCumpleanyos_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Location = new System.Drawing.Point(285, 135);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(160, 49);
            this.btnVenta.TabIndex = 3;
            this.btnVenta.Text = "Añadir venta";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 226);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnCumpleanyos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAnyadir);
            this.Name = "Form1";
            this.Text = "Ejercicio 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCumpleanyos;
        private System.Windows.Forms.Button btnVenta;
    }
}

