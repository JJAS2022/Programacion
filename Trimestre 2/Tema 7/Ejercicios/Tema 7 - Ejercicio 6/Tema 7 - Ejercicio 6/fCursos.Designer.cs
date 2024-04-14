namespace Tema_7___Ejercicio_6
{
    partial class fCursos
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
            this.bAnyadir = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bMostrarCursos = new System.Windows.Forms.Button();
            this.bMostrarAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAnyadir
            // 
            this.bAnyadir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bAnyadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAnyadir.Location = new System.Drawing.Point(62, 27);
            this.bAnyadir.Name = "bAnyadir";
            this.bAnyadir.Size = new System.Drawing.Size(170, 45);
            this.bAnyadir.TabIndex = 0;
            this.bAnyadir.Text = "Añadir curso";
            this.bAnyadir.UseVisualStyleBackColor = false;
            this.bAnyadir.Click += new System.EventHandler(this.bAnyadir_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminar.Location = new System.Drawing.Point(62, 96);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(170, 45);
            this.bEliminar.TabIndex = 1;
            this.bEliminar.Text = "Eliminar curso";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bMostrarCursos
            // 
            this.bMostrarCursos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bMostrarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMostrarCursos.Location = new System.Drawing.Point(62, 165);
            this.bMostrarCursos.Name = "bMostrarCursos";
            this.bMostrarCursos.Size = new System.Drawing.Size(170, 45);
            this.bMostrarCursos.TabIndex = 2;
            this.bMostrarCursos.Text = "Mostrar cursos";
            this.bMostrarCursos.UseVisualStyleBackColor = false;
            this.bMostrarCursos.Click += new System.EventHandler(this.bMostrarCursos_Click);
            // 
            // bMostrarAlumnos
            // 
            this.bMostrarAlumnos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bMostrarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMostrarAlumnos.Location = new System.Drawing.Point(62, 234);
            this.bMostrarAlumnos.Name = "bMostrarAlumnos";
            this.bMostrarAlumnos.Size = new System.Drawing.Size(170, 45);
            this.bMostrarAlumnos.TabIndex = 3;
            this.bMostrarAlumnos.Text = "Mostrar alumnos de un curso";
            this.bMostrarAlumnos.UseVisualStyleBackColor = false;
            this.bMostrarAlumnos.Click += new System.EventHandler(this.bMostrarAlumnos_Click);
            // 
            // fCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 311);
            this.Controls.Add(this.bMostrarAlumnos);
            this.Controls.Add(this.bMostrarCursos);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bAnyadir);
            this.Name = "fCursos";
            this.Text = "Gestión de cursos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAnyadir;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bMostrarCursos;
        private System.Windows.Forms.Button bMostrarAlumnos;
    }
}