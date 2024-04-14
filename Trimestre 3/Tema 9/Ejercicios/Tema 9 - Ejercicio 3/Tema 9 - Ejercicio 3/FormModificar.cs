using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tema_9___Ejercicio_3
{
    public partial class FormModificar : Form
    {
        // ---------------------------------- MIEMBROS -----------------------------------
        // Variable para almacenar el formulario que llama a este cuando se crea
        private FormGeneral formGeneral;

        // Puntero a la tabla
        private SqlDBHelper sqlDBHelper;

        // Variable que almacena la posicion en la base de datos (si es negativa es para añadir entrada)
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

        // ---------------------------------- CONSTRUCTOR ---------------------------------
        public FormModificar()
        {
            InitializeComponent();
        }

        // ----------------------------------- MÉTODOS ------------------------------------
        // ------------------------------------- UI ---------------------------------------
        // Hace visibles los botones de Aceptar y Cancelar
        private void ActivarBotonesModificar()
        {
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            panelInfo.Visible = false;

            // Activa la variable de cambios del formulario general
            formGeneral.Cambios = true;
        }

        // Oculta los botones de Aceptar y Cancelar 
        private void DesactivarBotonesModificar()
        {
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            panelInfo.Visible = true;

            // Reinicia la variable de cambios del formulario general
            formGeneral.Cambios = false;
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

        // ------------------------------------ OPERATIVOS ---------------------------------
        // Cancela la operación de modificación o guardado
        // Comprueba que todos los campos del formulario estén rellenados
        private bool CamposRellenados(string codigo, string nombre, string principio, string familia, string forma, string dosis, string posologia)
        {
            bool rellenados = true;

            if (codigo == "" || nombre == "" || principio == "" || familia == "" || forma == "" || dosis == "" || posologia == "")
            {
                rellenados = false;
            }

            return rellenados;
        }

        private void Cancelar()
        {
            // Pregunta si desea cancelar la operación
            DialogResult dr = MessageBox.Show("¿Desea descartar los cambios en el formulario actual?", "¿Cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si la respuesta es sí, actualiza la base de datos
            if (dr == DialogResult.Yes)
            {
                // Si la operación era una actualización, recupera la información y la muestra en formulario de datos
                if (posicion >= 0)
                {
                    // Instancia e inicializa un formulario de datos pasándole la posicion de la fila seleccionada
                    FormDatos formDatos = new FormDatos();
                    formDatos.FormGeneral = formGeneral;
                    formDatos.SqlDBHelper = sqlDBHelper;

                    // Carga los datos de la posición recibida
                    formDatos.Posicion = posicion;

                    // Llama al formulario general para cargar el formulario de datos creado
                    formGeneral.CargarFormulario(formDatos);
                }
                // Si la operación era añadir, restablece los campos
                else
                    RestablecerCampos();

                // Reinicia la variable de cambios del formulario general
                formGeneral.Cambios = false;
            }
        }

        // Comprueba que el código contenga exactamente 6 dígitos
        private bool FormatoCorrecto(string codigo)
        {
            bool correcto = false;

            if (codigo.Length == 6 && Regex.IsMatch(codigo, "^[0-9]+$"))
                correcto = true;

            return correcto;
        }

        // Abre un formulario con los datos correspondientes
        private void MostrarDatos()
        {
            // Instancia e inicializa un formulario de datos pasándole la posicion de la nueva fila añadida
            FormDatos formDatos = new FormDatos();
            formDatos.FormGeneral = formGeneral;
            formDatos.SqlDBHelper = sqlDBHelper;
            formDatos.Posicion = posicion;

            // Llama al formulario general para cargar el formulario de datos creado
            formGeneral.CargarFormulario(formDatos);
        }

        // Obtiene el número de registros existentes en la base de datos
        private int Registros()
        {
            int registros = sqlDBHelper.Medicamentos;

            return registros;
        }

        // Devuelve los valores limpios a los campos del formulario
        private void RestablecerCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrincipio.Text = "";
            txtFamilia.Text = "";
            txtForma.Text = "";
            txtDosis.Text = "";
            txtPosologia.Text = "";
            DesactivarBotonesModificar();
        }

        // Recorre la base de datos buscando coincidencias, y si encuentra, sale y devuelve true
        private bool ValorActual(string valor, int campo)
        {
            bool valorActual = false;

            if (sqlDBHelper.ValorActual(posicion, campo) == valor)
                valorActual = true;

            return valorActual;
        }

        // Recorre la base de datos buscando coincidencias, y si encuentra, sale y devuelve true
        private bool ValorAsignado(string valor, int campo)
        {
            Medicamento medicamento;
            bool asignado = false;
            int coincidencia = 0; 

            for (int i = 0; i < Registros(); i++)
            {               
                medicamento = sqlDBHelper.BuscarMedicamentoPorValor(valor, i, campo);
                if (medicamento != null)
                {
                    coincidencia++;
                }
            }

            if (coincidencia > 0)
            {
                asignado = true;
            }

            return asignado;
        }

        // ---------------------------------- BOTONES ----------------------------------
        // ------------------------------- BOTÓN ACEPTAR -------------------------------
        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {
            AumentarTamanyoBoton(sender);
            lblAceptar.Visible = true;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            ReducirTamanyoBoton(sender);
            lblAceptar.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Variables para controlar el input del usuario
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string principio = txtPrincipio.Text;
            string familia = txtFamilia.Text;
            string forma = txtForma.Text;
            string dosis = txtDosis.Text;
            string posologia = txtPosologia.Text;

            // Controla que los campos no estén vacíos
            if (CamposRellenados(codigo, nombre, principio, familia, forma, dosis, posologia))
            {
                // Controla si la operación es añadir o actualizar
                if (posicion < 0)
                {
                    // Controla que no se repitan los campos de valores únicos
                    if (!ValorAsignado(codigo, 0) && !ValorAsignado(nombre, 1))
                    {
                        // Controla el formato de la clave principal
                        if (FormatoCorrecto(codigo))
                        {
                            // Pregunta si desea guardar datos
                            DialogResult dr = MessageBox.Show("¿Desea guardar los datos introducidos?", "¿Guardar?", MessageBoxButtons.YesNo);

                            // Si la respuesta es sí, actualiza la base de datos
                            if (dr == DialogResult.Yes)
                            {
                                Medicamento medicamento = new Medicamento(codigo, nombre, principio, familia, forma, dosis, posologia);
                                sqlDBHelper.AnyadirMedicamento(medicamento);
                                posicion = Registros() - 1;

                                // Feedback al usuario
                                MessageBox.Show("El medicamento se ha añadido correctamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Muestra los datos correspondientes
                                MostrarDatos();

                                // Reinicia la variable de cambios del formulario general
                                formGeneral.Cambios = false;
                            }
                        }
                        else
                            MessageBox.Show("El campo Código nacional debe contener exactamente 6 dígitos.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Los campos Código nacional y Nombre comercial deben ser únicos.", "Valores repetidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Controla que no se repitan los campos de valores únicos, salvo que sean de la posición a actualizar
                    if ((!ValorAsignado(codigo, 0) || ValorActual(codigo, 0)) && (!ValorAsignado(nombre, 1) || ValorActual(nombre, 1)))
                    {
                        // Controla el formato de la clave principal
                        if (FormatoCorrecto(codigo))
                        {
                            // Pregunta si desea guardar datos
                            DialogResult dr = MessageBox.Show("¿Desea actualizar el medicamento con los datos introducidos?", "¿Actualizar?", MessageBoxButtons.YesNo);

                            // Si la respuesta es sí, actualiza la base de datos
                            if (dr == DialogResult.Yes)
                            {
                                Medicamento medicamento = new Medicamento(codigo, nombre, principio, familia, forma, dosis, posologia);
                                sqlDBHelper.ActualizarMedicamento(medicamento, posicion);

                                // Feedback al usuario
                                MessageBox.Show("El medicamento se ha actualizado correctamente.", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Muestra los datos correspondientes
                                MostrarDatos();

                                // Reinicia la variable de cambios del formulario general
                                formGeneral.Cambios = false;
                            }
                        }
                        else
                            MessageBox.Show("El campo Código nacional debe contener exactamente 6 dígitos.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Los campos Código nacional y Nombre comercial deben ser únicos.", "Valores repetidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Todos los campos son obligatorios.", "Uno o más campos están vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ------------------------------ BOTÓN CANCELAR ------------------------------
        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            AumentarTamanyoBoton(sender);
            lblCancelar.Visible = true;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            ReducirTamanyoBoton(sender);
            lblCancelar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        // ------------------------------------- EVENTOS ---------------------------------------
        // Este formulario se utiliza tanto para actualizar datos como para añadir entradas,
        // de modo que si la posición que se le pasa es menor que cero no cargará datos,
        // y si es igual o mayor que cero cargará los datos correspondientes de la base de datos
        private void FormModificar_Load(object sender, EventArgs e)
        {
            if (posicion >= 0)
            { Medicamento medicamento = sqlDBHelper.BuscarMedicamentoPorPosicion(posicion);

                txtCodigo.Text = medicamento.Codigo;
                txtNombre.Text = medicamento.Nombre;
                txtPrincipio.Text = medicamento.Principio;
                txtFamilia.Text = medicamento.Familia;
                txtForma.Text = medicamento.Forma;
                txtDosis.Text = medicamento.Dosis;
                txtPosologia.Text = medicamento.Posologia;

                DesactivarBotonesModificar();
            }
            else
            {
                RestablecerCampos();
            }
        }

        // Controla si se producen cambios en los textos del formulario
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ActivarBotonesModificar();
        }
    }
}
