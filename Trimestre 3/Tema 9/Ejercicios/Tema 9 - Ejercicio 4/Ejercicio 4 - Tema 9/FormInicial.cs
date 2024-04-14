using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4___Tema_9
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        // Declaración de instancias de las clases de las bases de datos
        SqlCursos sqlCursos;
        SqlAlumnos sqlAlumnos;
        SqlProfesores sqlProfesores;

        // ---------------------------- EVENTOS --------------------------
        private void FormInicial_Load(object sender, EventArgs e)
        {
            // Inicialización de la instancia de la clase SqlDBHelper al cargar el formulario inicial
            sqlCursos = new SqlCursos();
            sqlAlumnos = new SqlAlumnos();
            sqlProfesores = new SqlProfesores();
        }

        // ---------------------------- BOTONES --------------------------
        // Cada botón instancia el formulario correspondiente y le pasa la instancia principal de la 
        // base de datos a los punteros de cada formulario para que se pueda modificar desde allí.
        private void bCursos_Click(object sender, EventArgs e)
        {
            FormCursos formCursos = new FormCursos();
            formCursos.sqlCursos = sqlCursos;
            formCursos.ShowDialog();
        }

        private void bAlumnos_Click(object sender, EventArgs e)
        {
            FormAlumnos formAlumnos = new FormAlumnos();
            formAlumnos.sqlAlumnos = sqlAlumnos;
            formAlumnos.ShowDialog();
        }

        private void bProfesores_Click(object sender, EventArgs e)
        {
            FormProfesores formProfesores = new FormProfesores();
            formProfesores.sqlProfesores = sqlProfesores;
            formProfesores.ShowDialog();
        }
    }
}
