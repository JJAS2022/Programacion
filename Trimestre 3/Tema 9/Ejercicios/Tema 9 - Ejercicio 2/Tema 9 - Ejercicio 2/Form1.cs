using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_9___Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlDBHelper sqlDBHelper;

        private int posicion;
        private bool valorCambiado = false;

        //-------------------------------- FUNCIONES --------------------------
        private void ActualizarDatos()
        {
            if (sqlDBHelper.HayDatos())
            {
                DialogResult dr = MessageBox.Show("¿Desea actualizar la información " +
                    "del registro actual?", "¿Actualizar?", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    string id = txtDNI.Text;
                    if (!sqlDBHelper.DniUsado(id) || id == sqlDBHelper.DniActual(posicion))
                    {
                        Profesor profesor = new Profesor(txtDNI.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text);
                        sqlDBHelper.ActualizarProfesor(profesor, posicion);

                        MessageBox.Show("Se ha actualizado la información.");
                    }
                    else
                        MessageBox.Show("El DNI introducido ya está asignado a un profesor.");
                }
                valorCambiado = false;
            }
        }

        private void ActualizarTitulo()
        {
            string titulo = "Registro " + (posicion + 1) + " de " + sqlDBHelper.NumProfesores;
            lblTitulo.Text = titulo;
        }

        private void BuscarProfesor()
        {
            string apellido = txtBusqueda.Text;
            int posicion = sqlDBHelper.BuscarProfesorPorApellido(apellido);

            if (posicion >= 0)
            {
                Profesor profesor = sqlDBHelper.BuscarProfesorPorPosicion(posicion);
               
                string texto = "Resultado de la búsqueda: \n\n";
                texto += "DNI: " + profesor.Dni.ToString() + ".\n";
                texto += "Nombre: " + profesor.Nombre.ToString() + ".\n";
                texto += "Apellido: " + profesor.Apellido.ToString() + ".\n";
                texto += "Teléfono: " + profesor.Telefono.ToString() + ".\n";
                texto += "Email: " + profesor.Email.ToString() + ".\n";

                MessageBox.Show(texto);
            }
            else
                MessageBox.Show("El apellido introducido no concuerda con ningún profesor.");

            txtBusqueda.Clear();
        }

        private void EliminarProfesor()
        {
            if (sqlDBHelper.HayDatos())
            {
                DialogResult dr = MessageBox.Show("¿Está seguro de que desea eliminar " +
                    "el registro actual?", "¿Eliminar?", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    sqlDBHelper.EliminarProfesor(posicion);
                    MessageBox.Show("Registro eliminado.");

                    if (sqlDBHelper.HayDatos())
                    {
                        if (posicion != 0)
                        {
                            posicion--;
                            MostrarDatos(posicion);
                        }
                        else
                        {
                            MostrarDatos(posicion);
                        }
                    }
                    else
                        MostrarRegistroNulo();
                }
            }
        }

        private void GuardarDatos()
        {
            string dni = txtDNI.Text;
            if (!sqlDBHelper.DniUsado(dni) && dni != "")
            {
                DialogResult dr = MessageBox.Show("¿Desea guardar un nuevo registro " +
                    "con la información actual?", "¿Guardar?", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    Profesor profesor = new Profesor(txtDNI.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text);
                    sqlDBHelper.AnyadirProfesor(profesor);

                    posicion = sqlDBHelper.NumProfesores - 1;

                    MessageBox.Show("El profesor se ha añadido correctamente.");

                    MostrarDatos(posicion);
                }
            }
            else
                MessageBox.Show("El DNI introducido ya está asignado a un profesor.");
        }

        private void MostrarDatos(int posicion)
        {
            Profesor profesor = sqlDBHelper.BuscarProfesorPorPosicion(posicion);

            txtDNI.Text = profesor.Dni;
            txtNombre.Text = profesor.Nombre;
            txtApellido.Text = profesor.Apellido;
            txtTelefono.Text = profesor.Telefono;
            txtEmail.Text = profesor.Email;

            ActualizarTitulo();
            valorCambiado = false;
        }

        private void MostrarRegistroNulo()
        {
            txtDNI.Text = "Sin datos";
            txtNombre.Text = "Sin datos";
            txtApellido.Text = "Sin datos";
            txtTelefono.Text = "Sin datos";
            txtEmail.Text = "Sin datos";

            lblTitulo.Text = "Sin datos";
            valorCambiado = false;
        }
 
        //--------------------------------- BOTONES -------------------------
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (sqlDBHelper.HayDatos())
            {
                if (valorCambiado)
                {
                    ActualizarDatos();
                }
                posicion = 0;
                MostrarDatos(posicion);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion != 0 && sqlDBHelper.HayDatos())
            {
                if (valorCambiado)
                {
                    ActualizarDatos();
                }
                posicion--;
                MostrarDatos(posicion);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicion != (sqlDBHelper.NumProfesores - 1) && sqlDBHelper.HayDatos())
            {
                if (valorCambiado)
                {
                    ActualizarDatos();
                }
                posicion++;
                MostrarDatos(posicion);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (sqlDBHelper.HayDatos())
            {
                if (valorCambiado)
                {
                    ActualizarDatos();
                }
                posicion = sqlDBHelper.NumProfesores - 1;
                MostrarDatos(posicion);
            }
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            if (valorCambiado)
            {
                ActualizarDatos();
            }
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDNI.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (valorCambiado)
            {
                ActualizarDatos();
            }
            else
                MessageBox.Show("No hay información que actualizar.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProfesor();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            sqlDBHelper.MostrarTodos();
        }

        private void btnMostrarProfesor_Click(object sender, EventArgs e)
        {
            BuscarProfesor();
        }

        //------------------------------- EVENTOS ---------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlDBHelper = new SqlDBHelper();
            posicion = 0;

            if (sqlDBHelper.HayDatos())
            {
                MostrarDatos(posicion);
            }
            else
                MostrarRegistroNulo();
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            valorCambiado = true;
        }
    }
}
