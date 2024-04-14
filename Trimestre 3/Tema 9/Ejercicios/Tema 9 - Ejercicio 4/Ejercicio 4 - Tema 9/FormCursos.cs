using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4___Tema_9
{
    public partial class FormCursos : Form
    {
        public FormCursos()
        {
            InitializeComponent();
        }

        // Puntero a la instancia de la clase SqlCurso del formulario principal
        public SqlCursos sqlCursos;

        // Variable global para controlar la posicion del curso que se muestra
        private int posicion;

        // Variable global para controlar el cambio en los textBox
        private bool valorCambiado = false;

        // ----------------------------- FUNCIONES ---------------------------------       
        // Activa o desactiva los botones del formulario según la situación
        private void ActualizarControles()
        {
            if (HayDatos())
            {               
                btnMostrarTodos.Enabled = true;
                btnBuscarNombre.Enabled = true;
                btnBuscarPorCodigo.Enabled = true;
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
                btnBuscarNombre.Enabled = false;
                btnBuscarPorCodigo.Enabled = false;               
            }
        }

        // Actualiza la fila de la base de datos correspondiente a la posición actual
        private void ActualizarDatos()
        {
            // Variables locales para controlar el input del usuario
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;

            // Controla que los campos no estén vacíos
            if (codigo != "" && nombre != "")
            {
                // Controla que no se repitan los campos de valores únicos, salvo que sean de la posicion actual a actualizar
                if ((!CodigoAsignado(codigo) || MismoCodigo(codigo)) && (!NombreAsignado(nombre) || MismoNombre(nombre)))
                {
                    // Pregunta si desea guardar datos
                    DialogResult dr = MessageBox.Show("¿Desea actualizar el registro con los datos introducidos?", "¿Guardar?", MessageBoxButtons.YesNo);

                    // Si la respuesta es sí, actualiza la base de datos
                    if (dr == DialogResult.Yes)
                    {
                        Curso curso = new Curso(nombre, codigo);
                        sqlCursos.ActualizarCurso(curso, posicion);

                        MessageBox.Show("El curso se ha actualizado correctamente.");

                        MostrarDatos(posicion);
                    }
                }
                else
                    MessageBox.Show("El código o el nombre introducidos ya están asignados a un curso.");
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
                titulo = "Curso " + (posicion + 1) + " de " + Registros();
            else
                titulo = "No hay cursos.";

            lblTitulo.Text = titulo;
        }

        // Localiza un curso por el código introducido por el usuario
        private void BuscarPorCodigo()
        {
            string codigo = txtBusqueda.Text;

            if (codigo != "Buscar...")
            {
                int posicion = sqlCursos.BuscarCursoPorCodigo(codigo);

                if (posicion >= 0)
                {
                    Curso curso = sqlCursos.BuscarCursoPorPosicion(posicion);

                    string texto = "Resultado de la búsqueda: \n\n";
                    texto += "Nombre: " + curso.Nombre.ToString() + ".\n";
                    texto += "Código: " + curso.Codigo.ToString() + ".\n";

                    MessageBox.Show(texto);
                }
                else
                    MessageBox.Show("El código introducido no concuerda con ningún curso.");

                RestablecerCampoBusqueda();
            }
            else
                MessageBox.Show("Introduzca el código del curso que desea localizar.");
        }

        // Localiza un curso por el nombre introducido por el usuario
        private void BuscarPorNombre()
        {
            string nombre = txtBusqueda.Text;

            if (nombre != "Buscar...")
            {
                int posicion = sqlCursos.BuscarCursoPorNombre(nombre);

                if (posicion >= 0)
                {
                    Curso curso = sqlCursos.BuscarCursoPorPosicion(posicion);

                    string texto = "Resultado de la búsqueda: \n\n";
                    texto += "Nombre: " + curso.Nombre.ToString() + ".\n";
                    texto += "Código: " + curso.Codigo.ToString() + ".\n";

                    MessageBox.Show(texto);
                }
                else
                    MessageBox.Show("El nombre introducido no concuerda con ningún curso.");

                RestablecerCampoBusqueda();
            }
            else
                MessageBox.Show("Introduzca el nombre del curso que desea localizar.");
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
        private bool CodigoAsignado(string codigo)
        {
            bool asignado = false;           
            int posicion = sqlCursos.BuscarCursoPorCodigo(codigo);

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
                sqlCursos.EliminarCurso(posicion);

                // Feedback al usuario sobre la operación
                MessageBox.Show("Curso eliminado de la base de datos.");

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
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;

            // Controla que los campos no estén vacíos
            if (codigo != "" && nombre != "")
            { 
                // Controla que no se repitan los campos de valores únicos
                if (!CodigoAsignado(codigo) && !NombreAsignado(nombre))
                {
                    // Pregunta si desea guardar datos
                    DialogResult dr = MessageBox.Show("¿Desea guardar los datos introducidos?", "¿Guardar?", MessageBoxButtons.YesNo);

                    // Si la respuesta es sí, actualiza la base de datos
                    if (dr == DialogResult.Yes)
                    {
                        Curso curso = new Curso(nombre, codigo);
                        sqlCursos.AnyadirCurso(curso);

                        posicion = Registros() - 1;

                        MessageBox.Show("El curso se ha añadido correctamente.");

                        MostrarDatos(posicion);
                    }
                }
                else
                    MessageBox.Show("El código o el nombre introducidos ya están asignados a un curso.");
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
            txtNombre.Clear();
            txtCodigo.Clear();
            lblTitulo.Text = "Nuevo curso";
        }

        // Comprueba si el código del curso en la posición actual es igual al introducido por el usuario
        private bool MismoCodigo(string codigo)
        {
            bool mismo = false;

            if (codigo == sqlCursos.CodigoActual(posicion))
                mismo = true;

            return mismo;
        }

        // Comprueba si el nombre del curso en la posición actual es igual al introducido por el usuario
        private bool MismoNombre(string nombre)
        {
            bool mismo = false;

            if (nombre == sqlCursos.NombreActual(posicion))
                mismo = true;

            return mismo;
        }

        // Muestra en el formulario los datos de la posición que se le pasa
        private void MostrarDatos(int posicion)
        {
            Curso curso = sqlCursos.BuscarCursoPorPosicion(posicion);

            txtNombre.Text = curso.Nombre;
            txtCodigo.Text = curso.Codigo;

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
            txtNombre.Text = "";
            txtCodigo.Text = "";
            
            ActualizarControles();
            ActualizarTitulo();
        }

        // Abre en otro formulario un DataGridView con todos los datos de la tabla correspondiente
        private void MostrarTodos()
        {
            FormDatosCursos formDatos = new FormDatosCursos();
            formDatos.sqlCursos = sqlCursos;
            formDatos.ShowDialog();
        }

        // Comprueba que el nombre introducido no se repita
        private bool NombreAsignado(string nombre)
        {
            bool asignado = false;
            int posicion = sqlCursos.BuscarCursoPorNombre(nombre);

            if (posicion >= 0)
            {
                asignado = true;
            }

            return asignado;
        }

        // Obtiene el número de registros existentes en la base de datos
        private int Registros()
        {
            int registros = sqlCursos.Cursos;

            return registros;
        }

        // Repone el texto en el campo de búsqueda en cursiva
        private void RestablecerCampoBusqueda()
        {
            txtBusqueda.Font = new Font(txtBusqueda.Font, FontStyle.Italic);
            txtBusqueda.Text = "Buscar...";
        }

        // ------------------------------ BOTONES ----------------------------------
        // ----------------------- BOTONES DE NAVEGACIÓN ---------------------------       
        private void bInicial_Click(object sender, EventArgs e)
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
            btnBuscarNombre.Enabled = false;
            btnBuscarPorCodigo.Enabled = false;
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

        private void btnBuscarPorCodigo_Click(object sender, EventArgs e)
        {
            BuscarPorCodigo();
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            BuscarPorNombre();
        }

        // ------------------------------ EVENTOS ----------------------------------
        // Se dispara al cargar el formulario
        private void FormCursos_Load(object sender, EventArgs e)
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
        private void txtNombre_TextChanged(object sender, EventArgs e)
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
            btnBuscarNombre.Enabled = false;
            btnBuscarPorCodigo.Enabled = false;
        }

        // Se dispara al pinchar el textBox de búsqueda y lo limpia
        private void txtBusqueda_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            txtBusqueda.Font = new Font(txtBusqueda.Font, FontStyle.Regular);
        }

        // Se dispara al cerrar el formulario sin guardar cambios
        private void FormCursos_FormClosing(object sender, FormClosingEventArgs e)
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
        private void FormCursos_Click(object sender, EventArgs e)
        {
            RestablecerCampoBusqueda();
        }
    }
}
