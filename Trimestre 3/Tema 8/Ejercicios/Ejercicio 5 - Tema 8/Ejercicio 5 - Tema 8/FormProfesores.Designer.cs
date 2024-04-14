namespace Ejercicio_5___Tema_8
{
    partial class FormProfesores
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bEliminarAsignatura = new System.Windows.Forms.Button();
            this.bMostrarProfesorPorAsignatura = new System.Windows.Forms.Button();
            this.bAnyadirAsignatura = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bOrdenar = new System.Windows.Forms.Button();
            this.bMostrarUnProfesor = new System.Windows.Forms.Button();
            this.bMostrarProfesores = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bIntroducir = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bEliminarAsignatura);
            this.groupBox2.Controls.Add(this.bMostrarProfesorPorAsignatura);
            this.groupBox2.Controls.Add(this.bAnyadirAsignatura);
            this.groupBox2.Location = new System.Drawing.Point(21, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignaturas";
            // 
            // bEliminarAsignatura
            // 
            this.bEliminarAsignatura.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bEliminarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminarAsignatura.Location = new System.Drawing.Point(309, 28);
            this.bEliminarAsignatura.Name = "bEliminarAsignatura";
            this.bEliminarAsignatura.Size = new System.Drawing.Size(260, 40);
            this.bEliminarAsignatura.TabIndex = 3;
            this.bEliminarAsignatura.Text = "Eliminar las asignaturas de un profesor";
            this.bEliminarAsignatura.UseVisualStyleBackColor = false;
            this.bEliminarAsignatura.Click += new System.EventHandler(this.bEliminarAsignatura_Click);
            // 
            // bMostrarProfesorPorAsignatura
            // 
            this.bMostrarProfesorPorAsignatura.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bMostrarProfesorPorAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMostrarProfesorPorAsignatura.Location = new System.Drawing.Point(163, 93);
            this.bMostrarProfesorPorAsignatura.Name = "bMostrarProfesorPorAsignatura";
            this.bMostrarProfesorPorAsignatura.Size = new System.Drawing.Size(260, 40);
            this.bMostrarProfesorPorAsignatura.TabIndex = 2;
            this.bMostrarProfesorPorAsignatura.Text = "Mostrar profesores que imparten una asignatura";
            this.bMostrarProfesorPorAsignatura.UseVisualStyleBackColor = false;
            this.bMostrarProfesorPorAsignatura.Click += new System.EventHandler(this.bMostrarProfesorPorAsignatura_Click);
            // 
            // bAnyadirAsignatura
            // 
            this.bAnyadirAsignatura.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bAnyadirAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAnyadirAsignatura.Location = new System.Drawing.Point(18, 28);
            this.bAnyadirAsignatura.Name = "bAnyadirAsignatura";
            this.bAnyadirAsignatura.Size = new System.Drawing.Size(253, 40);
            this.bAnyadirAsignatura.TabIndex = 0;
            this.bAnyadirAsignatura.Text = "Añadir asignatura a un profesor";
            this.bAnyadirAsignatura.UseVisualStyleBackColor = false;
            this.bAnyadirAsignatura.Click += new System.EventHandler(this.bAnyadirAsignatura_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bOrdenar);
            this.groupBox1.Controls.Add(this.bMostrarUnProfesor);
            this.groupBox1.Controls.Add(this.bMostrarProfesores);
            this.groupBox1.Controls.Add(this.bEliminar);
            this.groupBox1.Controls.Add(this.bIntroducir);
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profesores";
            // 
            // bOrdenar
            // 
            this.bOrdenar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOrdenar.Location = new System.Drawing.Point(18, 90);
            this.bOrdenar.Name = "bOrdenar";
            this.bOrdenar.Size = new System.Drawing.Size(253, 40);
            this.bOrdenar.TabIndex = 4;
            this.bOrdenar.Text = "Ordenar profesores alfabéticamente";
            this.bOrdenar.UseVisualStyleBackColor = false;
            this.bOrdenar.Click += new System.EventHandler(this.bOrdenar_Click);
            // 
            // bMostrarUnProfesor
            // 
            this.bMostrarUnProfesor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bMostrarUnProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMostrarUnProfesor.Location = new System.Drawing.Point(399, 28);
            this.bMostrarUnProfesor.Name = "bMostrarUnProfesor";
            this.bMostrarUnProfesor.Size = new System.Drawing.Size(170, 40);
            this.bMostrarUnProfesor.TabIndex = 3;
            this.bMostrarUnProfesor.Text = "Mostrar datos de un profesor";
            this.bMostrarUnProfesor.UseVisualStyleBackColor = false;
            this.bMostrarUnProfesor.Click += new System.EventHandler(this.bMostrarUnProfesor_Click);
            // 
            // bMostrarProfesores
            // 
            this.bMostrarProfesores.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bMostrarProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMostrarProfesores.Location = new System.Drawing.Point(309, 90);
            this.bMostrarProfesores.Name = "bMostrarProfesores";
            this.bMostrarProfesores.Size = new System.Drawing.Size(260, 40);
            this.bMostrarProfesores.TabIndex = 2;
            this.bMostrarProfesores.Text = "Mostrar lista de profesores";
            this.bMostrarProfesores.UseVisualStyleBackColor = false;
            this.bMostrarProfesores.Click += new System.EventHandler(this.bMostrarProfesores_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminar.Location = new System.Drawing.Point(209, 28);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(170, 40);
            this.bEliminar.TabIndex = 1;
            this.bEliminar.Text = "Eliminar profesor";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bIntroducir
            // 
            this.bIntroducir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bIntroducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIntroducir.Location = new System.Drawing.Point(18, 28);
            this.bIntroducir.Name = "bIntroducir";
            this.bIntroducir.Size = new System.Drawing.Size(170, 40);
            this.bIntroducir.TabIndex = 0;
            this.bIntroducir.Text = "Introducir profesor";
            this.bIntroducir.UseVisualStyleBackColor = false;
            this.bIntroducir.Click += new System.EventHandler(this.bIntroducir_Click);
            // 
            // FormProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de profesores";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bEliminarAsignatura;
        private System.Windows.Forms.Button bMostrarProfesorPorAsignatura;
        private System.Windows.Forms.Button bAnyadirAsignatura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bOrdenar;
        private System.Windows.Forms.Button bMostrarUnProfesor;
        private System.Windows.Forms.Button bMostrarProfesores;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bIntroducir;
    }
}