using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_9___Ejercicio_3
{
    public partial class FormBuscar : Form
    {
        // --------------------------------- MIEMBROS ----------------------------------
        // Variable para almacenar el formulario que llama a este cuando se crea
        private FormGeneral formGeneral;

        // Puntero a la instancia del objeto de la base de datos del formulario general
        private SqlDBHelper sqlDBHelper;

        // -------------------------------- PROPIEDADES ---------------------------------
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

        // -------------------------------- CONSTRUCTOR --------------------------------
        public FormBuscar()
        {
            InitializeComponent();
        }

        // ----------------------------------- MÉTODOS --------------------------------
        // ------------------------------------- UI -----------------------------------
        // Cambia el color de fondo de la fila de encabezado
        private void CambiarEncabezado()
        {
            DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(195, 219, 139);
            DGV.EnableHeadersVisualStyles = false;
        }

        // Devuelve al textBox los valores iniciales 
        private void RestablecerCampoBusqueda()
        {
            txtBusqueda.Font = new Font(txtBusqueda.Font, FontStyle.Italic);
            txtBusqueda.Text = "Buscar...";
        }

        // ---------------------------------- OPERATIVOS ---------------------------------
        // Muestra los medicamentos según el valor introducido y el campo por el que se quiere buscar
        private void MostrarDatosPorValor(string valor, int campo)
        {
            int coincidencias = 0; 

            // Llamada recurrente al método de la clase SqlDBHelper que devuelve un medicamento
            // según el valor introducido (que puede ser un nombre, principio o familia),
            // la fila en la que se busca (i) y el número del campo por el que se quiere filtrar (campo)
            for (int i = 0; i < sqlDBHelper.Medicamentos; i++)
            {
                Medicamento medicamento = sqlDBHelper.BuscarMedicamentoPorValorParecido(valor, i, campo);

                if (medicamento != null)
                {
                    string codigo = medicamento.Codigo;
                    string nombre = medicamento.Nombre;
                    string principio = medicamento.Principio;
                    string familia = medicamento.Familia;
                    string forma = medicamento.Forma;
                    string dosis = medicamento.Dosis;
                    string posologia = medicamento.Posologia;


                    DGV.Rows.Add();
                    DGV.Rows[coincidencias].Cells[0].Value = codigo;
                    DGV.Rows[coincidencias].Cells[1].Value = nombre;
                    DGV.Rows[coincidencias].Cells[2].Value = principio;
                    DGV.Rows[coincidencias].Cells[3].Value = familia;
                    DGV.Rows[coincidencias].Cells[4].Value = forma;
                    DGV.Rows[coincidencias].Cells[5].Value = dosis;
                    DGV.Rows[coincidencias].Cells[6].Value = posologia;

                    coincidencias++;
                }
            }

            // Hace visible la información si existen coincidencias en la búsqueda,
            // de lo contrario muestra un mensaje de error
            if (coincidencias == 0)
            {
                panelResultados.Visible = false;

                if (txtBusqueda.Text == "Buscar..." || txtBusqueda.Text == "")
                {                 
                    panelSinResultado.Visible = false;
                    MensajeError();
                }
                else
                    panelSinResultado.Visible = true;
            }
            else
            {
                panelSinResultado.Visible = false;
                panelResultados.Visible = true;
            }
        }

        // Lanza un mensaje de error cuando la búsqueda no arroja resultados
        private void MensajeError()
        {
            string mensaje = "Introduzca un término, seleccione el filtro y pulse Buscar.";
            string titulo = "Búsqueda vacía";
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // ----------------------------------- EVENTOS ---------------------------------
        // Al hacer doble click en una celda, captura su valor y abre un formulario con los datos correspondientes a la fila
        public void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Controla la celda que se clica y almacena el valor del 
            // código (campo 0) para pasarlo a la función que carga un formulario
            // con los datos correspondientes a esa fila
            int fila = e.RowIndex;
            string valor = DGV.Rows[fila].Cells[0].Value.ToString();
            int posicion = sqlDBHelper.BuscarPosicionPorCodigo(valor);

            // Controla que no se seleccione el encabezado
            if (fila != -1)
            {
                // Controla que hayan valores en la celda clicada
                if (DGV.CurrentCell != null && DGV.CurrentCell.Value != null)
                {
                    // Instancia e inicializa un formulario de datos pasándole la posicion de la fila seleccionada
                    FormDatos formDatos = new FormDatos();
                    formDatos.FormGeneral = formGeneral;
                    formDatos.SqlDBHelper = sqlDBHelper;
                    formDatos.Posicion = posicion;

                    // Llama al formulario general para cargar el formulario de datos creado
                    formGeneral.CargarFormulario(formDatos);
                }
            }
        }

        // Carga el formulario
        private void FormBuscar_Load(object sender, EventArgs e)
        {
            CambiarEncabezado();
        }

        // Al hacer click fuera del textBox restablece sus valores
        private void FormBuscar_Click(object sender, EventArgs e)
        {
            RestablecerCampoBusqueda();
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Focus();
        }

        // Se dispara al pulsar teclas dentro del campo de búsqueda
        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            // Si la tecla pulsada es el Enter, manda un click al botón Buscar
            // y reposiciona el cursor dentro del campo
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
                txtBusqueda_Click(sender, e);
            }
        }

        // Al hacer click en el textBox lo limpia y pone la fuente normal
        private void txtBusqueda_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            txtBusqueda.Font = new Font(txtBusqueda.Font, FontStyle.Regular);
        }

        // ----------------------------------- BOTONES ------------------------------------
        // Botón para buscar según el RadioButton marcado
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Variable que almacena el valor introducido
            string busqueda = txtBusqueda.Text;

            // Limpia el DataGridView
            DGV.Rows.Clear();            

            // Comprueba el RadioButton marcado para hacer la búsqueda
            // según el campo por el que se quiera filtrar (1 - Nombre, 
            // 2 - Principio o 3 - Familia)
            if (rbNombre.Checked)
            {
                MostrarDatosPorValor(busqueda, 1);
            }
            else if (rbPrincipio.Checked)
            {
                MostrarDatosPorValor(busqueda, 2);
            }
            else if (rbFamilia.Checked)
            {
                MostrarDatosPorValor(busqueda, 3);
            }

            // Limpia el campo de búsqueda
            RestablecerCampoBusqueda();
        }
    }
}
