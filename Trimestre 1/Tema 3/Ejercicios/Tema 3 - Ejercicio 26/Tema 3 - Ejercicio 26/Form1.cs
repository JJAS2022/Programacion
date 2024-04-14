using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int counter = 0;

            // Inicia el texto de salida del Message Box
            string text = "Serie:" + "\n";

            // Itera del 1 al 100 
            for (int i = 1; i <= 100; i++)
            {
                // Comprueba que los números sean divisbles entre 3
                if (i % 3 == 0)
                {
                    // Añade el número a la suma
                    sum += i;

                    // Aumenta en 1 el contador 
                    counter++;

                    // Actualiza el texto 
                    text = text + i + ", ";

                    // Cada 7 números imprime un salto de página
                    if (counter % 7 == 0)
                    {
                        text = text + "\n";
                    }
                }
            }

            // Texto de salida final con la suma de la serie
            text = text + "\n" + "\n" + "La suma es: " + sum;

            // Muestra el texto en pantalla
            MessageBox.Show(text);
        }
    }
}
