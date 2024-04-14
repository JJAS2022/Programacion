using Microsoft.VisualBasic.Logging;
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
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
        }

        // Puntero a la instancia de la clase SqlAlumnos del formulario principal
        public SqlAlumnos sqlAlumnos;

        // Variable global para controlar la posicion del alumno que se muestra
        private int posicion;

        // Variable global para controlar el cambio en los textBox
        private bool valorCambiado = false;

        // ----------------------------- FUNCIONES ---------------------------------       
        private void ActualizarControles()
        {
            if (HayDatos())
            {
                btnMostrarTodos.Enabled = true;
                btnBuscarDni.Enabled = true;
                btnBuscarPorApellido.Enabled = true;
                btnAnyadir.Enabled = true;
                btnActualizar.Visible = true;
                btnActualizar.Enabled = false;
                btnGuardar.Visible = false;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = true;

                if (posicion == 0 && Registros() == 1)
                {
                    btnInicial.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnUltimo.Enabled = false;
                    btnSiguiente.Enabled = false;
                }
                else if (posicion == 0 && Registros() > 1)
                {
                    btnInicial.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnUltimo.Enabled = true;
                    btnSiguiente.Enabled = true;
                }
                else if (posicion == Registros() - 1)
                {
                    btnUltimo.Enabled = false;
                    btnSiguiente.Enabled = false;
                    btnInicial.Enabled = true;
                    btnAnterior.Enabled = true;
                }
                else
                {
                    btnInicial.Enabled = true;
                    btnAnterior.Enabled = true;
                    btnSiguiente.Enabled = true;
                    btnUltimo.Enabled = true;
                }
            }
            else
            {
                btnInicial.Enabled = false;
                btnAnterior.Enabled = false;
                btnUltimo.Enabled = false;
                btnSiguiente.Enabled = false;
                btnAnyadir.Enabled = true;
                btnActualizar.Visible = true;
                btnActualizar.Enabled = false;
                btnGuardar.Visible = false;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = false;
                btnMostrarTodos.Enabled = false;
                btnBuscarDni.Enabled = false;
                btnBuscarPorApellido.Enabled = false;
            }
        }

        // Actualiza la fila de la base de datos correspondiente a la posición actual
        private void ActualizarDatos()
        {
            // Variables locales para controlar el input del usuario
            string dni = txtDni.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string direccion = txtDireccion.Text;

            // Controla que los campos no estén vacíos
            if (dni != "" && nombre != "" && apellido != "" && telefono != "" && email != "" && direccion != "")
            {
                // Controla que no se repitan los campos de valores únicos, salvo que sean de la posicion actual a actualizar
                if ((!DniAsignado(dni) || MismoDni(dni)) && (!TelefonoAsignado(telefono) || MismoTelefono(telefono)) && (!EmailAsignado(email) || MismoEmail(email)))
                {
                    // Pregunta si desea guardar datos
                    DialogResult dr = MessageBox.Show("¿Desea actualizar el registro con los datos introducidos?", "¿Guardar?", MessageBoxButtons.YesNo);

                    // Si la respuesta es sí, actualiza la base de datos
                    if (dr == DialogResult.Yes)
                    {
                        Alumno alumno = new Alumno(dni, nombre, apellido, telefono, email, direccion);
                        sqlAlumnos.ActualizarAlumno(alumno, posicion);

                        MessageBox.Show("El alumno se ha actualizado correctamente.");

                        MostrarDatos(posicion);
                    }
                }
                else
                    MessageBox.Show("El DNI, teléfono o email introducidos ya están asignados a un alumno.");
            }
            else
            {
                MessageBox.Show("Los campos del formulario no pueden estar vacíos.");
            }
        }

        // Actualiza el título del formulario según la situación
        private void ActualizarTitulo()
        {
            string titulo;

            if (HayDatos())
                titulo = "Alumno " + (posicion + 1) + " de " + Registros();
            else
                titulo = "No hay alumnos";

            lblTitulo.Text = titulo;
        }

        // Localiza un alumno por el dni introducido por el usuario
        private void BuscarPorDni()
        {
            string dni = txtBusqueda.Text;

            if (dni != "Buscar...")
            {
                int posicion = sqlAlumnos.BuscarAlumnoPorDni(dni);

                if (posicion >= 0)
                {
                    Alumno alumno = sqlAlumnos.BuscarAlumnoPorPosicion(posicion);

                    string texto = "Resultado de la búsqueda: \n\n";
                    texto += "DNI: " + alumno.Dni.ToString() + ".\n";
                    texto += "Nombre: " + alumno.Nombre.ToString() + ".\n";
                    texto += "Apellido: " + alumno.Apellido.ToString() + ".\n";
                    texto += "Teléfono: " + alumno.Telefono.ToString() + ".\n";
                    texto += "Email: " + alumno.Email.ToString() + ".\n";
                    texto += "Dirección: " + alumno.Direccion.ToString() + ".\n";

                    MessageBox.Show(texto);
                }
                else
                    MessageBox.Show("El DNI introducido no concuerda con ningún alumno.");

                RestablecerCampoBusqueda();
            }
            else
                MessageBox.Show("Introduzca el DNI del alumno que desea localizar.");
        }

        // Localiza un alumno por el apellido introducido por el usuario
        private void BuscarPorApellido()
        {
            string apellido = txtBusqueda.Text;

            if (apellido != "Buscar...")
            {
                int posicion = sqlAlumnos.BuscarAlumnoPorApellido(apellido);

                if (posicion >= 0)
                {
                    Alumno alumno = sqlAlumnos.BuscarAlumnoPorPosicion(posicion);

                    string texto = "Resultado de la búsqueda: \n\n";
                    texto += "DNI: " + alumno.Dni.ToString() + ".\n";
                    texto += "Nombre: " + alumno.Nombre.ToString() + ".\n";
                    texto += "Apellido: " + alumno.Apellido.ToString() + ".\n";
                    texto += "Teléfono: " + alumno.Telefono.ToString() + ".\n";
                    texto += "Email: " + alumno.Email.ToString() + ".\n";
                    texto += "Dirección: " + alumno.Direccion.ToString() + ".\n";

                    MessageBox.Show(texto);
                }
                else
                    MessageBox.Show("El apellido introducido no concuerda con ningún alumno.");

                RestablecerCampoBusqueda();
            }
            else
                MessageBox.Show("Introduzca el apellido del alumno que desea localizar.");
        }

        // Cancela la operación de modificación 
        private void Cancelar()
        {
            // Pregunta si desea cancelar la operación
            DialogResult dr = MessageBox.Show("¿Desea continuar sin guardar los datos?", "¿Cancelar?", MessageBoxButtons.YesNo);

            // Si la respuesta es sí, actualiza la base de datos
            if (dr == DialogResult.Yes)
            {
                MostrarDatos(posicion);
            }
        }

        // Comprueba que el código introducido no se repita
        private bool DniAsignado(string dni)
        {
            bool asignado = false;
            int posicion = sqlAlumnos.BuscarAlumnoPorDni(dni);

            if (posicion >= 0)
            {
                asignado = true;
            }

            return asignado;
        }

        // Comprueba que el teléfono introducido no se repita
        private bool EmailAsignado(string email)
        {
            bool asignado = false;
            int posicion = sqlAlumnos.BuscarAlumnoPorEmail(email);

            if (posicion >= 0)
            {
                asignado = true;
            }

            return asignado;
        }

        // Elimina los datos de la posición actual
        private void EliminarDatos()
        {
            // Pregunta si desea eliminar los datos
            DialogResult dr = MessageBox.Show("¿Desea eliminar los datos del registro actual?", "¿Eliminar?", MessageBoxButtons.YesNo);

            // Si la respuesta es sí, actualiza la base de datos
            if (dr == DialogResult.Yes)
            {
                sqlAlumnos.EliminarAlumno(posicion);

                // Feedback al usuario sobre la operación
                MessageBox.Show("Alumno eliminado de la base de datos.");

                // Muestra los campos según la situación
                if (HayDatos())
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
                    MostrarSinDatos();
            }
            else
                MostrarDatos(posicion);
        }

        // Guarda los datos introducidos por el usuario si son correctos
        private void GuardarDatos()
        {
            // Variables locales para controlar el input del usuario
            string dni = txtDni.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string direccion = txtDireccion.Text;

            // Controla que los campos no estén vacíos
            if (dni != "" && nombre != "" && apellido != "" && telefono != "" && email != "")
            {
                // Controla que no se repitan los campos de valores únicos
                if (!DniAsignado(dni) && !TelefonoAsignado(telefono) && !EmailAsignado(email))
                {
                    // Pregunta si desea guardar datos
                    DialogResult dr = MessageBox.Show("¿Desea guardar los datos introducidos?", "¿Guardar?", MessageBoxButtons.YesNo);

                    // Si la respuesta es sí, actualiza la base de datos
                    if (dr == DialogResult.Yes)
                    {
                        Alumno alumno = new Alumno(dni, nombre, apellido, telefono, email, direccion);
                        sqlAlumnos.AnyadirAlumno(alumno);

                        posicion = Registros() - 1;

                        MessageBox.Show("El alumno se ha añadido correctamente.");

                        MostrarDatos(posicion);
                    }
                }
                else
                    MessageBox.Show("El DNI, teléfono o email introducidos ya están asignados a un alumno.");
            }
            else
            {
                MessageBox.Show("Los campos del formulario no pueden estar vacíos.");
            }
        }

        // Comprueba que haya registros en la base de datos
        private bool HayDatos()
        {
            bool hay = false;

            if (Registros() > 0)
            {
                hay = true;
            }

            return hay;
        }

        // Elimina los datos de los campos del formulario
        private void LimpiarDatos()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            lblTitulo.Text = "Nuevo alumno";
        }

        // Comprueba si el dni de la posición actual es igual al introducido por el usuario
        private bool MismoDni(string dni)
        {
            bool mismo = false;

            if (dni == sqlAlumnos.DniActual(posicion))
                mismo = true;

            return mismo;
        }

        // Comprueba si el email de la posición actual es igual al introducido por el usuario
        private bool MismoEmail(string email)
        {
            bool mismo = false;

            if (email == sqlAlumnos.EmailActual(posicion))
                mismo = true;

            return mismo;
        }

        // Comprueba si el teléfono de la posición actual es igual al introducido por el usuario
        private bool MismoTelefono(string telefono)
        {
            bool mismo = false;

            if (telefono == sqlAlumnos.TelefonoActual(posicion))
                mismo = true;

            return mismo;
        }

        // Muestra en el formulario los datos de la posición que se le pasa
        private void MostrarDatos(int posicion)
        {
            Alumno alumno = sqlAlumnos.BuscarAlumnoPorPosicion(posicion);

            txtDni.Text = alumno.Dni;
            txtNombre.Text = alumno.Nombre;
            txtApellido.Text = alumno.Apellido;
            txtTelefono.Text = alumno.Telefono;
            txtEmail.Text = alumno.Email;
            txtDireccion.Text = alumno.Direccion;

            // Actualiza los botones según la situación
            ActualizarControles();

            // Actualiza el título del formulario según la situación
            ActualizarTitulo();

            // Actualiza el valor a false porque al mostrar los datos lo toma como TextChanged
            valorCambiado = false;

            // Evita que se seleccionen campos por defecto
            lblTitulo.Focus();
        }

        // Muestra que no hay datos en los campos del formulario
        private void MostrarSinDatos()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";

            ActualizarControles();
            ActualizarTitulo();
        }

        // Abre en otro formulario un DataGridView con todos los datos de la tabla correspondiente
        private void MostrarTodos()
        {
            FormDatosAlumnos formDatos = new FormDatosAlumnos();
            formDatos.sqlAlumnos = sqlAlumnos;
            formDatos.ShowDialog();
        }

        // Obtiene el número de registros existentes en la base de datos
        private int Registros()
        {
            int registros = sqlAlumnos.Alumnos;

            return registros;
        }

        // Repone el texto en el campo de búsqueda en cursiva
        private void RestablecerCampoBusqueda()
        {
            txtBusqueda.Font = new Font(txtBusqueda.Font, FontStyle.Italic);
            txtBusqueda.Text = "Buscar...";
        }

        // Comprueba que el teléfono introducido no se repita
        private bool TelefonoAsignado(string telefono)
        {
            bool asignado = false;
            int posicion = sqlAlumnos.BuscarAlumnoPorTelefono(telefono);

            if (posicion >= 0)
            {
                asignado = true;
            }

            return asignado;
        }

        // ------------------------------ BOTONES ----------------------------------
        // ----------------------- BOTONES DE NAVEGACIÓN --------------------------- 
        private void btnInicial_Click(object sender, EventArgs e)
        {
            if (HayDatos())
            {
                posicion = 0;
                MostrarDatos(posicion);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion != 0 && HayDatos())
            {
                posicion--;
                MostrarDatos(posicion);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicion != (Registros() - 1) && HayDatos())
            {
                posicion++;
                MostrarDatos(posicion);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (HayDatos())
            {
                posicion = Registros() - 1;
                MostrarDatos(posicion);
            }
        }

        // ----------------------- BOTONES DE MODIFICACIÓN ---------------------------       
        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            // Actualiza el título y los campos del formulario           
            LimpiarDatos();

            // Hace visible el botón Guardar y oculta el de Actualizar
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;

            // Activa los botones Guardar / Cancelar
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            // Desactiva el resto de botones del formulario
            btnInicial.Enabled = false;
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;
            btnAnyadir.Enabled = false;
            btnEliminar.Enabled = false;
            btnMostrarTodos.Enabled = false;
            btnBuscarDni.Enabled = false;
            btnBuscarPorApellido.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
        }

        // ----------------------- BOTONES PARA MOSTRAR DATOS ---------------------------       
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            MostrarTodos();
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            BuscarPorDni();
        }

        private void btnBuscarPorApellido_Click(object sender, EventArgs e)
        {
            BuscarPorApellido();
        }

        // ------------------------------ EVENTOS ----------------------------------
        // Se dispara al cargar el formulario
        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            posicion = 0;
            if (HayDatos())
            {
                MostrarDatos(posicion);
            }
            else
                MostrarSinDatos();
        }

        // Se dispara al variar los valores en los campos del formulario
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            // Actualiza el valor de la variable global
            valorCambiado = true;

            // Activa los botones Actualizar / Cancelar
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;

            // Desactiva el resto de botones del formulario
            btnInicial.Enabled = false;
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;
            btnAnyadir.Enabled = false;
            btnEliminar.Enabled = false;
            btnMostrarTodos.Enabled = false;
            btnBuscarDni.Enabled = false;
            btnBuscarPorApellido.Enabled = false;
        }

        // Se dispara al pinchar el textBox de búsqueda y lo limpia
        private void txtBusqueda_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            txtBusqueda.Font = new Font(txtBusqueda.Font, FontStyle.Regular);
        }

        // Se dispara al cerrar el formulario sin guardar cambios
        private void FormAlumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (valorCambiado)
            {
                // Pregunta si desea salir del formulario sin guardar
                DialogResult dr = MessageBox.Show("¿Desea salir sin guardar los cambios?", "¿Salir?", MessageBoxButtons.YesNo);

                // Si la respuesta es no, cancela el evento de salida
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        // Se dispara al pinchar en cualquier parte libre del formulario
        private void FormAlumnos_Click(object sender, EventArgs e)
        {
            RestablecerCampoBusqueda();
        }      
    }
}
