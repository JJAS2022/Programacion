namespace Ejercicio_4___Tema_9
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
            this.bCursos = new System.Windows.Forms.Button();
            this.bAlumnos = new System.Windows.Forms.Button();
            this.bProfesores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCursos
            // 
            this.bCursos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCursos.Location = new System.Drawing.Point(50, 28);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(137, 50);
            this.bCursos.TabIndex = 1;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = false;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bAlumnos
            // 
            this.bAlumnos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAlumnos.Location = new System.Drawing.Point(50, 109);
            this.bAlumnos.Name = "bAlumnos";
            this.bAlumnos.Size = new System.Drawing.Size(137, 50);
            this.bAlumnos.TabIndex = 2;
            this.bAlumnos.Text = "Alumnos";
            this.bAlumnos.UseVisualStyleBackColor = false;
            this.bAlumnos.Click += new System.EventHandler(this.bAlumnos_Click);
            // 
            // bProfesores
            // 
            this.bProfesores.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProfesores.Location = new System.Drawing.Point(50, 188);
            this.bProfesores.Name = "bProfesores";
            this.bProfesores.Size = new System.Drawing.Size(137, 50);
            this.bProfesores.TabIndex = 3;
            this.bProfesores.Text = "Profesores";
            this.bProfesores.UseVisualStyleBackColor = false;
            this.bProfesores.Click += new System.EventHandler(this.bProfesores_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 265);
            this.Controls.Add(this.bProfesores);
            this.Controls.Add(this.bAlumnos);
            this.Controls.Add(this.bCursos);
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión del instituto";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bAlumnos;
        private System.Windows.Forms.Button bProfesores;
    }
}

