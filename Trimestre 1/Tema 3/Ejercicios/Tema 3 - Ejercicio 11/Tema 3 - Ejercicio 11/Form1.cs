using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNextTime_Click(object sender, EventArgs e)
        {
            // Captura que no se dejen textBox en blanco
            try
            {
                // Almacena y valida la hora si está entre 0 y 24
                bool validHour = true;
                int hour = int.Parse(txtHour.Text);
                if (hour < 0 || hour > 23)
                {
                    validHour = false;
                }

                // almacena y valida el minuto si está entre 0 y 59
                bool validMinute = true;
                int minute = int.Parse(txtMinute.Text);
                if (minute < 0 || minute > 59)
                {
                    validMinute = false;
                }

                // Almacena y valida el segundo si está entre 0 y 59
                bool validSecond = true;
                int second = int.Parse(txtSecond.Text);
                if (second < 0 || second > 59)
                {
                    validSecond = false;
                }

                // Declara variables para la siguiente hora
                int nextSecond, nextMinute, nextHour = 0;

                // Calcula el próximo segundo
                if (second != 59)
                {
                    nextSecond = second + 1;
                }
                else
                {
                    nextSecond = 0;
                }

                // Calcula si cambia el minuto según el segundo introducido
                if (second == 59)
                {                   
                    // Si cambia el minuto, calcula el próximo minuto
                    if (minute != 59)
                    {
                        nextMinute = minute + 1;
                    }
                    else
                    {
                        nextMinute = 0;
                    }
                }
                else
                {
                    nextMinute = minute;
                }

                // Calcula si cambia la hora según el minuto y el segundo introducidos
                if (minute == 59 && second == 59)
                {
                    // Si cambia la hora, calcula la próxima hora
                    if (hour != 23)
                    {
                        nextHour = hour + 1;
                    }
                    else
                    {
                        nextHour = 0;
                    }
                }
                else
                {
                    nextHour = hour;
                }

                // Muestra la hora siguiente si se han introducido datos válidos
                if (validHour && validMinute && validSecond)
                {
                    MessageBox.Show("La hora siguiente será " + nextHour.ToString("0#") + " : " + nextMinute.ToString("0#") + " : " + nextSecond.ToString("0#") + ".");
                }
                else
                {
                    MessageBox.Show("Introduce una hora entre las 00:00:00 y las 23:59:59.");
                }
                
                // Enfoca en el textBox de hora
                txtHour.Focus();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }
    }
}
