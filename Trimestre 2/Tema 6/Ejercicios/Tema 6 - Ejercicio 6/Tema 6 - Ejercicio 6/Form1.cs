using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_6___Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaración de listas
        List<int> lista1 = new List<int>();
        List<int> lista2 = new List<int>();
        List<int> lista3 = new List<int>();

        // ----------------------------------------------- FUNCIONES ---------------------------------------------------

        // Función para rellenar la lista que se pasa por parámetro
        void RellenarLista(List<int> lista)
        {
            // Reinicia los valores de la lista
            lista.Clear();

            // Almacena la elección del usuario
            DialogResult respuesta;

            // Captura errores de input del usuario
            try
            {
                // Bucle para rellenar la lista mientras el usuario elija continuar introduciendo valores
                do
                {                   
                    // Almacena el valor introducido por el usuario en una variable de enteros
                    int numero = int.Parse(Interaction.InputBox("Introduce el valor."));

                    // Añade la variable a la lista correspondiente
                    lista.Add(numero);

                    // Requiere al usuario para que indice si desea continuar introduciendo valores y guarda su elección
                    respuesta = MessageBox.Show("¿Desea introducir otro valor?", "Continuar", MessageBoxButtons.YesNo);
                } while (respuesta == DialogResult.Yes);
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        // Función que muestra por pantalla una lista recibida por parámetro
        void MostrarLista(List<int> lista)
        {
            // Variable de tipo string para almacenar los valores de la lista   
            string texto = "";

            // Variable de tipo entero para controlar la posición de la lista
            int posicion = 0;

            // Bucle para recorrer la lista
            foreach (int numero in lista)
            {
                // Añade el valor de cada posición de la lista al texto y le da formato según su posición en la lista
                if (posicion < (lista.Count - 1))
                {
                    texto += numero + ", ";
                    posicion++;
                }
                else
                {
                    texto += numero + ".";
                }
            }

            // Muestra la variable texto en pantalla
            MessageBox.Show(texto);
        }

        // Función para rellenar una lista mediante la copia de los valores de otra,
        // comprobando que no están repetidos en la lista final
        void RellenarListaPorCopia(List<int> lista)
        {
            // Bucle que recorre la lista recibida por parámetro
            foreach (int numero in lista)
            {
                // Comprueba que la lista final no contenga ya el valor
                if(!lista3.Contains(numero))
                    // Si no lo contiene, se lo añade
                    lista3.Add(numero);
            }
        }

        // Función para intercalar valores en nueva lista por copia
        void IntercalarPorCopia()
        {
            // Reinicia los valores de la lista nueva
            lista3.Clear();

            // Llama a la función para rellenar la lista nueva, pasándole las listas origen por parámetro
            RellenarListaPorCopia(lista1);
            RellenarListaPorCopia(lista2);

            // Ordena la lista nueva
            lista3.Sort();
        }

        // Función para rellenar una lista mediante la copia y eliminación de los valores de otra,
        // comprobando que no están repetidos en la lista final
        void RellenarListaPorMovimiento(List<int> lista)
        {
            // Comprueba que se recorra toda la lista origen hasta que no queden elementos
            while (lista.Count != 0)
            {
                // Comprueba si el valor almacenado en la posición 0 de la lista origen está ya en la lista final
                if (!lista3.Contains(lista[0]))
                { 
                    // Si no lo está, lo añade a la nueva lista
                    lista3.Add(lista[0]);
                }

                // En cualquier caso, elimina ese valor
                lista.RemoveAt(0);
            }
        }

        // Función para intercalar valores en nueva lista por copia (elimina de la lista origen)
        void IntercalarPorMovimiento()
        {
            // Reinicia los valores de la lista nueva
            lista3.Clear();

            // Llama a la función para rellenar la lista nueva, pasándole las listas origen por parámetro
            RellenarListaPorMovimiento(lista1);
            RellenarListaPorMovimiento(lista2);

            // Ordena la lista nueva
            lista3.Sort();
        }
        
        // --------------------------------------------- BOTONES ---------------------------------------------------

        // Botón para rellenar la primera lista
        private void btnRellenar1_Click(object sender, EventArgs e)
        {
            // Llamada a la función para rellenar la lista que se pasa por parámetro
            RellenarLista(lista1);

            // Llamada a la función para mostrar valores de la lista que se pasa por parámetro
            MostrarLista(lista1);
        }

        // Botón para rellenar la segunda lista
        private void btnRellenar2_Click(object sender, EventArgs e)
        {
            // Llamada a la función para rellenar la lista que se pasa por parámetro
            RellenarLista(lista2);

            // Llamada a la función para mostrar valores de la lista que se pasa por parámetro
            MostrarLista(lista2);
        }

        // Botón para mostrar los valores de la primera lista
        private void btnMostrar1_Click(object sender, EventArgs e)
        {
            // Llamada a la función para mostrar valores de la lista que se pasa por parámetro
            MostrarLista(lista1);
        }

        // Botón para mostrar los valores de la segunda lista
        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            // Llamada a la función para mostrar valores de la lista que se pasa por parámetro
            MostrarLista(lista2);
        }

        // Botón para mostrar los valores de la tercera lista
        private void btnMostrar3_Click(object sender, EventArgs e)
        {
            // Llamada a la función para mostrar valores de la lista que se pasa por parámetro
            MostrarLista(lista3);
        }

        // Botón para intercalar los valores de las listas por copia
        private void btnIntercalarCopia_Click(object sender, EventArgs e)
        {
            // Llamada a la función para intercalar valores por copia
            IntercalarPorCopia();

            // Llamada a la función para mostrar valores de la lista que se pasa por parámetro
            MostrarLista(lista3);
        }

        // Botón para intercalar los valores de las listas por movimiento (elimina de la lista origen)
        private void btnIntercalarMover_Click(object sender, EventArgs e)
        {
            // Llamada a la función para intercalar valores por movimiento
            IntercalarPorMovimiento();

            // Llamada a la función para mostrar valores de la lista que se pasa por parámetro
            MostrarLista(lista3);
        }        
    }
}
