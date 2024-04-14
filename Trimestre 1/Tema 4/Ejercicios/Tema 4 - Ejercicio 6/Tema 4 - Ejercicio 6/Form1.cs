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

namespace Tema_4___Ejercicio_6
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

                int cociente;
                int resto;

                divideNumbers(num1, num2, out cociente, out resto);

                MessageBox.Show("El cociente es " + cociente.ToString() + " y el resto es " + resto.ToString() + ".");
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        void divideNumbers(int number1, int number2, out int cociente, out int resto)
        {
            cociente = number1 / number2;
            resto = number1 % number2;
        }
    }
}
