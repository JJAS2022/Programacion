using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_3___Tema_8
{
    public class Lista
    {
        //Miembros
        List<Figura> lista;

        // Constructor
        public Lista()
        {
            lista = new List<Figura>();
        }

        // Métodos
        public void Anyadir(Figura figura)
        {
            lista.Add(figura);
        }

        public void MostrarFiguras()
        {
            if (!HayFiguras())
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
                    texto += "\n";
                    contador++;
                }

                MessageBox.Show(texto);
            }
        }

        public void MostrarCirculos()
        {
            if (!HayCirculos())
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
                        texto += "\n";
                        contador++;
                    }
                }

                MessageBox.Show(texto);
            }          
        }

        public void MostrarCuadrados()
        {
            if (!HayCuadrados())
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
                        texto += "\n";
                        contador++;
                    }
                }

                MessageBox.Show(texto);
            }
        }

        public bool HayFiguras()
        {
            bool hay = false;

            if (lista.Count > 0)
            {
                hay = true;
            }

            return hay;
        }

        public bool HayCirculos()
        {
            bool hay = false;
            
            foreach (Figura figura in lista)
            {
                if (figura.GetType() == typeof(Circulo))
                {
                    hay = true;
                }
            }

            return hay; 
        }

        public bool HayCuadrados()
        {
            bool hay = false;

            foreach (Figura figura in lista)
            {
                if (figura.GetType() == typeof(Cuadrado))
                {
                    hay = true;
                }
            }

            return hay;
        }
    }
}
