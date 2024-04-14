using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Captura la excepción si no se introducen valores
            try
            {
                // Variables guardan valores n y m
                int num1 = int.Parse(txtNum1.Text);
                int num2 = int.Parse(txtNum2.Text);

                // Llamada a la función para calcular la serie pasándole las variables por valor
                double result = calculateSeries(num1, num2);

                // Muestra por mensaje el resultado del cálculo, redondeado a dos decimales
                MessageBox.Show("El resultado de la serie es " + result.ToString("0.##"));
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error :" + fEx.Message);
            }
        }

        // Función que calcula la serie principal
        private double calculateSeries(int n, int m)
        {
            // Variable que almacena el resultado de la serie
            double result = 0; 

            // Bucle que se repite n veces, según el parámetro introducido
            for (int i = 1; i <= n; i++)
            {
                // El resultado de la serie se va acumulando en cada iteración del bucle
                // Llamada de las funciones para calcular la potencia y el factorial en cada iteración, según el valor de i
                result += (double)pow(m, i) / fact(i);
            }

            // Devuelve el resultado de la serie 
            return result;
        }

        // Función que calcula de forma recursiva la potencia del número m al exponente i de la función anterior
        private int pow(int baseNum, int exponent)
        {
            // Caso base: Si el exponente es 1, devuelve la base
            if (exponent == 1)
            {
                return baseNum;
            }
            // Caso recursivo: Multiplica la base por el ella misma elevada a la potencia menos 1
            else
            {
                return baseNum * pow(baseNum, exponent - 1);
            }
        }

        // Función que calcula de forma recursiva el factorial del número n
        private int fact(int number)
        {
            // Caso base: Si el número es 1, devuelve 1
            if (number == 1)
            {
                return 1;
            }
            // Caso recursivo: Multiplica el número por el factorial del número menos 1
            else
            {
                return number * fact(number - 1);
            }
        }

    }
}
