namespace Tema_7___Ejercicio_6
{
    partial class fAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bIntroducir = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bMostrarAlumnos = new System.Windows.Forms.Button();
            this.bOrdenarAlfabeticamente = new System.Windows.Forms.Button();
            this.bMostrarAlumnosCurso = new System.Windows.Forms.Button();
            this.bMostrarUnAlumno = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bMostrarSuspensos = new System.Windows.Forms.Button();
            this.bMostrarAprobados = new System.Windows.Forms.Button();
            this.bEliminarNotas = new System.Windows.Forms.Button();
            this.bAñadirNotas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bMostrarUnAlumno);
            this.groupBox1.Controls.Add(this.bMostrarAlumnosCurso);
            this.groupBox1.Controls.Add(this.bOrdenarAlfabeticamente);
            this.groupBox1.Controls.Add(this.bMostrarAlumnos);
            this.groupBox1.Controls.Add(this.bEliminar);
            this.groupBox1.Controls.Add(this.bIntroducir);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            // 
            // bIntroducir
            // 
            this.bIntroducir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bIntroducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIntroducir.Location = new System.Drawing.Point(18, 28);
            this.bIntroducir.Name = "bIntroducir";
            this.bIntroducir.Size = new System.Drawing.Size(170, 40);
            this.bIntroducir.TabIndex = 0;
            this.bIntroducir.Text = "Añadir alumno";
            this.bIntroducir.UseVisualStyleBackColor = false;
            this.bIntroducir.Click += new System.EventHandler(this.bIntroducir_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminar.Location = new System.Drawing.Point(211, 28);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(170, 40);
            this.bEliminar.TabIndex = 1;
            this.bEliminar.Text = "Eliminar alumno";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bMostrarAlumnos
            // 
            this.bMostrarAlumnos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bMostrarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMostrarAlumnos.Location = new System.Drawing.Point(401, 86);
            this.bMostrarAlumnos.Name = "bMostrarAlumnos";
            this.bMostrarAlumnos.Size = new System.Drawing.Size(170, 40);
            this.bMostrarAlumnos.TabIndex = 2;
            this.bMostrarAlumnos.Text = "Mostrar lista de alumnos";
            this.bMostrarAlumnos.UseVisualStyleBackColor = false;
            this.bMostrarAlumnos.Click += new System.EventHandler(this.bMostrarAlumnos_Click);
            // 
            // bOrdenarAlfabeticamente
            // 
            this.bOrdenarAlfabeticamente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bOrdenarAlfabeticamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOrdenarAlfabeticamente.Location = new System.Drawing.Point(18, 86);
            this.bOrdenarAlfabeticamente.Name = "bOrdenarAlfabeticamente";
            this.bOrdenarAlfabeticamente.Size = new System.Drawing.Size(170, 40);
            this.bOrdenarAlfabeticamente.TabIndex = 3;
            this.bOrdenarAlfabeticamente.Text = "Ordenar alumnos alfabéticamente";
            this.bOrdenarAlfabeticamente.UseVisualStyleBackColor = false;
            this.bOrdenarAlfabeticamente.Click += new System.EventHandler(this.bOrdenarAlfabeticamente_Click);
            // 
            // bMostrarAlumnosCurso
            // 
            this.bMostrarAlumnosCurso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bMostrarAlumnosCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMostrarAlumnosCurso.Location = new System.Drawing.Point(211, 86);
            this.bMostrarAlumnosCurso.Name = "bMostrarAlumnosCurso";
            this.bMostrarAlumnosCurso.Size = new System.Drawing.Size(170, 40);
            this.bMostrarAlumnosCurso.TabIndex = 4;
            this.bMostrarAlumnosCurso.Text = "Mostrar alumnos de un curso";
            this.bMostrarAlumnosCurso.UseVisualStyleBackColor = false;
            this.bMostrarAlumnosCurso.Click += new System.EventHandler(this.bMostrarAlumnosCurso_Click);
            // 
            // bMostrarUnAlumno
            // 
            this.bMostrarUnAlumno.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bMostrarUnAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMostrarUnAlumno.Location = new System.Drawing.Point(401, 28);
            this.bMostrarUnAlumno.Name = "bMostrarUnAlumno";
            this.bMostrarUnAlumno.Size = new System.Drawing.Size(170, 40);
            this.bMostrarUnAlumno.TabIndex = 5;
            this.bMostrarUnAlumno.Text = "Mostrar datos de un alumno";
            this.bMostrarUnAlumno.UseVisualStyleBackColor = false;
            this.bMostrarUnAlumno.Click += new System.EventHandler(this.bMostrarUnAlumno_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bMostrarSuspensos);
            this.groupBox2.Controls.Add(this.bMostrarAprobados);
            this.groupBox2.Controls.Add(this.bEliminarNotas);
            this.groupBox2.Controls.Add(this.bAñadirNotas);
            this.groupBox2.Location = new System.Drawing.Point(24, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas";
            // 
            // bMostrarSuspensos
            // 
            this.bMostrarSuspensos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bMostrarSuspensos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMostrarSuspensos.Location = new System.Drawing.Point(313, 86);
            this.bMostrarSuspensos.Name = "bMostrarSuspensos";
            this.bMostrarSuspensos.Size = new System.Drawing.Size(258, 40);
            this.bMostrarSuspensos.TabIndex = 4;
            this.bMostrarSuspensos.Text = "Mostrar alumnos con nota media inferior a 5 puntos";
            this.bMostrarSuspensos.UseVisualStyleBackColor = false;
            this.bMostrarSuspensos.Click += new System.EventHandler(this.bMostrarSuspensos_Click);
            // 
            // bMostrarAprobados
            // 
            this.bMostrarAprobados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bMostrarAprobados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMostrarAprobados.Location = new System.Drawing.Point(18, 86);
            this.bMostrarAprobados.Name = "bMostrarAprobados";
            this.bMostrarAprobados.Size = new System.Drawing.Size(256, 40);
            this.bMostrarAprobados.TabIndex = 3;
            this.bMostrarAprobados.Text = "Mostrar alumnos con nota media igual o superior a 5 puntos";
            this.bMostrarAprobados.UseVisualStyleBackColor = false;
            this.bMostrarAprobados.Click += new System.EventHandler(this.bMostrarAprobados_Click);
            // 
            // bEliminarNotas
            // 
            this.bEliminarNotas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bEliminarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminarNotas.Location = new System.Drawing.Point(313, 28);
            this.bEliminarNotas.Name = "bEliminarNotas";
            this.bEliminarNotas.Size = new System.Drawing.Size(258, 40);
            this.bEliminarNotas.TabIndex = 1;
            this.bEliminarNotas.Text = "Eliminar notas de un alumno";
            this.bEliminarNotas.UseVisualStyleBackColor = false;
            this.bEliminarNotas.Click += new System.EventHandler(this.bEliminarNotas_Click);
            // 
            // bAñadirNotas
            // 
            this.bAñadirNotas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bAñadirNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAñadirNotas.Location = new System.Drawing.Point(18, 28);
            this.bAñadirNotas.Name = "bAñadirNotas";
            this.bAñadirNotas.Size = new System.Drawing.Size(256, 40);
            this.bAñadirNotas.TabIndex = 0;
            this.bAñadirNotas.Text = "Añadir notas a un alumno";
            this.bAñadirNotas.UseVisualStyleBackColor = false;
            this.bAñadirNotas.Click += new System.EventHandler(this.bAñadirNotas_Click);
            // 
            // fAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fAlumnos";
            this.Text = "Gestión de alumnos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bOrdenarAlfabeticamente;
        private System.Windows.Forms.Button bMostrarAlumnos;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bIntroducir;
        private System.Windows.Forms.Button bMostrarAlumnosCurso;
        private System.Windows.Forms.Button bMostrarUnAlumno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bMostrarSuspensos;
        private System.Windows.Forms.Button bMostrarAprobados;
        private System.Windows.Forms.Button bEliminarNotas;
        private System.Windows.Forms.Button bAñadirNotas;
    }
}