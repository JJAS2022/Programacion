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
using System.Xml.Linq;

namespace Tema_5___Ejercicio_17
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
            // Almacena en una variable y devuelve el número introducido por el usuario
            int numero = int.Parse(txtNum.Text);
            return numero;
        }        

        // Función para comprobar si el número introducido está en el vector
        bool buscarNumero(int numero)
        {
            // Declaración de variable booleana
            bool encontrado = false;

            // Iteración del vector 
            for (int i = 0; i < ELEMENTOS; i++)
            {
                // Comprobación de cada posición del vector con el elemento introducido por el usuario.
                // Si el valor coincide con algún elemento, la variable toma valor true.
                if (vector[i] == numero)
                    encontrado = true;
            }

            // La función devuelve el valor de la variable booleana
            return encontrado;
        }

        // Función para conocer la posición del vector en la que se encuentra el número recibido por parámetro
        int buscarPosicion(int numero)
        {
            // Variable que almacena la posición
            int posicion = 0;

            // Bucle que itera el vector
            for (int i = 0; i < ELEMENTOS; i++)
            {
                /* Al encontrar un número igual al introducido por el usuario (asumiendo que los valores son únicos),
                se cambia el valor de la variable con la posición del vector correspondiente a dicho valor.*/  
                if (vector[i] == numero)
                    posicion = i;
            }

            // Devuelve la posición
            return posicion;
        }

        // Función para ordenar el vector de menor a mayor
        void ordenCreciente()
        {            
            // Declaración de variable auxiliar
            int aux = 0;

            // Bucle que itera el vector del elemento inicial al penúltimo
            for (int i = 0; i < (ELEMENTOS - 1); i++)
            {
                // Bucle que itera el vector del segundo elemento al último
                for (int j = i + 1; j < ELEMENTOS; j++)
                {
                    // Si el elemento i es mayor que el elemento j, intercambian la posición utilizando la variable auxiliar
                    if (vector[i] > vector[j])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
        }

        // Función para ordenar el vector de mayor a menor
        void ordenDecreciente()
        {
            // Declaración de variable auxiliar
            int aux = 0;

            // Bucle que itera el vector del elemento inicial al penúltimo
            for (int i = 0; i < (ELEMENTOS - 1); i++)
            {
                // Bucle que itera el vector del segundo elemento al último
                for (int j = i + 1; j < ELEMENTOS; j++)
                {
                    // Si el elemento i es menor que el elemento j, intercambian la posición utilizando la variable auxiliar
                    if (vector[i] < vector[j])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
        }

        // Función para mostrar el vector en su estado actual
        void mostrarVector()
        {
            // Variable para mostrar el vector en formato texto
            string texto = "El vector actualmente tiene los siguientes valores: ";

            // Bucle que itera el vector
            for (int i = 0; i < ELEMENTOS; i++)
            {
                // Añade elementos a la variable texto según la posición en el vector
                if (i < (ELEMENTOS - 1))
                {
                    texto += vector[i] + ", ";
                }
                else
                {
                    texto += vector[i] + ".";
                }
            }

            // Muestra el texto en pantalla
            MessageBox.Show(texto);
        }

        // Función principal del botón para rellenar el vector
        private void btnRellenar_Click(object sender, EventArgs e)
        {
            // Llama al subprograma para rellenar el vector
            rellenarVector();

            // Llama al subprograma para mostrar la estructura actual del vector
            mostrarVector();
        }

        // Función principal del botón para buscar un elemento en el vector según la posición introducida
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Captura errores de input del usuario
            try
            {
                // Llama al subprograma para leer el número introducido por el usuario y lo guarda en una variable
                int numero = leerNumero();

                // Comprueba que el número introducido está en el vector
                if (buscarNumero(numero))
                {
                    // Llama a la función para comprobar la posición
                    int posicion = buscarPosicion(numero);

                    // Muestra por pantalla la posición del valor introducido
                    MessageBox.Show("El número " + numero + " se encuentra actualmente en la posición " + posicion + ".");
                }             
                else
                {
                    MessageBox.Show("El número " + numero + " no se encuentra en el vector.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private void btnMenorMayor_Click(object sender, EventArgs e)
        {
            // Llama al subprograma para ordenar el vector de forma creciente
            ordenCreciente();

            // Llama al subprograma para mostrar la estructura actual del vector
            mostrarVector();
        }

        private void btnMayorMenor_Click(object sender, EventArgs e)
        {
            // Llama al subprograma para ordenar el vector de forma decreciente
            ordenDecreciente();

            // Llama al subprograma para mostrar la estructura actual del vector
            mostrarVector();
        }
    }
}
