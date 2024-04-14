using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5___Tema_3
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
                int num3 = int.Parse(txtNum3.Text);

                int mayor = 0;

                if (num1 >= num2)
                {
                    mayor = num1;
                }
                else if (num2 > num1)
                {
                    mayor = num2;
                }
                if (num3 > mayor)
                {
                    mayor = num3;
                }

                MessageBox.Show("El número mayor es el " + mayor);
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }
    }
}
