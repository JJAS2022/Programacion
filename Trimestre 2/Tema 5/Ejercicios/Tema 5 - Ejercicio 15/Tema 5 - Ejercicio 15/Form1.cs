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

namespace Tema_5___Ejercicio_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaración de constante de tipo entero para tamaño del vector
        const int ELEMENTOS = 20;

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

        // Función para buscar el menor valor
        int buscarMenor()
        {
            // Declara la variable para controlar el menor valor
            int menor = 0;

            // Bucle que itera el vector
            for (int i = 0; i < ELEMENTOS; i++)
            {
                // Primero, la variable toma el valor de la primera posición del vector
                if (i == 0)
                {
                    menor = vector[i];
                }
                // Luego, comprueba cada posición y le va dando valores diferentes a la variable si encuentra un valor menor
                else
                {
                    if (vector[i] < menor)
                    {
                        menor = vector[i];
                    }
                }
            }

            // Devuelve el menor valor
            return menor;
        }

        // Función para buscar el mayor valor
        int buscarMayor()
        {
            // Declara la variable para controlar el mayor valor
            int mayor = 0;

            // Bucle que itera el vector
            for (int i = 0; i < ELEMENTOS; i++)
            {
                // Primero, la variable toma el valor de la primera posición del vector
                if (i == 0)
                {
                    mayor = vector[i];
                }
                // Luego, comprueba cada posición y le va dando valores diferentes a la variable si encuentra un valor mayor
                else
                {
                    if (vector[i] > mayor)
                    {
                        mayor = vector[i];
                    }
                }
            }

            // Devuelve el mayor valor
            return mayor;
        }

        // Función para conocer cuántas veces se repite un valor
        int numeroRepetido(int numero)
        {
            // Declara e inicia la variable de tipo entero para controlar el número de repeticiones
            int repeticiones = 0;

            // Bucle que itera el vector
            for (int i = 0; i < ELEMENTOS; i++)
            {
                // Si el número recibido por parámetro coincide con el valor del vector en posición i, aumenta la variable en 1
                if (vector[i] == numero)
                    repeticiones++;
            }

            // Devuelve la cantidad de repeticiones del número
            return repeticiones;
        }

        //Función para mostrar en pantalla los valores menor y mayor, y las veces que se repiten
        void mostrarResultado(int valor, string tipo, int repeticiones)
        {
            if (repeticiones == 1)
                MessageBox.Show("El número " + tipo + " es " + valor + ", que se ha repetido " + repeticiones + " vez.\n");
            else
                MessageBox.Show("El número " + tipo + " es " + valor + ", que se ha repetido " + repeticiones + " veces.\n");
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            // Llama al subprograma para rellenar el vector
            rellenarVector();

            // Llama al subprograma para buscar el menor valor
            int menor = buscarMenor();

            // Llama al subprograma para buscar el mayor valor
            int mayor = buscarMayor();

            // Llama al subprograma para saber cuántas veces se repite y se lo pasa por parámetro
            int repeticionesMenor = numeroRepetido(menor);         
            int repeticionesMayor = numeroRepetido(mayor);

            // Llama al subprograma para mostrar resultado en pantalla
            mostrarResultado(menor, "menor", repeticionesMenor);
            mostrarResultado(mayor, "mayor", repeticionesMayor);
        }
    }
}
