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

namespace Tema_6___Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaración de constante de números totales de apuesta y sorteo
        const int NUMEROS = 6;

        // Declaración de las listas de apuesta y sorteo para almacenar los valores
        List<int> apuesta = new List<int>();
        List<int> sorteo = new List<int>();

        // -------------------------------------------- FUNCIONES ---------------------------------------------

        // Función para realizar las apuestas mediante InputBox
        void RealizarApuesta()
        {
            // Reinicia el valor de la apuesta 
            apuesta.Clear();

            // Captura errores de input del usuario
            try
            {
                // Variable para controlar el número de inputs válidos
                int contador = 0;

                // Bucle para controlar el número de inputs, que serán siempre 6 
                while (contador < NUMEROS)
                {
                    // Variable que almacena el input del usuario
                    int numero = int.Parse(Interaction.InputBox("Apuesta " + (contador + 1) + ": Seleccione un número entre 1 y 49."));

                    // Condicional para controlar que el número introducido sea válido
                    if (numero >= 1 && numero <= 49)
                    {
                        // Condicional para controlar que el número no se repita
                        if (!apuesta.Contains(numero))
                        {
                            // Si cumple condiciones, se añade a la lista de la apuesta y pasa al siguiente número
                            apuesta.Add(numero);
                            contador++;
                        }
                        else
                        {
                            MessageBox.Show("El número " + numero + " ya se ha seleccionado. Elija otro número.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El número introducido debe estar entre 1 y 49, ambos incluidos.");
                    }
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }
        }

        // Función para simular el sorteo de los números
        void SimularSorteo()
        {
            // Reinicia el valor del sorteo
            sorteo.Clear();

            // Objeto que permite generar números pseudoaleatorios
            Random random = new Random();

            // Declaración de variable para almacenar los números generados
            int numero;

            // Declaración de variable para controlar el avance en la generación de números
            int contador = 0;

            // Bucle para generar un máximo de 6 números válidos
            while (contador < NUMEROS)
            {
                // Da valor a la variable que almacena los valores aleatorios generados entre 1 y 49
                numero = random.Next(1, 50);

                // Condicional para controlar que el número no se repita
                if (!sorteo.Contains(numero))
                {
                    // Si cumple la condición, se añade a la lista de sorteo y se pasa al siguiente número
                    sorteo.Add(numero);
                    contador++;
                }
            }
        }

        // Función que permite calcular el número de coincidencia entre las listas apuesta y sorteo
        int CalcularAciertos()
        {
            // Declaración e inicio de la variable para controlar los aciertos
            int aciertos = 0;

            // Bucle para recorrer la lista de apuesta
            foreach (int numero in apuesta)
            {
                // Comprueba si el elemento de la lista apuesta coincide con algún elemento de la lista sorteo
                if (sorteo.Contains(numero))
                {
                    // Si es así, aumenta la variable aciertos en 1
                    aciertos++;
                }
            }

            // Devuelve el valor de la variable aciertos
            return aciertos;
        }

        // Función que permite ordenar la lista recibida por parámetro
        void Ordenar(List<int> lista)
        {
            lista.Sort();
        }

        // Función que permite pasar a texto los elementos de una lista recibida por parámetro
        string ATexto(List<int> lista)
        {
            // Declaración de la variable texto
            string texto = "";

            // Bucle para recorrer los elementos de la lista
            foreach (int numero in lista)
            {
                // Se añade cada elemento a la variable texto con un formato de dos dígitos y un espacio
                texto += numero.ToString("0#") + " ";
            }

            // Devuelve la variable texto
            return texto;
        }

        // Función que permite mostrar los aciertos según el entero recibido por parámetro
        void MostrarAciertos(int aciertos)
        {
            // Comprueba que se ha realizado la apuesta y el sorteo antes de comprobar el resultado
            if (apuesta.Count != 0 && sorteo.Count != 0)
            { 
                // Según el número de aciertos, modifica el texto del label
                if (aciertos > 1)
                {
                    lblAciertos.Text = "Has acertado " + aciertos + " números.";
                }
                else if (aciertos == 1)
                {
                    lblAciertos.Text = "Has acertado " + aciertos + " número.";
                }
                else
                {
                    lblAciertos.Text = "No has acertado ningún número.";
                }
            }
            else
            {
                lblAciertos.Text = "Realiza una apuesta y simula el \nsorteo para comprobar los aciertos";
            }
        }

        // -------------------------------------------- BOTONES ---------------------------------------------

        // Botón para realizar las apuestas
        private void btnApostar_Click(object sender, EventArgs e)
        {
            // Llama a la función para realizar las apuestas
            RealizarApuesta();

            // Ordena la lista apuesta
            Ordenar(apuesta);

            // Llama a la función para transformar la lista a texto y la guarda en una variable
            string textoApuesta = ATexto(apuesta);

            // Muestra el texto un label
            lblApuesta.Text = textoApuesta;
        }

        // Botón para simular el sorteo
        private void btnSorteo_Click(object sender, EventArgs e)
        {
            // Llama a la función para realizar el sorteo
            SimularSorteo();

            // Ordena la lista sorteo
            Ordenar(sorteo);

            // Llama a la función para transformar la lista a texto y la guarda en una variable
            string textoSorteo = ATexto(sorteo);

            // Muestra el texto un label
            lblSorteo.Text = textoSorteo;
        }

        // Botón para comprobar los resultados
        private void btnMostrarResultado_Click(object sender, EventArgs e)
        {
            // Llama a la función auxiliar para calcular aciertos y almacena el valor en una variable
            int aciertos = CalcularAciertos();

            // Llama a la función para mostrar los aciertos, que le pasa por parámetro
            MostrarAciertos(aciertos);
        }
    }
}
