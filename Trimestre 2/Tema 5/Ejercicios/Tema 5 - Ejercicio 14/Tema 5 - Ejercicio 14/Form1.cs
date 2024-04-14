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

namespace Tema_5___Ejercicio_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaración de constante para tamaño del vector
        const int HORAS = 24;

        // Declaración del vector
        double[] temperaturas = new double[HORAS];

        // Subprograma para rellenar el vector
        void rellenarTemperaturas()
        {
            // Declaración de variable para controlar el progreso de rellenado del vector
            int hora = 0;

            // Bloque para capturar excepciones de formato en los valores introducidos por el usuario
            try
            {
                // Bucle para controlar que se introduzcan un número determinado de valores
                while (hora < HORAS)
                {
                    /* Declaración e inicio de la variable que se va a almacenar en el vector
                    a partir de los valores introducidos por el usuario */
                    double temperatura = double.Parse(Interaction.InputBox("Introduzca la temperatura correspondiente a las " + hora.ToString("0#") + ":00 horas."));

                    // Rellena el vector con el valor de la variable en la posición de la hora indicada. 
                    temperaturas[hora] = temperatura;

                    // Aumenta el contador (hora) para progresar en el rellenado.
                    hora++;
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }
        }

        // Subprograma para calcular la temperatura media
        double calcularMedia()
        {
            // Declaración e inicio de variable para calcular la suma de los valores del vector
            double sumaTemperaturas = 0;

            // Bucle para recorrer todo el vector
            for (int i = 0; i < HORAS; i++)
            {
                // Suma cada uno de los valores del vector 
                sumaTemperaturas += temperaturas[i];
            }

            // Calcula la media de temperaturas a lo largo de las 24 horas y la devuelve
            double media = sumaTemperaturas / HORAS;
            return media; 
        }

        // Subprograma para mostrar las temperaturas iguales y superiores a la media recibida por parámetro
        void mostrarDatos(double media)
        {
            // Declaración de variable de tipo string para mostrar los valores por pantalla
            string texto = "La temperatura media del día es " + media.ToString("0.##") + "º.\n" + "Las temperaturas iguales o superiores a la media son las siguientes:\n";

            // Bucle para recorrer todo el vector
            for (int i = 0; i < HORAS; i++)
            {
                // Si la temperatura correspondiente a cada posición es igual o superior a la media, la añade al texto
                if (temperaturas[i] >= media)
                    texto += i.ToString("0#") + ":00 horas: " + temperaturas[i] + "º\n";
            }

            // Muestra el texto por pantalla
            MessageBox.Show(texto);
        }

        // Acción principal: botón para rellenar vector, calcular media y mostrar datos
        private void btnRellenar_Click(object sender, EventArgs e)
        {
            // Llama a función para rellenar vector con las temperaturas
            rellenarTemperaturas();

            // Llama a la función para calcular temperatura media y devuelve el valor
            double media = calcularMedia();

            // Llama a función para mostrar temperaturas iguales o superiores a la media, que se pasa como argumento
            mostrarDatos(media);
        }
    }
}
