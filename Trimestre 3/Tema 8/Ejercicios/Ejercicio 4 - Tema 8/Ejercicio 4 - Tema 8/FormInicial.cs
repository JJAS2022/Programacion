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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        // Instancia de la clase Lista que se pasa a los formularios
        Lista lista = new Lista();

        // ------------------------------ BOTONES PARA AÑADIR FIGURAS ------------------------------------
        private void btnAddCirculo_Click(object sender, EventArgs e)
        {
            FormCirculo formCirculo = new FormCirculo();
            formCirculo.lista = lista;
            formCirculo.ShowDialog();
        }

        private void btnAddCuadrado_Click(object sender, EventArgs e)
        {
            FormCuadrado formCuadrado = new FormCuadrado();
            formCuadrado.lista = lista;
            formCuadrado.ShowDialog();
        }

        private void btnAddTriangulo_Click(object sender, EventArgs e)
        {
            FormTriangulo formTriangulo = new FormTriangulo();
            formTriangulo.lista = lista;
            formTriangulo.ShowDialog();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            FormRectangulo formRectangulo = new FormRectangulo();
            formRectangulo.lista = lista;
            formRectangulo.ShowDialog();
        }

        private void btnAddHexágono_Click(object sender, EventArgs e)
        {
            FormHexagono formHexagono = new FormHexagono();
            formHexagono.lista = lista;
            formHexagono.ShowDialog();
        }

        // ------------------------------ BOTONES PARA MOSTRAR FIGURAS ------------------------------------
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

        private void btnMostrarTriangulos_Click(object sender, EventArgs e)
        {
            lista.MostrarTriangulos();  
        }

        private void btnMostrarRectangulos_Click(object sender, EventArgs e)
        {
            lista.MostrarRectangulos();
        }

        private void btnMostrarHexagonos_Click(object sender, EventArgs e)
        {
            lista.MostrarHexagonos();
        }

        // ------------------------------ BOTONES PARA OTRAS FUNCIONES ------------------------------------
        private void btnAutorellenar_Click(object sender, EventArgs e)
        {
            Circulo circulo1 = new Circulo(1, 1, "Azul", 5);
            lista.Anyadir(circulo1);
            Cuadrado cuadrado1 = new Cuadrado(2, 2, "Rojo", 10);
            lista.Anyadir(cuadrado1);
            Triangulo triangulo1 = new Triangulo(3, 3, "Amarillo", 6);
            lista.Anyadir(triangulo1);
            Rectangulo rectangulo1 = new Rectangulo(4, 4, "Verde", 5, 10);
            lista.Anyadir(rectangulo1);
            Hexagono hexagono1 = new Hexagono(5, 5, "Gris", 7);
            lista.Anyadir(hexagono1);
            Circulo circulo2 = new Circulo(6, 8, "Blanco", 3);
            lista.Anyadir(circulo2);
            Triangulo triangulo2 = new Triangulo(7, 10, "Violeta", 9);
            lista.Anyadir(triangulo2);
            MessageBox.Show("La lista se ha rellenado con valores predefinidos.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lista.Limpiar();
            MessageBox.Show("La lista se ha vaciado.");
        }
    }
}
