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
    public partial class FormDatosAlumnos : Form
    {
        public FormDatosAlumnos()
        {
            InitializeComponent();
        }

        public SqlAlumnos sqlAlumnos;
        private string dni;
        private string nombre;
        private string apellido;
        private string telefono;
        private string email;
        private string direccion;

        // Rellena el DataGridView con los datos de la base de datos de alumnos
        private void RellenarDGV()
        {
            for (int i = 0; i < sqlAlumnos.Alumnos; i++)
            {
                Alumno alumno = sqlAlumnos.BuscarAlumnoPorPosicion(i);

                dni = alumno.Dni;
                nombre = alumno.Nombre;
                apellido = alumno.Apellido;
                telefono = alumno.Telefono;
                email = alumno.Email;
                direccion = alumno.Direccion;

                dgvAlumnos.Rows.Add();
                dgvAlumnos.Rows[i].Cells[0].Value = dni;
                dgvAlumnos.Rows[i].Cells[1].Value = nombre;
                dgvAlumnos.Rows[i].Cells[2].Value = apellido;
                dgvAlumnos.Rows[i].Cells[3].Value = telefono;
                dgvAlumnos.Rows[i].Cells[4].Value = email;
                dgvAlumnos.Rows[i].Cells[5].Value = direccion;
            }
        }

        // Se dispara al cargar el formulario
        private void FormDatosAlumnos_Load(object sender, EventArgs e)
        {
            RellenarDGV();
        }
    }
}
