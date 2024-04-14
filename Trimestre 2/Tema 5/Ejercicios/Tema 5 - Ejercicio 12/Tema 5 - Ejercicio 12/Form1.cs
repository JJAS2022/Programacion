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

namespace Tema_5___Ejercicio_12
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

        // Subprograma para mostrar los datos almacenados en el vector
        void mostrarTemperaturas()
        {
            // Declaración e inicio de la variable para mostrar los valores del vector
            string texto = "Las temperaturas son las siguientes: \n";

            // Bucle para rellenar la variable texto con los valores del vector
            for (int i = 0; i < HORAS; i++)
            {
                /* Adición de los valores de i (hora) y de la temperatura según la hora
                a la variable texto con un formato específico para facilitar su lectura */
                texto += i.ToString("0#") + ":00 horas: " + temperaturas[i] + "º\n";
            }

            // Muestra por pantalla la variable texto
            MessageBox.Show(texto);
        }

        // Subprograma para mostrar la temperatura mínima, máxima y media del vector
        void mostrarDatos()
        {
            // Declaración e inicio de variable para calcular la media de los valores del vector
            double sumaTemperaturas = 0;

            // Declaración de variable para conocer el menor de los valores del vector
            double maxima = 0;

            // Declaración de variable para conocer el mayor de los valores del vector
            double minima = 0;

            for (int i = 0; i < HORAS; i++)
            {
                // Suma cada uno de los valores del vector 
                sumaTemperaturas += temperaturas[i];

                // Inicia las variables minima y maxima al primer valor del vector
                if (i == 0)
                {
                    minima = temperaturas[i];
                    maxima = temperaturas[i];
                }
                /* A continuación, recorre el vector y sustituye los valores de las variables 
                si encuentra valores menores (mínima) o mayores (máxima) */
                else
                {
                    if (temperaturas[i] < minima)
                    {
                        minima = temperaturas[i];
                    }
                    else if (temperaturas[i] > maxima)
                    {
                        maxima = temperaturas[i];
                    }
                }
            }

            // Calcula la media de temperaturas a lo largo de las 24 horas
            double media = sumaTemperaturas / HORAS;

            // Muestra la temperatura media, mínima y máxima por pantalla
            MessageBox.Show("La temperatura media del día es " + media.ToString("0.##") + "º, con mínimas de " + minima + "º y máximas de " + maxima + "º.");
        }

        // Acción principal: botón para rellenar vector
        private void btnRellenar_Click(object sender, EventArgs e)
        {
            // Llamada a función para rellenar vector
            rellenarTemperaturas();
        }

        // Acción principal: botón para mostrar vector
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Llamada a función para mostrar vector
            mostrarTemperaturas();
        }

        // Acción principal: botón para mostrar datos específicos
        private void btnDatos_Click(object sender, EventArgs e)
        {
            // Llamada a función para mostrar datos específicos
            mostrarDatos();
        }
    }
}
