using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4___Tema_8
{
    public partial class FormRectangulo : Form
    {
        public FormRectangulo()
        {
            InitializeComponent();
        }

        // Puntero a la lista principal
        public Lista lista;

        // Botón para captar los datos y añadir la figura a la lista
        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            try
            {
                int posX = int.Parse(txtPosX.Text);
                int posY = int.Parse(txtPosY.Text);
                string color = txtColor.Text;
                int largo = int.Parse(txtLargo.Text);
                int ancho = int.Parse(txtAncho.Text);

                Rectangulo rectangulo = new Rectangulo(posX, posY, color, largo, ancho);

                lista.Anyadir(rectangulo);

                MessageBox.Show("Se ha añadido la figura correctamente.");

                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduzca los valores para añadir la figura.");
            }
        }
    }
}
