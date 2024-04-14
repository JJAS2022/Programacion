using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Captura que no se deje vacío el textBox
            try
            {
                int number = int.Parse(txtNum.Text);
                double sum = 1.00;

                // Comprueba que el número introducido sea mayor que 0
                if (number > 0)
                {
                    // Itera desde el 2 hasta el número para construir la serie
                    for (int i = 2; i <= number; i++)
                    {
                        //Calcula el valor de cada paso de la serie
                        double serie = 1.00 / i;

                        // Si la posición en la serie (i) es par resta su valor, y si es impar lo suma
                        if (i % 2 == 0)
                        {
                            sum -= serie;
                        }
                        else
                        {
                            sum += serie;
                        }
                    }

                    // Muestra en pantalla el resultado de la serie con 4 decimales
                    MessageBox.Show("El resultado de la serie es " + sum.ToString("0.####") + ".");
                }
                else
                {
                    MessageBox.Show("Introduzca un número mayor que 0.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }
        }
    }
}
