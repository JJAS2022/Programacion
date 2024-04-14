using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_9___Ejercicio_3
{
    public partial class FormGeneral : Form
    {
        // -------------------------------- MIEMBROS -----------------------------------
        // Declaración de instancia de la clase de la base de datos
        SqlDBHelper sqlDBHelper;

        // Puntero que controla el formulario activo en cada momento
        private Form formActivo = null;

        // Variables para controlar el tamaño regulable de los botones del formulario
        private int cambio = 20;
        private int movimiento = 10;

        // Variable para controlar si se producen cambios en el formulario de modificación
        private bool cambios = false;

        // ------------------------------- PROPIEDADES ----------------------------------
        public bool Cambios
        {
            get { return cambios; } 
            set { cambios = value; }
        }

        // ------------------------------- CONSTRUCTOR ----------------------------------
        public FormGeneral()
        {
            InitializeComponent();
        }

        // --------------------------------- MÉTODOS ------------------------------------
        // ----------------------------------- UI ---------------------------------------
        // Permite aumentar el tamaño de los botones al pasar por encima
        private void AumentarTamanyoBoton(object sender)
        {
            Button boton = sender as Button;
            int ancho = boton.Size.Width;
            int largo = boton.Size.Height;
            int ejeX = boton.Location.X;
            int ejeY = boton.Location.Y;           
            boton.Size = new Size(ancho + cambio, largo + cambio);
            boton.Location = new Point(ejeX - movimiento, ejeY - movimiento);
        }

        // Devuelve el botón a su tamaño inicial cuando el cursos ya no le toca
        private void ReducirTamanyoBoton(object sender)
        {
            Button boton = sender as Button;
            int ancho = boton.Size.Width;
            int largo = boton.Size.Height;
            int ejeX = boton.Location.X;
            int ejeY = boton.Location.Y;
            boton.Size = new Size(ancho - cambio, largo - cambio);
            boton.Location = new Point(ejeX + movimiento, ejeY + movimiento);
        }

        // --------------------------------- OPERATIVOS ---------------------------------     
        // Carga el formulario que recibe por parámetro y lo muestra en pantalla
        public void CargarFormulario(Form formulario)
        {
            // Controla que solamente haya un formulario activo a la vez 
            if (formActivo != null)
                formActivo.Close();

            // Gestiona la presentación del formulario cargado en el panel general
            formActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(formulario);
            panelHijo.Tag = formulario;  
            formulario.Show();
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

        private void MensajeError()
        {
            string mensaje = "Hay cambios no guardados en el formulario actual. Guárdelos o descártelos para poder continuar.";
            string titulo = "Cambios sin guardar";
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Obtiene el número de registros existentes en la base de datos
        private int Registros()
        {
            int registros = sqlDBHelper.Medicamentos;

            return registros;
        }

        // -------------------------------- EVENTOS ---------------------------------
        // ------------------------------ FORMULARIO --------------------------------
        private void FormGeneral_Load(object sender, EventArgs e)
        {
            // Inicialización de la instancia de la clase SqlDBHelper 
            sqlDBHelper = new SqlDBHelper();

            // Instancia y carga el formulario de bienvenida
            FormInicial formInicial = new FormInicial();
            CargarFormulario(formInicial);
        }

        // Se dispara al cerrar el formulario sin guardar cambios
        private void FormGeneral_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cambios)
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

        // ----------------------------- BOTÓN INICIO -------------------------------
        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            AumentarTamanyoBoton(sender);
            lblInicio.Visible = true;
        }
        
        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            ReducirTamanyoBoton(sender);
            lblInicio.Visible = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (!cambios)
            {
                // Instancia y carga el formulario de bienvenida
                FormInicial formInicial = new FormInicial();
                CargarFormulario(formInicial);
            }
            else
                MensajeError();
        }

        // --------------------------- BOTÓN DATOS -------------------------------
        private void btnDatos_MouseEnter(object sender, EventArgs e)
        {
            AumentarTamanyoBoton(sender);
            lblDatos.Visible = true;
        }

        private void btnDatos_MouseLeave(object sender, EventArgs e)
        {
            ReducirTamanyoBoton(sender);
            lblDatos.Visible = false;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            if (!cambios)
            {
                // Llama a las funciones de carga de formularios según la situación
                if (HayDatos())
                {
                    FormDatos formDatos = new FormDatos();
                    formDatos.FormGeneral = this;
                    formDatos.SqlDBHelper = sqlDBHelper;
                    formDatos.Posicion = 0;
                    CargarFormulario(formDatos);
                }
                else
                {
                    FormSinDatos formSinDatos = new FormSinDatos();
                    CargarFormulario(formSinDatos);
                }
            }
            else
                MensajeError();
        }

        // ----------------------------- BOTÓN BUSCAR -------------------------------
        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            AumentarTamanyoBoton(sender);
            lblBuscar.Visible = true;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            ReducirTamanyoBoton(sender);
            lblBuscar.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!cambios)
            {
                // Instancia y carga el formulario de búsqueda
                FormBuscar formBuscar = new FormBuscar();
                formBuscar.FormGeneral = this;
                formBuscar.SqlDBHelper = sqlDBHelper;
                CargarFormulario(formBuscar);
            }
            else
                MensajeError();
        }

        // --------------------------- BOTÓN NUEVO -------------------------------
        private void btnNuevo_MouseEnter(object sender, EventArgs e)
        {
            AumentarTamanyoBoton(sender);
            lblAnyadir.Visible = true;
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            ReducirTamanyoBoton(sender);
            lblAnyadir.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!cambios)
            {
                // Instancia y carga el formulario para añadir una nueva fila
                FormModificar formNuevo = new FormModificar();
                formNuevo.FormGeneral = this;
                formNuevo.SqlDBHelper = sqlDBHelper;

                // Indica que se carga sin datos, para generar una nueva entrada
                formNuevo.Posicion = -1;

                CargarFormulario(formNuevo);
            }
            else
                MensajeError();
        }

        // --------------------------- BOTÓN TODOS -------------------------------
        private void btnTodos_MouseEnter(object sender, EventArgs e)
        {
            AumentarTamanyoBoton(sender);
            lblTodos.Visible = true;
        }

        private void btnTodos_MouseLeave(object sender, EventArgs e)
        {
            ReducirTamanyoBoton(sender);
            lblTodos.Visible = false;
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            if (!cambios)
            {
                if (HayDatos())
                { // Instancia y carga el formulario para mostrar todos los datos
                    FormTodos formTodos = new FormTodos();
                    formTodos.FormGeneral = this;
                    formTodos.SqlDBHelper = sqlDBHelper;
                    CargarFormulario(formTodos);
                }
                else
                {
                    FormSinDatos formSinDatos = new FormSinDatos();
                    CargarFormulario(formSinDatos);
                }
            }
            else
                MensajeError();
        }
    }
}
