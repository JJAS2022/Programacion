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

namespace Tema_5___Ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaración de constante de tipo entero para tamaño del vector
        const int ELEMENTOS = 10;

        // Declaración de vector de enteros
        int[] vector = new int[ELEMENTOS];

        // Función para rellenar vector
        void rellenarVector()
        {
            // Declaración de variable para controlar el progreso de rellenado de los valores del vector
            int contador = 0;

            // Bucle para controlar las iteraciones a lo largo de todo el vector
            while (contador < ELEMENTOS)
            {
                // Bloque de comprobación de inputs válidos por el usuario
                try
                {
                    // Declaración de variable para almacenar el input del usuario
                    int numero = int.Parse(Interaction.InputBox("Introduce el elemento " + (contador + 1) + " del vector."));

                    // Otorga el valor de "numero" al elemento correspondiente a la posición "contador" del vector
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

        // Función para leer input del usuario
        int leerNumero()
        {
            int numero = int.Parse(txtNum.Text);
            return numero;
        }

        // Función para buscar elemento en el vector
        bool buscarNumero(int elemento)
        {
            // Declaración de variable booleana
            bool encontrado = false;

            // Iteración del vector 
            for (int i = 0; i < ELEMENTOS; i++)
            {
                // Comprobación de cada posición del vector con el elemento introducido por el usuario.
                // Si el valor coincide con algún elemento, la variable toma valor true.
                if (vector[i] == elemento)
                    encontrado= true;
            }

            // La función devuelve el valor de la variable booleana
            return encontrado;
        }

        // Función principal del botón para rellenar el vector
        private void btnRellenar_Click(object sender, EventArgs e)
        {
            // Llama al subprograma para rellenar el vector
            rellenarVector();
        }

        // Función principal del botón para buscar elemento en el vector
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Captura errores de input del usuario
            try
            {
                // Llama al subprograma para leer el número introducido por el usuario y lo guarda en una variable
                int numero = leerNumero();

                // Llama al subprograma de búsqueda del elemento y le pasa como argumento la variable numero.
                // Muestra por pantalla el resultado según el valor devuelto por la función. 
                if (buscarNumero(numero))
                    MessageBox.Show("El número " + numero + " sí está en el vector.");
                else
                    MessageBox.Show("El número " + numero + " no está en el vector.");
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }            
        }
    }
}
