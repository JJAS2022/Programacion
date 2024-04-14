using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5___Tema_8
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        // Instancias de las clases de listas de cursos, alumnos y profesores
        ListaCursos cursos = new ListaCursos();
        ListaPersonas personas = new ListaPersonas();

        // Botones para generar formularios específicos por categoría
        private void bCursos_Click(object sender, EventArgs e)
        {
            FormCursos formCursos = new FormCursos();          
            formCursos.cursos = cursos;
            formCursos.personas = personas;
            formCursos.ShowDialog();
        }

        private void bAlumnos_Click(object sender, EventArgs e)
        {            
            FormAlumnos formAlumnos = new FormAlumnos();          
            formAlumnos.cursos = cursos;
            formAlumnos.personas = personas;
            formAlumnos.ShowDialog();
        }

        private void bProfesores_Click(object sender, EventArgs e)
        {           
            FormProfesores formProfesores = new FormProfesores();           
            formProfesores.cursos = cursos;
            formProfesores.personas = personas;
            formProfesores.ShowDialog();
        }

        // Botón para añadir datos preestablecidos para comprobar el funcionamiento
        private void bRellenar_Click(object sender, EventArgs e)
        {
            cursos.AnyadirCurso("ASIR", "W");
            cursos.AnyadirCurso("DAM", "U");
            cursos.AnyadirCurso("DAW", "Y");
            cursos.AnyadirCurso("DAW", "Z");
            personas.AnyadirAlumno("Pablo López", "123456789A", "666555444", "U");
            personas.AnyadirAlumno("María González", "987654321F", "123456789", "Z");
            personas.AnyadirAlumno("Laura Gómez", "963852741U", "654789123", "Y");
            personas.AnyadirAlumno("José García", "741852963P", "657894321", "Y");
            personas.AnyadirAlumno("Manuela Sánchez", "159357486F", "624579813", "U");
            personas.AnyadirAlumno("Juan Fernández", "357486195J", "684513279", "W");
            personas.AnyadirProfesor("Jorge Gámez", "751482695L", "687459321", "jorge@correo.inv", "U", true);
            personas.AnyadirProfesor("Alicia Álvarez", "156394872O", "687953214", "alicia@correo.inv", "U", false);
            personas.AnyadirProfesor("Pedro Sanchís", "985623741V", "665322144", "pedro@correo.inv", "Y", false);
            personas.AnyadirProfesor("María Dolores Delgado", "85658974H", "647852146", "maria@correo.inv", "Z", true);
            personas.AnyadirProfesor("Cristina Andrés", "58963874Y", "612345789", "cristina@correo.inv", "W", true);
            personas.AnyadirProfesor("Jesús Olmedo", "195463587M", "699899744", "jesus@correo.inv", "W", false);
            personas.AnyadirNota(0, 5.2);
            personas.AnyadirNota(0, 8.6);
            personas.AnyadirNota(0, 7.5);
            personas.AnyadirNota(4, 6.3);
            personas.AnyadirNota(4, 5.8);
            personas.AnyadirNota(1, 3.0);
            personas.AnyadirNota(1, 0.5);
            personas.AnyadirNota(1, 6.2);
            personas.AnyadirNota(3, 4.5);
            personas.AnyadirNota(3, 6.1);
            personas.AnyadirNota(3, 2.7);
            personas.AnyadirNota(2, 6.8);
            personas.AnyadirAsignatura(0, "Bases de datos");
            personas.AnyadirAsignatura(0, "Programación");
            personas.AnyadirAsignatura(1, "Sistemas Informáticos");
            personas.AnyadirAsignatura(2, "Inglés");
            personas.AnyadirAsignatura(2, "Programación");
            personas.AnyadirAsignatura(3, "Entornos de Desarrollo");
            personas.AnyadirAsignatura(4, "Formación y Orientación Laboral");
            personas.AnyadirAsignatura(5, "Lenguajes de Marcas");
            personas.AnyadirAsignatura(5, "Inglés");

            Auxiliar.MensajeExito();
        }

        // Botón para mostrar la lista de todas las personas dadas de alta (alumnos y profesores)
        private void bMostrarTodos_Click(object sender, EventArgs e)
        {
            personas.MostrarPersonas();
        }

        // Botón para limpiar todas las entradas en las listas
        private void bVaciar_Click(object sender, EventArgs e)
        {
            personas.Limpiar();
        }
    }
}
