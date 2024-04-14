namespace Ejercicio_4___Tema_8
{
    partial class FormInicial
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
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnAddHexágono = new System.Windows.Forms.Button();
            this.btnAddTriangulo = new System.Windows.Forms.Button();
            this.btnAddCirculo = new System.Windows.Forms.Button();
            this.btnAddCuadrado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarTodas = new System.Windows.Forms.Button();
            this.btnMostrarRectangulos = new System.Windows.Forms.Button();
            this.btnMostrarHexagonos = new System.Windows.Forms.Button();
            this.btnMostrarTriangulos = new System.Windows.Forms.Button();
            this.btnMostrarCirculos = new System.Windows.Forms.Button();
            this.btnMostrarCuadrados = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAutorellenar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRectangulo);
            this.groupBox1.Controls.Add(this.btnAddHexágono);
            this.groupBox1.Controls.Add(this.btnAddTriangulo);
            this.groupBox1.Controls.Add(this.btnAddCirculo);
            this.groupBox1.Controls.Add(this.btnAddCuadrado);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar ";
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRectangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangulo.Location = new System.Drawing.Point(434, 30);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(95, 68);
            this.btnRectangulo.TabIndex = 3;
            this.btnRectangulo.Text = "Rectángulo";
            this.btnRectangulo.UseVisualStyleBackColor = false;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnAddHexágono
            // 
            this.btnAddHexágono.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddHexágono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHexágono.Location = new System.Drawing.Point(568, 30);
            this.btnAddHexágono.Name = "btnAddHexágono";
            this.btnAddHexágono.Size = new System.Drawing.Size(95, 68);
            this.btnAddHexágono.TabIndex = 1;
            this.btnAddHexágono.Text = "Hexágono";
            this.btnAddHexágono.UseVisualStyleBackColor = false;
            this.btnAddHexágono.Click += new System.EventHandler(this.btnAddHexágono_Click);
            // 
            // btnAddTriangulo
            // 
            this.btnAddTriangulo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddTriangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTriangulo.Location = new System.Drawing.Point(298, 30);
            this.btnAddTriangulo.Name = "btnAddTriangulo";
            this.btnAddTriangulo.Size = new System.Drawing.Size(95, 68);
            this.btnAddTriangulo.TabIndex = 2;
            this.btnAddTriangulo.Text = "Triángulo";
            this.btnAddTriangulo.UseVisualStyleBackColor = false;
            this.btnAddTriangulo.Click += new System.EventHandler(this.btnAddTriangulo_Click);
            // 
            // btnAddCirculo
            // 
            this.btnAddCirculo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCirculo.Location = new System.Drawing.Point(36, 30);
            this.btnAddCirculo.Name = "btnAddCirculo";
            this.btnAddCirculo.Size = new System.Drawing.Size(95, 68);
            this.btnAddCirculo.TabIndex = 1;
            this.btnAddCirculo.Text = "Círculo";
            this.btnAddCirculo.UseVisualStyleBackColor = false;
            this.btnAddCirculo.Click += new System.EventHandler(this.btnAddCirculo_Click);
            // 
            // btnAddCuadrado
            // 
            this.btnAddCuadrado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCuadrado.Location = new System.Drawing.Point(168, 30);
            this.btnAddCuadrado.Name = "btnAddCuadrado";
            this.btnAddCuadrado.Size = new System.Drawing.Size(95, 68);
            this.btnAddCuadrado.TabIndex = 0;
            this.btnAddCuadrado.Text = "Cuadrado";
            this.btnAddCuadrado.UseVisualStyleBackColor = false;
            this.btnAddCuadrado.Click += new System.EventHandler(this.btnAddCuadrado_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarTodas);
            this.groupBox2.Controls.Add(this.btnMostrarRectangulos);
            this.groupBox2.Controls.Add(this.btnMostrarHexagonos);
            this.groupBox2.Controls.Add(this.btnMostrarTriangulos);
            this.groupBox2.Controls.Add(this.btnMostrarCirculos);
            this.groupBox2.Controls.Add(this.btnMostrarCuadrados);
            this.groupBox2.Location = new System.Drawing.Point(23, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mostrar";
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodas.Location = new System.Drawing.Point(36, 30);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(84, 68);
            this.btnMostrarTodas.TabIndex = 4;
            this.btnMostrarTodas.Text = "Todas";
            this.btnMostrarTodas.UseVisualStyleBackColor = false;
            this.btnMostrarTodas.Click += new System.EventHandler(this.btnMostrarTodas_Click);
            // 
            // btnMostrarRectangulos
            // 
            this.btnMostrarRectangulos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarRectangulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarRectangulos.Location = new System.Drawing.Point(476, 30);
            this.btnMostrarRectangulos.Name = "btnMostrarRectangulos";
            this.btnMostrarRectangulos.Size = new System.Drawing.Size(80, 68);
            this.btnMostrarRectangulos.TabIndex = 3;
            this.btnMostrarRectangulos.Text = "Rectángulos";
            this.btnMostrarRectangulos.UseVisualStyleBackColor = false;
            this.btnMostrarRectangulos.Click += new System.EventHandler(this.btnMostrarRectangulos_Click);
            // 
            // btnMostrarHexagonos
            // 
            this.btnMostrarHexagonos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarHexagonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarHexagonos.Location = new System.Drawing.Point(585, 30);
            this.btnMostrarHexagonos.Name = "btnMostrarHexagonos";
            this.btnMostrarHexagonos.Size = new System.Drawing.Size(78, 68);
            this.btnMostrarHexagonos.TabIndex = 1;
            this.btnMostrarHexagonos.Text = "Hexágonos";
            this.btnMostrarHexagonos.UseVisualStyleBackColor = false;
            this.btnMostrarHexagonos.Click += new System.EventHandler(this.btnMostrarHexagonos_Click);
            // 
            // btnMostrarTriangulos
            // 
            this.btnMostrarTriangulos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarTriangulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTriangulos.Location = new System.Drawing.Point(370, 30);
            this.btnMostrarTriangulos.Name = "btnMostrarTriangulos";
            this.btnMostrarTriangulos.Size = new System.Drawing.Size(83, 68);
            this.btnMostrarTriangulos.TabIndex = 2;
            this.btnMostrarTriangulos.Text = "Triángulos";
            this.btnMostrarTriangulos.UseVisualStyleBackColor = false;
            this.btnMostrarTriangulos.Click += new System.EventHandler(this.btnMostrarTriangulos_Click);
            // 
            // btnMostrarCirculos
            // 
            this.btnMostrarCirculos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarCirculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarCirculos.Location = new System.Drawing.Point(144, 30);
            this.btnMostrarCirculos.Name = "btnMostrarCirculos";
            this.btnMostrarCirculos.Size = new System.Drawing.Size(84, 68);
            this.btnMostrarCirculos.TabIndex = 1;
            this.btnMostrarCirculos.Text = "Círculos";
            this.btnMostrarCirculos.UseVisualStyleBackColor = false;
            this.btnMostrarCirculos.Click += new System.EventHandler(this.btnMostrarCirculos_Click);
            // 
            // btnMostrarCuadrados
            // 
            this.btnMostrarCuadrados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarCuadrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarCuadrados.Location = new System.Drawing.Point(259, 30);
            this.btnMostrarCuadrados.Name = "btnMostrarCuadrados";
            this.btnMostrarCuadrados.Size = new System.Drawing.Size(82, 68);
            this.btnMostrarCuadrados.TabIndex = 0;
            this.btnMostrarCuadrados.Text = "Cuadrados";
            this.btnMostrarCuadrados.UseVisualStyleBackColor = false;
            this.btnMostrarCuadrados.Click += new System.EventHandler(this.btnMostrarCuadrados_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Controls.Add(this.btnAutorellenar);
            this.groupBox3.Location = new System.Drawing.Point(23, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 129);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Otros";
            // 
            // btnAutorellenar
            // 
            this.btnAutorellenar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAutorellenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutorellenar.Location = new System.Drawing.Point(96, 41);
            this.btnAutorellenar.Name = "btnAutorellenar";
            this.btnAutorellenar.Size = new System.Drawing.Size(192, 68);
            this.btnAutorellenar.TabIndex = 4;
            this.btnAutorellenar.Text = "Autorellenar";
            this.btnAutorellenar.UseVisualStyleBackColor = false;
            this.btnAutorellenar.Click += new System.EventHandler(this.btnAutorellenar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(406, 41);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(192, 68);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Vaciar la lista";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 499);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnAddHexágono;
        private System.Windows.Forms.Button btnAddTriangulo;
        private System.Windows.Forms.Button btnAddCirculo;
        private System.Windows.Forms.Button btnAddCuadrado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarTodas;
        private System.Windows.Forms.Button btnMostrarRectangulos;
        private System.Windows.Forms.Button btnMostrarHexagonos;
        private System.Windows.Forms.Button btnMostrarTriangulos;
        private System.Windows.Forms.Button btnMostrarCirculos;
        private System.Windows.Forms.Button btnMostrarCuadrados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAutorellenar;
    }
}

