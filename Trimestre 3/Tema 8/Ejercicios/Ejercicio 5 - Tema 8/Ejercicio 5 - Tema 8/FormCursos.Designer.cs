namespace Ejercicio_5___Tema_8
{
    partial class FormCursos
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
            this.bMostrarAlumnos = new System.Windows.Forms.Button();
            this.bMostrarCursos = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bAnyadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bMostrarAlumnos
            // 
            this.bMostrarAlumnos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bMostrarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMostrarAlumnos.Location = new System.Drawing.Point(55, 235);
            this.bMostrarAlumnos.Name = "bMostrarAlumnos";
            this.bMostrarAlumnos.Size = new System.Drawing.Size(170, 45);
            this.bMostrarAlumnos.TabIndex = 7;
            this.bMostrarAlumnos.Text = "Mostrar alumnos de un curso";
            this.bMostrarAlumnos.UseVisualStyleBackColor = false;
            this.bMostrarAlumnos.Click += new System.EventHandler(this.bMostrarAlumnos_Click);
            // 
            // bMostrarCursos
            // 
            this.bMostrarCursos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bMostrarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMostrarCursos.Location = new System.Drawing.Point(55, 166);
            this.bMostrarCursos.Name = "bMostrarCursos";
            this.bMostrarCursos.Size = new System.Drawing.Size(170, 45);
            this.bMostrarCursos.TabIndex = 6;
            this.bMostrarCursos.Text = "Mostrar cursos";
            this.bMostrarCursos.UseVisualStyleBackColor = false;
            this.bMostrarCursos.Click += new System.EventHandler(this.bMostrarCursos_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminar.Location = new System.Drawing.Point(55, 97);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(170, 45);
            this.bEliminar.TabIndex = 5;
            this.bEliminar.Text = "Eliminar curso";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bAnyadir
            // 
            this.bAnyadir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bAnyadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAnyadir.Location = new System.Drawing.Point(55, 28);
            this.bAnyadir.Name = "bAnyadir";
            this.bAnyadir.Size = new System.Drawing.Size(170, 45);
            this.bAnyadir.TabIndex = 4;
            this.bAnyadir.Text = "Añadir curso";
            this.bAnyadir.UseVisualStyleBackColor = false;
            this.bAnyadir.Click += new System.EventHandler(this.bAnyadir_Click);
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 304);
            this.Controls.Add(this.bMostrarAlumnos);
            this.Controls.Add(this.bMostrarCursos);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bAnyadir);
            this.Name = "FormCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de cursos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bMostrarAlumnos;
        private System.Windows.Forms.Button bMostrarCursos;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bAnyadir;
    }
}