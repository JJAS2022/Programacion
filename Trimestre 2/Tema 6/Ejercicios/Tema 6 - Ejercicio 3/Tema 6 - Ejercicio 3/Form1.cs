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

namespace Tema_6___Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaración de la lista original y de la lista para almacenar los números primos
        List<int> listaOriginal = new List<int>();
        List<int> listaPrimos = new List<int>();

        // Función para rellenar la lista original
        void RellenarLista()
        {
            // Reinicia los valores de la lista original y de primos
            listaOriginal.Clear();
            listaPrimos.Clear();

            // Captura los errores de input del usuario
            try
            {
                // Inicia la variable para controlar los input del usuario sobre continuar introduciendo valores
                DialogResult respuesta;

                // Bucle que permite rellenar la lista original, permitiendo al usuario introducir tantos valores como desee
                do
                {
                    // Almacena en una variable el número introducido por el usuario
                    int valor = int.Parse(Interaction.InputBox("Introduzca el valor."));

                    // Añade el valor de la variable a la lista original
                    listaOriginal.Add(valor);

                    // Almacena en una variable la decisión del usuario de continuar introduciendo valores
                    respuesta = MessageBox.Show("¿Desea introducir otro valor?", "¿Continuar?", MessageBoxButtons.YesNo);
                } while (respuesta == DialogResult.Yes);
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }
        }

        // Función para pasar las listas a texto
        string ListaATexto(List<int> lista)
        {
            // Declaración e inicio de la variable para almacenar la lista en texto
            string texto = "";

            // Declaración e inicio de la variable para controlar la posición en la lista dentro del bucle foreach
            int posicion = 0;

            // Bucle para recorrer la lista
            foreach (int numero in lista)
            {
                // Según la posición en la lista, añade al texto el valor almacenado y una coma o un punto final
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

            // La función devuelve la lista en un string en la variable texto
            return texto;
        }

        // Función que permite visualizar las listas en cada momento con un formato determinado
        void MostrarListas()
        {
            // Declaración e inicio de la variable para almacenar ambas listas en texto
            string texto = "Los elementos de la lista son los siguientes:\n";

            // Añade ambas listas al texto, llamando a la función ListaATexto para cada una indidualmente
            texto += "Lista original: " + ListaATexto(listaOriginal) + "\n";
            texto += "Lista de primos: " + ListaATexto(listaPrimos) + "\n";

            // Muestra el texto en pantalla
            MessageBox.Show(texto);
        }

        // Función que comprueba si un número es primo
        bool EsPrimo(int numero)
        {
            // Declaración de la variable booleana
            bool primo = true;

            // Bucle para recorrer los números del 2 al inmediatamente anterior al número
            for (int i = 2; i < numero; i++)
            {
                // Si el número es divisible entre alguno de los anteriores, entonces no es primo
                if (numero % i == 0)
                    primo = false;
            }

            // Devuelve el valor de la variable booleana
            return primo;
        }

        // Función que copia los primos de la lista original a la lista de primos
        void CopiarPrimos()
        {
            // Reinicia la lista de primos 
            listaPrimos.Clear();

            // Bucle para recorrer la lista original
            foreach(int numero in listaOriginal)
            {
                // Pasa el número por la función EsPrimo, que devuelve un valor booleano
                if (EsPrimo(numero))
                {
                    // Si es primo, añade el número a la lista de primos
                    listaPrimos.Add(numero);    
                }
            }
        }

        // Función que elimina los primos de la lista original y los añade a la lista de primos
        void MoverPrimos()
        {
            // Reinicia la lista de primos 
            listaPrimos.Clear();

            // Declara e inicia la variable para controlar el avance en la extensión de la lista original
            int posicion = 0;
            
            // Bucle para recorrer la lista original controlando la posición
            while (posicion < listaOriginal.Count)
            {
                // Pasa cada número de la lista por la función EsPrimo
                if (EsPrimo(listaOriginal[posicion]))
                {
                    // Si es primo, lo añade a la lista de primos y lo elimina de la lista original, sin cambiar la posición
                    listaPrimos.Add(listaOriginal[posicion]);
                    listaOriginal.RemoveAt(posicion);
                }
                else
                {
                    // Si no es primo, avanza la posición
                    posicion++;
                }
            }
        }

        // Botón para rellenar la lista original
        private void btn_Rellenar_Click(object sender, EventArgs e)
        {
            // Llamada a la función de rellenar la lista
            RellenarLista();
        }

        // Botón para mostrar las listas
        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            // Llamada a la función para mostrar las listas
            MostrarListas();
        }

        // Botón para copiar los primos en una segunda lista
        private void btn_Copiar_Click(object sender, EventArgs e)
        {
            // Llamada a la función de copiar los números primos
            CopiarPrimos();

            // Llamada a la función para mostrar las listas
            MostrarListas();
        }

        // Botón para mover los primos a una segunda lista
        private void btn_Mover_Click(object sender, EventArgs e)
        {
            // Llamada a la función de mover los números primos y borrarlos de la original
            MoverPrimos();

            // Llamada a la función para mostrar las listas
            MostrarListas();
        }
    }
}
