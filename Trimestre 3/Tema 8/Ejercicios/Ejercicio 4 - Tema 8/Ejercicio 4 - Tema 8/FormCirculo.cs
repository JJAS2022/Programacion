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
    public partial class FormCirculo : Form
    {
        public FormCirculo()
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
                int radio = int.Parse(txtRadio.Text);

                Circulo circulo = new Circulo(posX, posY, color, radio);

                lista.Anyadir(circulo);

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
