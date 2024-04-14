using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_1___Tema_8
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

        public void ObtenerDatosGenerales(out int posX, out int posY, out string color)
        {
            posX = int.Parse(Interaction.InputBox("Introducir posición X."));
            posY = int.Parse(Interaction.InputBox("Introducir posición Y."));
            color = Interaction.InputBox("Introducir color");
        }

        public void MostrarFiguras()
        {
            string texto = "Las figuras añadidas son: \n";
            int contador = 1;
            
            foreach (Figura figura in lista)
            {
                texto += "Figura " + contador + ":\n";
                texto += figura.QuienSoy();
                texto += figura.ToString();
                texto += "Área: " + figura.Area() + "\n";
                contador++;
            }

            MessageBox.Show(texto);
        }

        public void MostrarCirculos()
        {
            string texto = "Los círculos añadidos son: \n";
            int contador = 1;

            foreach (Figura figura in lista)
            {
                if (figura.GetType() == typeof(Circulo))
                {
                    texto += "Círculo " + contador + ":\n";
                    texto += figura.QuienSoy();
                    texto += figura.ToString();
                    texto += "Área: " + figura.Area() + "\n";
                    contador++;
                }                
            }

            MessageBox.Show(texto);
        }

        public void MostrarCuadrados()
        {
            string texto = "Los cuadrados añadidos son: \n";
            int contador = 1;

            foreach (Figura figura in lista)
            {
                if (figura.GetType() == typeof(Cuadrado))
                {
                    texto += "Cuadrado " + contador + ":\n";
                    texto += figura.QuienSoy();
                    texto += figura.ToString();
                    texto += "Área: " + figura.Area() + "\n";
                    contador++;
                }
            }

            MessageBox.Show(texto);
        }
    }
}
