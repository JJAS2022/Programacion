using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Captura la excepción si no se introduce un valor
            try
            {
                // Limpia el texto anterior si se reutiliza la aplicación
                lblResult.Text = "";

                //Sitúa el cursor en el textBox
                txtNum.Focus();

                // Declaración e inicialización de la variable con el valor introducido por el usuario
                double value = double.Parse(txtNum.Text);

                // Separa en dos variables el importe entero de euros y de céntimos
                int euros = (int)value;
                double parteDecimal = Math.Round((value - (double)euros) * 100);
                int cents = (int)parteDecimal;

                // Llama a la funciones para calcular los billetes y monedas de euro
                // Los valores se envían por referencia para que se repita el bucle while hasta que el valor llegue a 0
                while (euros > 0)
                {
                    getBills(ref euros, " billete", 500, " euro");
                    getBills(ref euros, " billete", 200, " euro");
                    getBills(ref euros, " billete", 100, " euro");
                    getBills(ref euros, " billete", 50, " euro");
                    getBills(ref euros, " billete", 20, " euro");
                    getBills(ref euros, " billete", 10, " euro");
                    getBills(ref euros, " billete", 5, " euro");
                    getBills(ref euros, " moneda", 2, " euro");
                    getBills(ref euros, " moneda", 1, " euro");
                }

                // Llama a la función para calcular las monedas de céntimo
                // El valor se envía por referencia para que se repita el bucle while hasta que el valor llegue a 0
                while (cents > 0) 
                {
                    getBills(ref cents, " moneda", 50, " céntimo");
                    getBills(ref cents, " moneda", 20, " céntimo");
                    getBills(ref cents, " moneda", 10, " céntimo");
                    getBills(ref cents, " moneda", 5, " céntimo");
                    getBills(ref cents, " moneda", 2, " céntimo");
                    getBills(ref cents, " moneda", 1, " céntimo");
                }             
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }

        // Función para calcular los billetes y monedas
        private void getBills(ref int number, string type, int value, string currency)
        {
            // Declaración de la variable para almacenar los billetes y monedas
            int bills = 0;

            // Si el importe restante en euros o céntimos es mayor o igual que el valor del billete o moneda,
            // calcula cuántos billetes o monedas resultan y actualiza el importe restante.
            // Finalmente, llama a la función para actualizar el texto resultante
            if (number >= value)
            {
                bills = number / value;
                number = number % value;
                showBills(bills, type, value, currency);
            }           
        }     

        // Función que añade texto a la etiqueta de resultado según el número de billetes o monedas y su valor
        private void showBills(int bills, string type, int value, string currency)
        {
            // Se adapta el texto según sea uno o varios billetes o monedas, y su valor
            if (bills == 1)
            {
                if (value == 1)
                {
                    lblResult.Text += bills + type + " de " + value + currency + "\n";
                }
                else
                {
                    lblResult.Text += bills + type + " de " + value + currency + "s\n";
                }               
            }
            else
            {
                lblResult.Text += bills + type + "s de " + value + currency + "s\n";
            }
        }
    }
}
