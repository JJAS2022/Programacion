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
    public partial class FormDatosCursos : Form
    {
        public FormDatosCursos()
        {
            InitializeComponent();
        }

        public SqlCursos sqlCursos;
        private string nombre;
        private string codigo;

        // Rellena el DataGridView con los datos de la base de datos de Cursos
        private void RellenarDGV()
        {
            for (int i = 0; i < sqlCursos.Cursos; i++)
            {
                Curso curso = sqlCursos.BuscarCursoPorPosicion(i);

                nombre = curso.Nombre;
                codigo = curso.Codigo;

                dgvCursos.Rows.Add();
                dgvCursos.Rows[i].Cells[0].Value = nombre;
                dgvCursos.Rows[i].Cells[1].Value = codigo;
            }
        }

        // Se dispara al cargar el formulario
        private void FormDatosCursos_Load(object sender, EventArgs e)
        {
            RellenarDGV(); 
        }
    }
}
