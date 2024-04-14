using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_16
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
                int number = int.Parse(txtNum.Text);

                int fact = factorial(number);

                MessageBox.Show("El factorial de " + number + " es " + fact + ".");
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private int factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else 
            {
                return number * factorial(number - 1);
            }
        }
    }
}
