namespace Tema_6___Ejercicio_8
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
            this.btnApostar = new System.Windows.Forms.Button();
            this.btnSorteo = new System.Windows.Forms.Button();
            this.btnMostrarResultado = new System.Windows.Forms.Button();
            this.lblApuesta = new System.Windows.Forms.Label();
            this.lblSorteo = new System.Windows.Forms.Label();
            this.lblAciertos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnApostar
            // 
            this.btnApostar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnApostar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApostar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostar.Location = new System.Drawing.Point(27, 29);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(138, 68);
            this.btnApostar.TabIndex = 0;
            this.btnApostar.Text = "Realizar apuesta";
            this.btnApostar.UseVisualStyleBackColor = false;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // btnSorteo
            // 
            this.btnSorteo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSorteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorteo.Location = new System.Drawing.Point(27, 116);
            this.btnSorteo.Name = "btnSorteo";
            this.btnSorteo.Size = new System.Drawing.Size(138, 68);
            this.btnSorteo.TabIndex = 1;
            this.btnSorteo.Text = "Simular sorteo";
            this.btnSorteo.UseVisualStyleBackColor = false;
            this.btnSorteo.Click += new System.EventHandler(this.btnSorteo_Click);
            // 
            // btnMostrarResultado
            // 
            this.btnMostrarResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMostrarResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarResultado.Location = new System.Drawing.Point(27, 206);
            this.btnMostrarResultado.Name = "btnMostrarResultado";
            this.btnMostrarResultado.Size = new System.Drawing.Size(138, 68);
            this.btnMostrarResultado.TabIndex = 4;
            this.btnMostrarResultado.Text = "Mostrar resultado";
            this.btnMostrarResultado.UseVisualStyleBackColor = false;
            this.btnMostrarResultado.Click += new System.EventHandler(this.btnMostrarResultado_Click);
            // 
            // lblApuesta
            // 
            this.lblApuesta.AutoSize = true;
            this.lblApuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApuesta.Location = new System.Drawing.Point(197, 45);
            this.lblApuesta.Name = "lblApuesta";
            this.lblApuesta.Size = new System.Drawing.Size(0, 29);
            this.lblApuesta.TabIndex = 5;
            // 
            // lblSorteo
            // 
            this.lblSorteo.AutoSize = true;
            this.lblSorteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorteo.Location = new System.Drawing.Point(197, 132);
            this.lblSorteo.Name = "lblSorteo";
            this.lblSorteo.Size = new System.Drawing.Size(0, 29);
            this.lblSorteo.TabIndex = 6;
            // 
            // lblAciertos
            // 
            this.lblAciertos.AutoSize = true;
            this.lblAciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAciertos.Location = new System.Drawing.Point(197, 222);
            this.lblAciertos.Name = "lblAciertos";
            this.lblAciertos.Size = new System.Drawing.Size(0, 24);
            this.lblAciertos.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 301);
            this.Controls.Add(this.lblAciertos);
            this.Controls.Add(this.lblSorteo);
            this.Controls.Add(this.lblApuesta);
            this.Controls.Add(this.btnMostrarResultado);
            this.Controls.Add(this.btnSorteo);
            this.Controls.Add(this.btnApostar);
            this.Name = "Form1";
            this.Text = "Ejercicio 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Button btnSorteo;
        private System.Windows.Forms.Button btnMostrarResultado;
        private System.Windows.Forms.Label lblApuesta;
        private System.Windows.Forms.Label lblSorteo;
        private System.Windows.Forms.Label lblAciertos;
    }
}

