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
    public partial class FormDatosProfesores : Form
    {
        public FormDatosProfesores()
        {
            InitializeComponent();
        }

        public SqlProfesores sqlProfesores;
        private string dni;
        private string nombre;
        private string apellido;
        private string telefono;
        private string email;

        // Rellena el DataGridView con los datos de la base de datos de profesores
        private void RellenarDGV()
        {
            for (int i = 0; i < sqlProfesores.Profesores; i++)
            {
                Profesor profesor = sqlProfesores.BuscarProfesorPorPosicion(i);

                dni = profesor.Dni;
                nombre = profesor.Nombre;
                apellido = profesor.Apellido;
                telefono = profesor.Telefono;
                email = profesor.Email;

                dgvProfesores.Rows.Add();
                dgvProfesores.Rows[i].Cells[0].Value = dni;
                dgvProfesores.Rows[i].Cells[1].Value = nombre;
                dgvProfesores.Rows[i].Cells[2].Value = apellido;
                dgvProfesores.Rows[i].Cells[3].Value = telefono;
                dgvProfesores.Rows[i].Cells[4].Value = email;
            }
        }

        // Se dispara al cargar el formulario
        private void FormDatosProfesores_Load(object sender, EventArgs e)
        {
            RellenarDGV();
        }
    }
}
