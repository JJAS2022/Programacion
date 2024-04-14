using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Comprueba que se rellenan todos los campos
            try
            {
                // Declaración de variables día, mes y año
                int day = int.Parse(txtNum1.Text);
                int month = int.Parse(txtNum2.Text);
                int year = int.Parse(txtNum3.Text);

                // Llamada a función para saber si el año es bisiesto
                bool is_leap = leap_year(year);

                // Comprueba que el año, el mes y el día sean válidos
                if (check_year(year) && check_month(month) && check_day(day, month, is_leap))
                {
                    // Llamada a la función que calcula el día siguiente pasando los parámetros por referencia
                    next_date(ref day, ref month, ref year, is_leap);

                    // Mensaje con la fecha siguiente en formato DD/MM/AÑO
                    MessageBox.Show("La fecha siguiente es el " + day.ToString("0#") + "/" + month.ToString("0#") + "/" + year + ".");
                }
                else
                {
                    MessageBox.Show("La fecha introducida no es válida.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }

        // Función que devuelve un booleano indicando si el año es bisiesto o no
        private bool leap_year(int n1)
        {
            // Declaración de la variable booleana
            bool leap = false;

            // Algoritmo para saber si el año es bisiesto
            if (n1 % 4 == 0)
            {
                if (n1 % 100 == 0 && n1 % 400 == 0)
                {
                    leap = true;

                }
                else if (n1 % 100 == 0 && n1 % 400 != 0)
                {
                    leap = false;
                }
                else
                {
                    leap = true;
                }
            }

            // La función devuelve el valor de la variable booleana
            return leap;
        }

        // Función que comprueba si el año es válido (entre 0 y 2022)
        private bool check_year(int n1)
        {
            // Declaración de la variable booleana
            bool valid_year = false;

            // Algoritmo para saber si el año es válido
            if (n1 >= 0 && n1 <= 2022)
            {
                valid_year = true;
            }

            // Retorno de la variable booleana
            return valid_year;
        }

        // Función que comprueba si el mes es válido (entre 1 y 12)
        private bool check_month(int month)
        {
            // Declaración de la variable booleana
            bool valid_month = false;

            // Algoritmo para saber si el mes es válido
            if (month >= 1 && month <= 12)
            {
                valid_month = true;
            }

            // Retorno de la variable booleana
            return valid_month;
        }

        // Función que comprueba si el día es válido dependiendo del mes y si el año es bisiesto
        private bool check_day(int day, int month, bool leap)
        {
            // Declaración de la variable booleana
            bool valid_day = true;

            // Algoritmo para saber si el día es válido:
            // Primero, comprueba que no se introduzcan valores menores que 1 o mayores que 31
            if (day < 1 || day > 31)
            {
                valid_day = false;
            }
            // Después, si el mes es febrero, comprueba que el día no sea mayor que 28 (año no bisiesto) o 29 (año bisiesto)
            else if (day > 28 && month == 2 && !leap)
            {
                valid_day = false;
            }
            else if (day > 29 && month == 2 && leap)
            {
                valid_day = false;
            }
            // Finalmente, comprueba que, si el mes es abril, junio, septiembre o noviembre, el día no sea superior a 30
            else if (day > 30 && (month == 4 || month == 6 || month == 9 || month == 11))
            {
                valid_day = false;
            }

            // Retorno de la variable booleana
            return valid_day;
        }

        // Función que calcula la fecha siguiente sobre la base de 3 parámetros pasados por referencia, y un parámetro por valor (leap)
        private void next_date(ref int day, ref int month, ref int year, bool leap)
        {
            // Comprueba si es el último día del mes y le da valor 1 (si lo es) o le suma 1 (si no lo es)
            if ((day == 28 && month == 2 && !leap) || (day == 29 && month == 2 && leap) || (day == 30 && (month == 4 || month == 6 || month == 9 || month == 11)) || (day == 31))
            {
                day = 1;

                // Comprueba si el mes es diciembre y le da valor 1 (si lo es) o le suma 1 (si no lo es)
                if (month == 12)
                {
                    month = 1;

                    // Al ser el último día de diciembre, suma 1 al año
                    year += 1;
                }
                else
                {
                    month += 1;
                }     
            }
            else
            {
                day += 1;
            }
        }
    }
}

