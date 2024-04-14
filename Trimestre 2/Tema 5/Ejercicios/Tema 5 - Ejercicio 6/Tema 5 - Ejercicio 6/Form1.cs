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

namespace Tema_5___Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaración de constante de tipo entero para el tamaño de los vectores
        const int CANTIDAD = 10;

        // Declaración de dos vectores de tipo entero 
        int[] vector1 = new int[CANTIDAD];
        int[] vector2 = new int[CANTIDAD];

        // Función para modificar los valores de un vector, que recibe un vector para parámetro
        private void rellenarVector(int[] vector)
        {
            // Declaración de variable para controlar el progreso de rellenado de los valores del vector
            int contador = 0;

            // Bucle para controlar las iteraciones a lo largo de todo el vector
            while (contador < CANTIDAD)
            {
                // Bloque de comprobación de inputs válidos por el usuario
                try
                {
                    // Declaración de variable para almacenar el input del usuario
                    int numero = int.Parse(Interaction.InputBox("Introduce el elemento " + (contador + 1) + " del vector."));

                    // Otorga el valor de "numero" al elemento correspondiente a la posición "contador" del vector recibido por parámetro
                    vector[contador] = numero;

                    // Incrementa en 1 el valor de la variable "contador"
                    contador++;
                }
                catch (FormatException fEx)
                {
                    MessageBox.Show(fEx.Message);
                }
            }
        }

        // Función para la comparación de los vectores
        private void compararVectores()
        {
            // Declaración de variable booleana 
            bool iguales = true;

            // Bucle que itera de cero al tamaño de los vectores
            for (int i = 0; i < CANTIDAD; i++) 
            {
                // Comparación de los valores de ambos vectores posición a posición
                if (vector1[i] != vector2[i])
                {
                    // Si en alguna de las posiciones no coinciden los valores, la variable toma valor false
                    iguales = false;
                }
            }

            // Muestra mensaje por pantalla según el valor de la variable booleana
            if (iguales)
                MessageBox.Show("Los vectores son iguales.");
            else
                MessageBox.Show("Los vectores NO son iguales.");
        }

        // Función principal del botón 
        private void button1_Click(object sender, EventArgs e)
        {
            // Llamada a la función para rellenar el vector 1 
            rellenarVector(vector1);

            // Llamada a la función para rellenar el vector 2
            rellenarVector(vector2);

            // Llamada a la función para comparar vectores
            compararVectores();
        }
    }
}
