using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_1___Tema_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lista lista = new Lista();

        private void btnCrearCirculo_Click(object sender, EventArgs e)
        {
            int posX;
            int posY;
            string color;
            int radio;

            lista.ObtenerDatosGenerales(out posX, out posY, out color);
            radio = int.Parse(Interaction.InputBox("Introduzca el radio."));
            Circulo circulo = new Circulo(posX, posY, color, radio);
            lista.Anyadir(circulo);
        }

        private void btnCrearCuadrado_Click(object sender, EventArgs e)
        {
            int posX;
            int posY;
            string color;
            int lado;

            lista.ObtenerDatosGenerales(out posX, out posY, out color);
            lado = int.Parse(Interaction.InputBox("Introduzca el lado."));
            Cuadrado cuadrado = new Cuadrado (posX, posY, color, lado);
            lista.Anyadir(cuadrado);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            lista.MostrarFiguras();
        }

        private void btnMostrarCírculos_Click(object sender, EventArgs e)
        {
            lista.MostrarCirculos();
        }

        private void btnMostrarCuadrados_Click(object sender, EventArgs e)
        {
            lista.MostrarCuadrados();
        }
    }
}
