using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_9___Ejercicio_3
{
    public partial class FormDatos : Form
    {
        // --------------------------------- MIEMBROS ----------------------------------
        // Variable para almacenar el formulario que llama a este cuando se crea
        private FormGeneral formGeneral;

        // Puntero a la tabla
        private SqlDBHelper sqlDBHelper;

        // Variables de control de la posición de la base de datos
        private int posicion;

        // Variables para controlar el tamaño regulable de los botones del formulario general
        private int cambio = 20;
        private int movimiento = 10;

        // --------------------------------- PROPIEDADES ----------------------------------
        public FormGeneral FormGeneral
        {
            get { return formGeneral; }
            set { formGeneral = value; }
        }
        
        public SqlDBHelper SqlDBHelper
        {
            get { return sqlDBHelper; }
            set { sqlDBHelper = value; }
        }

        public int Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        // -------------------------------- CONSTRUCTOR ------------------------------
        public FormDatos()
        {
            InitializeComponent();
        }

        // ---------------------------------- MÉTODOS ---------------------------------
        // ------------------------------------ UI ------------------------------------
        // Actualiza los controles según la posición del dato mostrado
        private void ActualizarControles()
        {
            if (posicion == 0 && Registros() == 1)
            {
                btnInicial.Visible = false;
                btnAnterior.Visible = false;
                btnFinal.Visible = false;
                btnSiguiente.Visible = false;
            }
            else if (posicion == 0 && Registros() > 1)
            {
                btnInicial.Visible = false;
                btnAnterior.Visible = false;
                btnFinal.Visible = true;
                btnSiguiente.Visible = true;
            }
            else if (posicion == Registros() - 1)
            {
                btnFinal.Visible = false;
                btnSiguiente.Visible = false;
                btnInicial.Visible = true;
                btnAnterior.Visible = true;
            }
            else
            {
                btnInicial.Visible = true;
                btnAnterior.Visible = true;
                btnSiguiente.Visible = true;
                btnFinal.Visible = true;
            }
        }

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

        // Devuelve el botón a su tamaño inicial cuando el cursor ya no le toca
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

        // Actualiza el título del formulario según la situación
        private void ActualizarRegistros()
        {
            string titulo = "";
            titulo += +(posicion + 1) + " | " + Registros();
            lblRegistros.Text = titulo;
        }

        // ------------------------------- OPERATIVOS -------------------------------
        // Elimina los datos de la posición actual
        private void EliminarDatos()
        {
            // Pregunta si desea eliminar los datos
            DialogResult dr = MessageBox.Show("¿Desea eliminar los datos del registro actual?",
                "¿Eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si la respuesta es sí, actualiza la base de datos
            if (dr == DialogResult.Yes)
            {
                sqlDBHelper.EliminarMedicamento(posicion);

                // Feedback al usuario sobre la operación
                MessageBox.Show("Se ha eliminado el medicamento.", "Eliminado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Muestra los campos según la situación
                if (Registros() > 0)
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
                {
                    FormSinDatos formSinDatos = new FormSinDatos();
                    formGeneral.CargarFormulario(formSinDatos);
                }
            }
            else
                MostrarDatos(posicion);
        }

        // Muestra en el formulario los datos de la posición que se le pasa
        private void MostrarDatos(int posicion)
        {
            Medicamento medicamento = sqlDBHelper.BuscarMedicamentoPorPosicion(posicion);

            lblCodigo.Text = medicamento.Codigo;
            lblNombre.Text = medicamento.Nombre;
            lblPrincipio.Text = medicamento.Principio;
            lblFamilia.Text = medicamento.Familia;
            lblForma.Text = medicamento.Forma;
            lblDosis.Text = medicamento.Dosis;
            lblPosologia.Text = medicamento.Posologia;

            // Actualiza los botones según la situación
            ActualizarControles();

            // Actualiza el título del formulario según la situación
            ActualizarRegistros();
        }

        // Obtiene el número de registros existentes en la base de datos
        private int Registros()
        {
            int registros = sqlDBHelper.Medicamentos;

            return registros;
        }

        // ------------------------------------ EVENTOS -----------------------------------
        // Se dispara al cargar el formulario
        private void FormDatos_Load(object sender, EventArgs e)
        {
            MostrarDatos(posicion);
        }

        // ----------------------------------- BOTONES ------------------------------------
        // ------------------------------- BOTÓN ACTUALIZAR -------------------------------
        private void btnActualizar_MouseEnter(object sender, EventArgs e)
        {
            AumentarTamanyoBoton(sender);
            lblActualizar.Visible = true;
        }

        private void btnActualizar_MouseLeave(object sender, EventArgs e)
        {
            ReducirTamanyoBoton(sender);
            lblActualizar.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Instancia y carga el formulario para actualizar los datos
            FormModificar formNuevo = new FormModificar();
            formNuevo.FormGeneral = formGeneral;
            formNuevo.SqlDBHelper = sqlDBHelper;

            // Pasa la posición de los datos a modificar al nuevo formulario
            formNuevo.Posicion = posicion;

            formGeneral.CargarFormulario(formNuevo);
        }

        // -------------------------------- BOTÓN INICIAL -------------------------------
        private void btnInicial_MouseEnter(object sender, EventArgs e)
        {
            AumentarTamanyoBoton(sender);
            lblInicial.Visible = true;
        }

        private void btnInicial_MouseLeave(object sender, EventArgs e)
        {
            ReducirTamanyoBoton(sender);
            lblInicial.Visible = false;
        }

        private void btnInicial_Click(object sender, EventArgs e)
        {
            posicion = 0;
            MostrarDatos(posicion);
        }

        // ------------------------------- BOTÓN ANTERIOR -------------------------------
        private void btnAnterior_MouseEnter(object sender, EventArgs e)
        {
            AumentarTamanyoBoton(sender);
            lblAnterior.Visible = true;
        }

        private void btnAnterior_MouseLeave(object sender, EventArgs e)
        {
            ReducirTamanyoBoton(sender);
            lblAnterior.Visible = false;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion != 0)
            {
                posicion--;
                MostrarDatos(posicion);
            }
        }

        // ------------------------------- BOTÓN SIGUIENTE -------------------------------
        private void btnSiguiente_MouseEnter(object sender, EventArgs e)
        {
            AumentarTamanyoBoton(sender);
            lblSiguiente.Visible = true;
        }

        private void btnSiguiente_MouseLeave(object sender, EventArgs e)
        {
            ReducirTamanyoBoton(sender);
            lblSiguiente.Visible = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicion != (Registros() - 1))
            {
                posicion++;
                MostrarDatos(posicion);
            }
        }

        // --------------------------------- BOTÓN FINAL ---------------------------------
        private void btnFinal_MouseEnter(object sender, EventArgs e)
        {
            AumentarTamanyoBoton(sender);
            lblFinal.Visible = true;
        }

        private void btnFinal_MouseLeave(object sender, EventArgs e)
        {
            ReducirTamanyoBoton(sender);
            lblFinal.Visible = false;
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            posicion = Registros() - 1;
            MostrarDatos(posicion);
        }

        // ------------------------------- BOTÓN ELIMINAR --------------------------------
        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            AumentarTamanyoBoton(sender);
            lblEliminar.Visible = true;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            ReducirTamanyoBoton(sender);
            lblEliminar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
        }
    }
}
