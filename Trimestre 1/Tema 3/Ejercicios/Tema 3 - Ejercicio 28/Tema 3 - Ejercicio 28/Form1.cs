using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = int.Parse(txtNum1.Text);
                int number2 = int.Parse(txtNum2.Text);
                int sum = 0;

                if (number1 >= 0)
                {
                    for (int i = 0; i < number1; i++)
                    {
                        sum += number2;
                    }
                }
                else if (number2 >= 0)
                {
                    for (int i = 0; i < number2; i++)
                    {
                        sum += number1;
                    }
                }
                else
                {
                    for (int i = number1; i < 0; i++)
                    {
                        sum += number2 * -1;
                    }
                }
                
                MessageBox.Show("El resultado es " + sum);
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }
    }
}
