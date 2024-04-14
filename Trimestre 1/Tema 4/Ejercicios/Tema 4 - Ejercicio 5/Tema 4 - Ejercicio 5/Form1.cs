using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNum1.Text);
                int num2 = int.Parse(txtNum2.Text);

                showHigher(num1, num2);

            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        void showHigher(int number1, int number2)
        {
            if (number1 > number2)
            {
                MessageBox.Show("El número mayor es el " + number1.ToString() + ".");
            }
            else if (number1 < number2)
            {
                MessageBox.Show("El número mayor es el " + number2.ToString() + ".");
            }
            else
            {
                MessageBox.Show("Los números son iguales.");
            }
        }
    }
}
