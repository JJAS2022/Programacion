using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Net;
using System.IO;

namespace Tema_9___Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet dsProfesores;
        SqlDataAdapter da;

        private int posicion;
        private int maxRegistros;
        private bool valorCambiado = false;

        //---------------------------------- FUNCIONES --------------------------------
        private void mostrarRegistro(int posicion)
        {
            DataRow fila = dsProfesores.Tables["Profesores"].Rows[posicion];

            txtDNI.Text = fila["DNI"].ToString();
            txtNombre.Text = fila["Nombre"].ToString();
            txtApellido.Text = fila["Apellido"].ToString();
            txtTelefono.Text = fila["Tlf"].ToString();
            txtEmail.Text = fila["EMail"].ToString();

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

        private void ActualizarRegistro()
        {
            if (HayRegistros())
            {
                DialogResult dr = MessageBox.Show("¿Desea actualizar la información " +
                    "del registro actual?", "¿Actualizar?", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    string id = txtDNI.Text;
                    if (!dniUsado(id) || id == dniActual())
                    {
                        DataRow fila = dsProfesores.Tables["Profesores"].Rows[posicion];

                        fila["DNI"] = txtDNI.Text;
                        fila["Nombre"] = txtNombre.Text;
                        fila["Apellido"] = txtApellido.Text;
                        fila["Tlf"] = txtTelefono.Text;
                        fila["EMail"] = txtEmail.Text;

                        SqlCommandBuilder cb = new SqlCommandBuilder(da);
                        da.Update(dsProfesores, "Profesores");

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
            string titulo = "Registro " + (posicion + 1) + " de " + maxRegistros;
            lblTitulo.Text = titulo;
        }

        private void GuardarRegistro()
        {
            string dni = txtDNI.Text;
            if (!dniUsado(dni) && dni != "")
            {
                DialogResult dr = MessageBox.Show("¿Desea guardar un nuevo registro " +
                    "con la información actual?", "¿Guardar?", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    DataRow fila = dsProfesores.Tables["Profesores"].NewRow();

                    fila["DNI"] = txtDNI.Text;
                    fila["Nombre"] = txtNombre.Text;
                    fila["Apellido"] = txtApellido.Text;
                    fila["Tlf"] = txtTelefono.Text;
                    fila["EMail"] = txtEmail.Text;

                    dsProfesores.Tables["Profesores"].Rows.Add(fila);
                    MessageBox.Show("Se ha creado un nuevo registro.");

                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(dsProfesores, "Profesores");

                    maxRegistros++;
                    posicion = maxRegistros - 1;

                    mostrarRegistro(posicion);
                }
            }
            else
                MessageBox.Show("El DNI introducido ya está asignado a un profesor.");
        }

        private bool HayRegistros()
        {
            bool hay = false;

            if (maxRegistros > 0)
            {
                hay = true;
            }

            return hay;
        }

        private int BuscarPorApellido(string apellido)
        {
            int posicion = -1;
            DataRow fila;
            string apell;
            
            for (int i = 0; i < maxRegistros; i++)
            {
                fila = dsProfesores.Tables["Profesores"].Rows[i];
                apell = fila["Apellido"].ToString();
                if (apell == apellido)
                {
                    posicion = i;
                }
            }

            return posicion; 
        }

        private string dniActual()
        {
            DataRow fila = dsProfesores.Tables["Profesores"].Rows[posicion];
            string dni = fila["DNI"].ToString();

            return dni;
        }

        private bool dniUsado(string dni)
        {
            bool usado = false;
            DataRow fila;
            string id;

            for (int i = 0; i < maxRegistros; i++)
            {
                fila = dsProfesores.Tables["Profesores"].Rows[i];
                id = fila["DNI"].ToString();
                if (id == dni)
                {
                    usado = true;
                }
            }

            return usado;
        }

        private void MostrarTodos()
        {
            string texto = "Lista de profesores:\n\n";
            DataRow fila;

            for (int i = 0; i < maxRegistros; i++)
            {
                fila = dsProfesores.Tables["Profesores"].Rows[i];

                texto += "DNI: " + fila["DNI"].ToString() + ".\n";
                texto += "Nombre: " + fila["Nombre"].ToString() + ".\n";
                texto += "Apellido: " + fila["Apellido"].ToString() + ".\n";
                texto += "Teléfono: " + fila["Tlf"].ToString() + ".\n";
                texto += "Email: " + fila["EMail"].ToString() + ".\n";
                texto += "\n";
            }

            MessageBox.Show(texto);
        }

        private void MostrarProfesor()
        {
            string apellido = txtBusqueda.Text;
            int posicion = BuscarPorApellido(apellido);

            if (posicion >= 0)
            {
                DataRow fila = dsProfesores.Tables["Profesores"].Rows[posicion];

                string texto = "Resultado de la búsqueda: \n\n";
                texto += "DNI: " + fila["DNI"].ToString() + ".\n";
                texto += "Nombre: " + fila["Nombre"].ToString() + ".\n";
                texto += "Apellido: " + fila["Apellido"].ToString() + ".\n";
                texto += "Teléfono: " + fila["Tlf"].ToString() + ".\n";
                texto += "Email: " + fila["EMail"].ToString() + ".\n";

                MessageBox.Show(texto);
            }
            else
                MessageBox.Show("El apellido introducido no concuerda con ningún profesor.");

            txtBusqueda.Clear();
        }

        private void EliminarRegistro()
        {
            if (HayRegistros())
            {
                DialogResult dr = MessageBox.Show("¿Está seguro de que desea eliminar " +
                    "el registro actual?", "¿Eliminar?", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    dsProfesores.Tables["Profesores"].Rows[posicion].Delete();
                    MessageBox.Show("Registro eliminado.");

                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(dsProfesores, "Profesores");

                    maxRegistros--;
                    if (HayRegistros())
                    {
                        if (posicion != 0)
                        {
                            posicion--;
                            mostrarRegistro(posicion);
                        }
                        else
                        {
                            mostrarRegistro(posicion);
                        }
                    }
                    else
                        MostrarRegistroNulo();
                }
            }
        }

        private void MetodoPath()
        {
            string relative = @"..\..\";
            string absolute = Path.GetFullPath(relative);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);
        }
  
        // --------------------------------- BOTONES ----------------------------------
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (HayRegistros())
            {
                if (valorCambiado)
                {
                    ActualizarRegistro();                 
                }
                posicion = 0;
                mostrarRegistro(posicion);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion != 0 && HayRegistros())
            {
                if (valorCambiado)
                {
                    ActualizarRegistro();                   
                }
                posicion--;
                mostrarRegistro(posicion);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicion != maxRegistros - 1 && HayRegistros())
            {
                if (valorCambiado)
                {
                    ActualizarRegistro();                    
                }
                posicion++;
                mostrarRegistro(posicion);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (HayRegistros())
            {
                if (valorCambiado)
                {
                    ActualizarRegistro();
                }
                posicion = maxRegistros - 1;
                mostrarRegistro(posicion);
            }
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            if (valorCambiado)
            {
                ActualizarRegistro();
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
            GuardarRegistro();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (valorCambiado)
            {
                ActualizarRegistro();
            }
            else
                MessageBox.Show("No hay información que actualizar.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            MostrarTodos();                    
        }

        private void btnMostrarProfesor_Click(object sender, EventArgs e)
        {
            MostrarProfesor();                      
        }

        // -------------------------------- EVENTOS -----------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            MetodoPath();
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\AppData\\Instituto.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            conexion.Open();

            dsProfesores = new DataSet();

            string cadenaSQL = "SELECT * FROM Profesores";
            da = new SqlDataAdapter(cadenaSQL, conexion);
            da.Fill(dsProfesores, "Profesores");

            posicion = 0;
            maxRegistros = dsProfesores.Tables["Profesores"].Rows.Count;

            if (HayRegistros())
            {
                mostrarRegistro(posicion);
            }
            else
                MostrarRegistroNulo();
         
            conexion.Close();
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            valorCambiado = true;
        }
    }
}
