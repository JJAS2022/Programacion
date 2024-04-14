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
    public partial class FormProfesores : Form
    {
        public FormProfesores()
        {
            InitializeComponent();
        }

        // Puntero a la instancia de la clase SqlProfesores del formulario principal
        public SqlProfesores sqlProfesores;

        // Variable global para controlar la posicion del profesor que se muestra
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

            // Controla que los campos no estén vacíos
            if (dni != "" && nombre != "" && apellido != "" && telefono != "" && email != "")
            {
                // Controla que no se repitan los campos de valores únicos, salvo que sean de la posicion actual a actualizar
                if ((!DniAsignado(dni) || MismoDni(dni)) && (!TelefonoAsignado(telefono) || MismoTelefono(telefono)) && (!EmailAsignado(email) || MismoEmail(email)))
                {
                    // Pregunta si desea guardar datos
                    DialogResult dr = MessageBox.Show("¿Desea actualizar el registro con los datos introducidos?", "¿Guardar?", MessageBoxButtons.YesNo);

                    // Si la respuesta es sí, actualiza la base de datos
                    if (dr == DialogResult.Yes)
                    {
                        Profesor profesor = new Profesor(dni, nombre, apellido, telefono, email);
                        sqlProfesores.ActualizarProfesor(profesor, posicion);

                        MessageBox.Show("El profesor se ha actualizado correctamente.");

                        MostrarDatos(posicion);
                    }
                }
                else
                    MessageBox.Show("El DNI, teléfono o email introducidos ya están asignados a un profesor.");
            }
            else
            {
                MessageBox.Show("Los campos del formulario no pueden estar vacíos. ");
            }
        }

        // Actualiza el título del formulario según la situación
        private void ActualizarTitulo()
        {
            string titulo;

            if (HayDatos())
                titulo = "Profesor " + (posicion + 1) + " de " + Registros();
            else
                titulo = "No hay profesores";

            lblTitulo.Text = titulo;
        }

        // Localiza un profesor por el dni introducido por el usuario
        private void BuscarPorDni()
        {
            string dni = txtBusqueda.Text;

            if (dni != "Buscar...")
            {
                int posicion = sqlProfesores.BuscarProfesorPorDni(dni);

                if (posicion >= 0)
                {
                    Profesor profesor = sqlProfesores.BuscarProfesorPorPosicion(posicion);

                    string texto = "Resultado de la búsqueda: \n\n";
                    texto += "DNI: " + profesor.Dni.ToString() + ".\n";
                    texto += "Nombre: " + profesor.Nombre.ToString() + ".\n";
                    texto += "Apellido: " + profesor.Apellido.ToString() + ".\n";
                    texto += "Teléfono: " + profesor.Telefono.ToString() + ".\n";
                    texto += "Email: " + profesor.Email.ToString() + ".\n";

                    MessageBox.Show(texto);
                }
                else
                    MessageBox.Show("El DNI introducido no concuerda con ningún profesor.");

                RestablecerCampoBusqueda();
            }
            else
                MessageBox.Show("Introduzca el DNI del profesor que desea localizar.");
        }

        // Localiza un profesor por el apellido introducido por el usuario
        private void BuscarPorApellido()
        {
            string apellido = txtBusqueda.Text;

            if (apellido != "Buscar...")
            {
                int posicion = sqlProfesores.BuscarProfesorPorApellido(apellido);

                if (posicion >= 0)
                {
                    Profesor profesor = sqlProfesores.BuscarProfesorPorPosicion(posicion);

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

                RestablecerCampoBusqueda();
            }
            else
                MessageBox.Show("Introduzca el apellido del profesor que desea localizar.");
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
            int posicion = sqlProfesores.BuscarProfesorPorDni(dni);

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
            int posicion = sqlProfesores.BuscarProfesorPorEmail(email);

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
                sqlProfesores.EliminarProfesor(posicion);

                // Feedback al usuario sobre la operación
                MessageBox.Show("Profesor eliminado de la base de datos.");

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
                        Profesor profesor = new Profesor(dni, nombre, apellido, telefono, email);
                        sqlProfesores.AnyadirProfesor(profesor);

                        posicion = Registros() - 1;

                        MessageBox.Show("El profesor se ha añadido correctamente.");

                        MostrarDatos(posicion);
                    }
                }
                else
                    MessageBox.Show("El DNI, teléfono o email introducidos ya están asignados a un profesor.");
            }
            else
            {
                MessageBox.Show("Los campos del formulario no pueden estar vacíos. ");
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
            lblTitulo.Text = "Nuevo profesor";
        }

        // Comprueba si el dni de la posición actual es igual al introducido por el usuario
        private bool MismoDni(string dni)
        {
            bool mismo = false;

            if (dni == sqlProfesores.DniActual(posicion))
                mismo = true;

            return mismo;
        }

        // Comprueba si el email de la posición actual es igual al introducido por el usuario
        private bool MismoEmail(string email)
        {
            bool mismo = false;

            if (email == sqlProfesores.EmailActual(posicion))
                mismo = true;

            return mismo;
        }

        // Comprueba si el teléfono de la posición actual es igual al introducido por el usuario
        private bool MismoTelefono(string telefono)
        {
            bool mismo = false;

            if (telefono == sqlProfesores.TelefonoActual(posicion))
                mismo = true;

            return mismo;
        }

        // Muestra en el formulario los datos de la posición que se le pasa
        private void MostrarDatos(int posicion)
        {
            Profesor profesor = sqlProfesores.BuscarProfesorPorPosicion(posicion);

            txtDni.Text = profesor.Dni;
            txtNombre.Text = profesor.Nombre;
            txtApellido.Text = profesor.Apellido;
            txtTelefono.Text = profesor.Telefono;
            txtEmail.Text = profesor.Email;

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
            txtDni.Text = "Sin datos";
            txtNombre.Text = "Sin datos";
            txtApellido.Text = "Sin datos";
            txtTelefono.Text = "Sin datos";
            txtEmail.Text = "Sin datos";

            ActualizarControles();
            ActualizarTitulo();
        }

        // Abre en otro formulario un DataGridView con todos los datos de la tabla correspondiente
        private void MostrarTodos()
        {
            FormDatosProfesores formDatos = new FormDatosProfesores();
            formDatos.sqlProfesores = sqlProfesores;
            formDatos.ShowDialog();
        }

        // Obtiene el número de registros existentes en la base de datos
        private int Registros()
        {
            int registros = sqlProfesores.Profesores;

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
            int posicion = sqlProfesores.BuscarProfesorPorTelefono(telefono);

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
        private void FormProfesores_Load(object sender, EventArgs e)
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
        private void FormProfesores_FormClosing(object sender, FormClosingEventArgs e)
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
        private void FormProfesores_Click(object sender, EventArgs e)
        {
            RestablecerCampoBusqueda();
        }
    }
}
