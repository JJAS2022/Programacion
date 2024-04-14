using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_24
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
                string text = "";

                if (number > 0 && number <= 100)
                {
                    text = "Tabla de multiplicar del " + number + "\n";

                    for (int i = 1; i <= 10; i++)
                    {
                        int result = number * i;
                        text = text + number + " * " + i + " = " + result + "\n"; 
                    }

                    MessageBox.Show(text);
                }
                else
                {
                    MessageBox.Show("Introduce un número del 1 al 100.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }
    }
}
