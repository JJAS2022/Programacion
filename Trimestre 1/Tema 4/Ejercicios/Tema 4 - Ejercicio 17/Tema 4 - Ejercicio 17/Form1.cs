using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_17
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

                double division = divide(num1, num2);

                MessageBox.Show("La división resultado es " + division);
            }
            catch (FormatException fEx) 
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private int divide(int num1, int num2)
        {
            int counter = 0;

            while (num1 != 0)
            {
                num1 = num1 - num2;
                counter++;
            }

            return counter;
        }
    }
}
