namespace Ejercicio_5___Tema_8
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
            this.bProfesores = new System.Windows.Forms.Button();
            this.bAlumnos = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bRellenar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bMostrarTodos = new System.Windows.Forms.Button();
            this.bVaciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bProfesores
            // 
            this.bProfesores.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProfesores.Location = new System.Drawing.Point(402, 27);
            this.bProfesores.Name = "bProfesores";
            this.bProfesores.Size = new System.Drawing.Size(137, 50);
            this.bProfesores.TabIndex = 5;
            this.bProfesores.Text = "Profesores";
            this.bProfesores.UseVisualStyleBackColor = false;
            this.bProfesores.Click += new System.EventHandler(this.bProfesores_Click);
            // 
            // bAlumnos
            // 
            this.bAlumnos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAlumnos.Location = new System.Drawing.Point(216, 27);
            this.bAlumnos.Name = "bAlumnos";
            this.bAlumnos.Size = new System.Drawing.Size(137, 50);
            this.bAlumnos.TabIndex = 4;
            this.bAlumnos.Text = "Alumnos";
            this.bAlumnos.UseVisualStyleBackColor = false;
            this.bAlumnos.Click += new System.EventHandler(this.bAlumnos_Click);
            // 
            // bCursos
            // 
            this.bCursos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCursos.Location = new System.Drawing.Point(32, 27);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(137, 50);
            this.bCursos.TabIndex = 3;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = false;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bRellenar
            // 
            this.bRellenar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bRellenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRellenar.Location = new System.Drawing.Point(32, 28);
            this.bRellenar.Name = "bRellenar";
            this.bRellenar.Size = new System.Drawing.Size(119, 50);
            this.bRellenar.TabIndex = 6;
            this.bRellenar.Text = "Rellenar con datos predefinidos";
            this.bRellenar.UseVisualStyleBackColor = false;
            this.bRellenar.Click += new System.EventHandler(this.bRellenar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bCursos);
            this.groupBox1.Controls.Add(this.bAlumnos);
            this.groupBox1.Controls.Add(this.bProfesores);
            this.groupBox1.Location = new System.Drawing.Point(35, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestionar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bVaciar);
            this.groupBox2.Controls.Add(this.bMostrarTodos);
            this.groupBox2.Controls.Add(this.bRellenar);
            this.groupBox2.Location = new System.Drawing.Point(35, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otras herramientas";
            // 
            // bMostrarTodos
            // 
            this.bMostrarTodos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMostrarTodos.Location = new System.Drawing.Point(216, 28);
            this.bMostrarTodos.Name = "bMostrarTodos";
            this.bMostrarTodos.Size = new System.Drawing.Size(137, 50);
            this.bMostrarTodos.TabIndex = 7;
            this.bMostrarTodos.Text = "Mostrar todas las personas asociadas al centro";
            this.bMostrarTodos.UseVisualStyleBackColor = false;
            this.bMostrarTodos.Click += new System.EventHandler(this.bMostrarTodos_Click);
            // 
            // bVaciar
            // 
            this.bVaciar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVaciar.Location = new System.Drawing.Point(402, 28);
            this.bVaciar.Name = "bVaciar";
            this.bVaciar.Size = new System.Drawing.Size(137, 50);
            this.bVaciar.TabIndex = 8;
            this.bVaciar.Text = "Vaciar todas las listas";
            this.bVaciar.UseVisualStyleBackColor = false;
            this.bVaciar.Click += new System.EventHandler(this.bVaciar_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 297);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión del instituto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bProfesores;
        private System.Windows.Forms.Button bAlumnos;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bRellenar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bMostrarTodos;
        private System.Windows.Forms.Button bVaciar;
    }
}

