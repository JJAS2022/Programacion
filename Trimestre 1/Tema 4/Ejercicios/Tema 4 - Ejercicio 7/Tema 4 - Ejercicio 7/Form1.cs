using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_7
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
                int num1 = int.Parse(txtNum1.Text);
                int num2 = int.Parse(txtNum2.Text);

                int result = max_comun_div(num1, num2);

                MessageBox.Show("El máximo común divisor es " + result.ToString());

            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        int max_comun_div(int number1, int number2)
        {
            while (number2 != 0)
            {
                int tmp = number2;
                number2 = number1 % number2;
                number1 = tmp;
            }
            return number1;
        }
    }
}
