using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1___Tema_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearCirculo_Click(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo(10, 20, "Azul", 5);
            MessageBox.Show(circulo.QuienSoy());
            MessageBox.Show(circulo.ToString());
            MessageBox.Show("Mi área es " + circulo.Area() + ".");
        }

        private void btnCrearCuadrado_Click(object sender, EventArgs e)
        {
            Cuadrado cuadrado = new Cuadrado (20, 40, "Rojo", 10);
            MessageBox.Show(cuadrado.QuienSoy());
            MessageBox.Show(cuadrado.ToString());
            MessageBox.Show("Mi área es " + cuadrado.Area() + ".");
        }
    }
}
