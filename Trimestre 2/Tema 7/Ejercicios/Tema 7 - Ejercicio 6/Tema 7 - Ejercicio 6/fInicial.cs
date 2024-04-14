using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_7___Ejercicio_6
{
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

        // Instancias de las clases de listas de cursos, alumnos y profesores
        ListaCursos cursos = new ListaCursos();
        ListaAlumnos alumnos = new ListaAlumnos();
        ListaProfesores profesores = new ListaProfesores();

        // Botón para llamar al formulario de gestión de cursos
        private void bCursos_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario de gestión de cursos
            fCursos fCursos = new fCursos();

            // Pasa a dicho formulario los objetos cursos y alumnos creados en este formulario
            fCursos.cursos = cursos;
            fCursos.alumnos = alumnos;

            // Muestra el formulario de gestión de cursos en pantalla
            fCursos.ShowDialog();
        }

        // Botón para llamar al formulario de gestión de alumnos
        private void bAlumnos_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario de gestión de alumnos
            fAlumnos fAlumnos = new fAlumnos();

            // Pasa a dicho formulario los objetos cursos y alumnos creados en este formulario
            fAlumnos.alumnos = alumnos;
            fAlumnos.cursos = cursos;

            // Muestra el formulario de gestión de cursos en pantalla
            fAlumnos.ShowDialog();
        }

        // Botón para llamar al formulario de gestión de profesores
        private void bProfesores_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario de gestión de profesores
            fProfesores fProfesores = new fProfesores();

            // Pasa a dicho formulario los objetos cursos y profesores creados en este formulario
            fProfesores.profesores = profesores;
            fProfesores.cursos = cursos;

            // Muestra el formulario de gestión de cursos en pantalla
            fProfesores.ShowDialog();
        }
    }
}
