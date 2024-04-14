using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3___Tema_8
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        // Instancia de la clase Lista en formulario principal
        Lista lista = new Lista();

        private void btnCrearCirculo_Click(object sender, EventArgs e)
        {
            FormNuevoCirculo formCirculo = new FormNuevoCirculo();
            formCirculo.lista = lista;
            formCirculo.ShowDialog();
        }

        private void btnCrearCuadrado_Click(object sender, EventArgs e)
        {
            FormNuevoCuadrado formCuadrado = new FormNuevoCuadrado();
            formCuadrado.lista = lista;
            formCuadrado.ShowDialog();
        }

        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            lista.MostrarFiguras();
        }

        private void btnMostrarCirculos_Click(object sender, EventArgs e)
        {
            lista.MostrarCirculos();
        }

        private void btnMostrarCuadrados_Click(object sender, EventArgs e)
        {
            lista.MostrarCuadrados();
        }
    }
}
