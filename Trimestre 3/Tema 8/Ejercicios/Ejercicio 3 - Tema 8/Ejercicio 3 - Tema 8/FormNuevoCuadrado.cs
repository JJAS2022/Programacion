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
    public partial class FormNuevoCuadrado : Form
    {
        public FormNuevoCuadrado()
        {
            InitializeComponent();
        }

        public Lista lista;

        private void btnAnyadir_Click_1(object sender, EventArgs e)
        {
            int posX = int.Parse(txtPosX.Text);
            int posY = int.Parse(txtPosY.Text);
            string color = txtColor.Text;
            int lado = int.Parse(txtLado.Text);
            Cuadrado cuadrado = new Cuadrado(posX, posY, color, lado);
            lista.Anyadir(cuadrado);
            MessageBox.Show("Se ha añadido la figura correctamente.");
        }
    }
}
