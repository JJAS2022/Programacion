using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2___Tema_3
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

                if (number1 == number2)
                {
                    MessageBox.Show("Los números son iguales");
                }
                else
                {
                    MessageBox.Show("Los números NO son iguales");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }         
        }
    }
}
