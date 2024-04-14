namespace Tema_7___Ejercicio_5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnOrdenarEmpleados = new System.Windows.Forms.Button();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnIntroducir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOrdenarEmpleadosVentas = new System.Windows.Forms.Button();
            this.btnEliminarVentas = new System.Windows.Forms.Button();
            this.btnMostrarEmpleadoMayoresVentas = new System.Windows.Forms.Button();
            this.btnAnyadirVenta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrarDatos);
            this.groupBox1.Controls.Add(this.btnOrdenarEmpleados);
            this.groupBox1.Controls.Add(this.btnMostrarLista);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnIntroducir);
            this.groupBox1.Location = new System.Drawing.Point(32, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDatos.Location = new System.Drawing.Point(349, 108);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(238, 29);
            this.btnMostrarDatos.TabIndex = 4;
            this.btnMostrarDatos.Text = "Mostrar datos de un empleado";
            this.btnMostrarDatos.UseVisualStyleBackColor = false;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnOrdenarEmpleados
            // 
            this.btnOrdenarEmpleados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOrdenarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarEmpleados.Location = new System.Drawing.Point(49, 108);
            this.btnOrdenarEmpleados.Name = "btnOrdenarEmpleados";
            this.btnOrdenarEmpleados.Size = new System.Drawing.Size(238, 29);
            this.btnOrdenarEmpleados.TabIndex = 3;
            this.btnOrdenarEmpleados.Text = "Ordenar empleados alfabéticamente";
            this.btnOrdenarEmpleados.UseVisualStyleBackColor = false;
            this.btnOrdenarEmpleados.Click += new System.EventHandler(this.btnOrdenarEmpleados_Click);
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarLista.Location = new System.Drawing.Point(461, 36);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(154, 29);
            this.btnMostrarLista.TabIndex = 2;
            this.btnMostrarLista.Text = "Mostrar lista empleados";
            this.btnMostrarLista.UseVisualStyleBackColor = false;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(242, 36);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(154, 29);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar empleado";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnIntroducir
            // 
            this.btnIntroducir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIntroducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntroducir.Location = new System.Drawing.Point(35, 36);
            this.btnIntroducir.Name = "btnIntroducir";
            this.btnIntroducir.Size = new System.Drawing.Size(154, 29);
            this.btnIntroducir.TabIndex = 0;
            this.btnIntroducir.Text = "Introducir empleado";
            this.btnIntroducir.UseVisualStyleBackColor = false;
            this.btnIntroducir.Click += new System.EventHandler(this.btnIntroducir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOrdenarEmpleadosVentas);
            this.groupBox2.Controls.Add(this.btnEliminarVentas);
            this.groupBox2.Controls.Add(this.btnMostrarEmpleadoMayoresVentas);
            this.groupBox2.Controls.Add(this.btnAnyadirVenta);
            this.groupBox2.Location = new System.Drawing.Point(32, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas";
            // 
            // btnOrdenarEmpleadosVentas
            // 
            this.btnOrdenarEmpleadosVentas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOrdenarEmpleadosVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarEmpleadosVentas.Location = new System.Drawing.Point(349, 108);
            this.btnOrdenarEmpleadosVentas.Name = "btnOrdenarEmpleadosVentas";
            this.btnOrdenarEmpleadosVentas.Size = new System.Drawing.Size(238, 29);
            this.btnOrdenarEmpleadosVentas.TabIndex = 4;
            this.btnOrdenarEmpleadosVentas.Text = "Ordenar empleados por ventas";
            this.btnOrdenarEmpleadosVentas.UseVisualStyleBackColor = false;
            this.btnOrdenarEmpleadosVentas.Click += new System.EventHandler(this.btnOrdenarEmpleadosVentas_Click);
            // 
            // btnEliminarVentas
            // 
            this.btnEliminarVentas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVentas.Location = new System.Drawing.Point(49, 108);
            this.btnEliminarVentas.Name = "btnEliminarVentas";
            this.btnEliminarVentas.Size = new System.Drawing.Size(238, 29);
            this.btnEliminarVentas.TabIndex = 3;
            this.btnEliminarVentas.Text = "Eliminar ventas de un empleado";
            this.btnEliminarVentas.UseVisualStyleBackColor = false;
            this.btnEliminarVentas.Click += new System.EventHandler(this.btnEliminarVentas_Click);
            // 
            // btnMostrarEmpleadoMayoresVentas
            // 
            this.btnMostrarEmpleadoMayoresVentas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarEmpleadoMayoresVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarEmpleadoMayoresVentas.Location = new System.Drawing.Point(349, 36);
            this.btnMostrarEmpleadoMayoresVentas.Name = "btnMostrarEmpleadoMayoresVentas";
            this.btnMostrarEmpleadoMayoresVentas.Size = new System.Drawing.Size(238, 29);
            this.btnMostrarEmpleadoMayoresVentas.TabIndex = 2;
            this.btnMostrarEmpleadoMayoresVentas.Text = "Mostrar empleado con mayores ventas";
            this.btnMostrarEmpleadoMayoresVentas.UseVisualStyleBackColor = false;
            this.btnMostrarEmpleadoMayoresVentas.Click += new System.EventHandler(this.btnMostrarEmpleadoMayoresVentas_Click);
            // 
            // btnAnyadirVenta
            // 
            this.btnAnyadirVenta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAnyadirVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnyadirVenta.Location = new System.Drawing.Point(49, 36);
            this.btnAnyadirVenta.Name = "btnAnyadirVenta";
            this.btnAnyadirVenta.Size = new System.Drawing.Size(238, 29);
            this.btnAnyadirVenta.TabIndex = 0;
            this.btnAnyadirVenta.Text = "Añadir venta a empleado";
            this.btnAnyadirVenta.UseVisualStyleBackColor = false;
            this.btnAnyadirVenta.Click += new System.EventHandler(this.btnAnyadirVenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Empleados y Ventas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnOrdenarEmpleados;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnIntroducir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOrdenarEmpleadosVentas;
        private System.Windows.Forms.Button btnEliminarVentas;
        private System.Windows.Forms.Button btnMostrarEmpleadoMayoresVentas;
        private System.Windows.Forms.Button btnAnyadirVenta;
    }
}

