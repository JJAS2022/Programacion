using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNum.Text);

            int result = Factorial(number);

            MessageBox.Show("El factorial de " + number.ToString() + " es " + result.ToString() + ".");
        }

        private int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
    }
}
