using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4___Tema_8
{
    public class Lista
    {
        // Miembro
        private List<Figura> lista;
        private int circulos;
        private int cuadrados;
        private int triangulos;
        private int rectangulos;
        private int hexagonos;

        // Constructor 
        public Lista()
        {
            lista = new List<Figura>();
        }

        // Métodos
        public void Anyadir(Figura figura)
        {
            lista.Add(figura);

            if (figura.GetType() == typeof(Circulo))
                circulos++;
            else if (figura.GetType() == typeof(Cuadrado))
                cuadrados++;
            else if (figura.GetType() == typeof(Triangulo))
                triangulos++;
            else if (figura.GetType() == typeof(Rectangulo))
                rectangulos++;
            else if (figura.GetType() == typeof(Hexagono))
                hexagonos++;
        }

        public void Limpiar()
        {
            lista.Clear();
        }

        public void MostrarFiguras()
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("No se han incluido figuras en la lista.");
            }
            else
            {
                string texto = "Las figuras incluidas son las siguientes: \n \n";

                int contador = 1;

                foreach (Figura figura in lista)
                {
                    texto += "Figura " + contador + ":\n";
                    texto += figura.QuienSoy();
                    texto += figura.ToString();
                    texto += "Área: " + figura.Area() + ".\n";
                    texto += "Perímetro: " + figura.Perimetro() + ".\n";
                    texto += "\n";
                    contador++;
                }

                MessageBox.Show(texto);
            }
        }

        public void MostrarCirculos()
        {
            if (circulos == 0)
            {
                MessageBox.Show("No se han incluido círculos en la lista.");
            }
            else
            {
                string texto = "Los círculos añadidos a la lista son los siguientes: \n \n";
                int contador = 1;

                foreach (Figura figura in lista)
                {
                    if (figura.GetType() == typeof(Circulo))
                    {
                        texto += "Círculo " + contador + ":\n";
                        texto += figura.QuienSoy();
                        texto += figura.ToString();
                        texto += "Área: " + figura.Area() + ".\n";
                        texto += "Perímetro: " + figura.Perimetro() + ".\n";
                        texto += "\n";
                        contador++;
                    }
                }

                MessageBox.Show(texto);
            }
        }

        public void MostrarCuadrados()
        {
            if (cuadrados == 0)
            {
                MessageBox.Show("No se han incluido cuadrados en la lista.");
            }
            else
            {
                string texto = "Los cuadrados añadidos a la lista son los siguientes: \n \n";
                int contador = 1;

                foreach (Figura figura in lista)
                {
                    if (figura.GetType() == typeof(Cuadrado))
                    {
                        texto += "Cuadrado " + contador + ":\n";
                        texto += figura.QuienSoy();
                        texto += figura.ToString();
                        texto += "Área: " + figura.Area() + ".\n";
                        texto += "Perímetro: " + figura.Perimetro() + ".\n";
                        texto += "\n";
                        contador++;
                    }
                }

                MessageBox.Show(texto);
            }
        }

        public void MostrarTriangulos()
        {
            if (triangulos == 0)
            {
                MessageBox.Show("No se han incluido triángulos en la lista.");
            }
            else
            {
                string texto = "Los triángulos añadidos a la lista son los siguientes: \n \n";
                int contador = 1;

                foreach (Figura figura in lista)
                {
                    if (figura.GetType() == typeof(Triangulo))
                    {
                        texto += "Triángulo " + contador + ":\n";
                        texto += figura.QuienSoy();
                        texto += figura.ToString();
                        texto += "Área: " + figura.Area() + ".\n";
                        texto += "Perímetro: " + figura.Perimetro() + ".\n";
                        texto += "\n";
                        contador++;
                    }
                }

                MessageBox.Show(texto);
            }
        }

        public void MostrarRectangulos()
        {
            if (rectangulos == 0)
            {
                MessageBox.Show("No se han incluido rectángulos en la lista.");
            }
            else
            {
                string texto = "Los rectángulos añadidos a la lista son los siguientes: \n \n";
                int contador = 1;

                foreach (Figura figura in lista)
                {
                    if (figura.GetType() == typeof(Rectangulo))
                    {
                        texto += "Rectángulo " + contador + ":\n";
                        texto += figura.QuienSoy();
                        texto += figura.ToString();
                        texto += "Área: " + figura.Area() + ".\n";
                        texto += "Perímetro: " + figura.Perimetro() + ".\n";
                        texto += "\n";
                        contador++;
                    }
                }

                MessageBox.Show(texto);
            }
        }

        public void MostrarHexagonos()
        {
            if (hexagonos == 0)
            {
                MessageBox.Show("No se han incluido hexágonos en la lista.");
            }
            else
            {
                string texto = "Los hexágonos añadidos a la lista son los siguientes: \n \n";
                int contador = 1;

                foreach (Figura figura in lista)
                {
                    if (figura.GetType() == typeof(Hexagono))
                    {
                        texto += "Hexágono " + contador + ":\n";
                        texto += figura.QuienSoy();
                        texto += figura.ToString();
                        texto += "Área: " + figura.Area() + ".\n";
                        texto += "Perímetro: " + figura.Perimetro() + ".\n";
                        texto += "\n";
                        contador++;
                    }
                }

                MessageBox.Show(texto);
            }
        }
    }
}
