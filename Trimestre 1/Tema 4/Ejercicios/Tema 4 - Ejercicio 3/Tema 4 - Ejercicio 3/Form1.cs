using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_3
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

                interchangeValues(ref num1, ref num2);

                txtNum1.Text = num1.ToString();
                txtNum2.Text = num2.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }

            void interchangeValues (ref int number1, ref int number2)
            {
                int tmp = number1;
                number1 = number2;
                number2 = tmp;
            }
        }
    }
}
