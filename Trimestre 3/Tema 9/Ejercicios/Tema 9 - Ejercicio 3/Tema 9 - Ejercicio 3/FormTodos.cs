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
    public partial class FormTodos : Form
    {
        // ----------------------------------- MIEMBROS -----------------------------------
        // Variable para almacenar el formulario que llama a este cuando se crea
        private FormGeneral formGeneral;

        // Puntero a la tabla
        private SqlDBHelper sqlDBHelper;

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

        // --------------------------------- CONSTRUCTOR ------------------------------
        public FormTodos()
        {
            InitializeComponent();
        }

        // ----------------------------------- MÉTODOS ----------------------------------
        // ------------------------------------- UI ------------------------------------
        // Cambia el color de fondo de la fila de encabezado
        private void CambiarEncabezado()
        {
            DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(195, 219, 139);
            DGV.EnableHeadersVisualStyles = false;
        }

        // ------------------------------- OPERATIVOS -------------------------------
        // Rellenar el DataGridView con todos los datos de la base de datos
        private void MostrarTodos()
        {
            for (int i = 0; i < sqlDBHelper.Medicamentos; i++)
            {
                Medicamento medicamento = sqlDBHelper.BuscarMedicamentoPorPosicion(i);

                string codigo = medicamento.Codigo;
                string nombre = medicamento.Nombre;
                string principio = medicamento.Principio;
                string familia = medicamento.Familia;
                string forma = medicamento.Forma;
                string dosis = medicamento.Dosis;
                string posologia = medicamento.Posologia;


                DGV.Rows.Add();
                DGV.Rows[i].Cells[0].Value = codigo;
                DGV.Rows[i].Cells[1].Value = nombre;
                DGV.Rows[i].Cells[2].Value = principio;
                DGV.Rows[i].Cells[3].Value = familia;
                DGV.Rows[i].Cells[4].Value = forma;
                DGV.Rows[i].Cells[5].Value = dosis;
                DGV.Rows[i].Cells[6].Value = posologia;
            }
        }

        // ---------------------------------- EVENTOS --------------------------------
        // Se lanza al cargar el formulario
        private void FormTodos_Load(object sender, EventArgs e)
        {
            CambiarEncabezado();
            MostrarTodos();
        }

        // Al hacer doble click en una celda, captura su valor y abre un formulario con los datos correspondientes a la fila
        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
