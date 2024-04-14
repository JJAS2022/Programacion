using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tema_3___Ejercicio_16
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
                int number = 0;
                int sum = 0;

                do
                {
                    number = int.Parse(Interaction.InputBox("Indica un número del 0 al 9.", "Ejercicio 16"));
                    if (number >= 0 && number <= 9)
                    {
                        sum += number;
                    }
                }
                while (number >= 0 && number <= 9);

                if (sum == 0)
                {
                    MessageBox.Show("Introduce números del 0 al 9.");
                }
                else
                {
                    MessageBox.Show("La suma de los números introducidos es " + sum.ToString() + ".");
                }

            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error siguiente: " + fEx.Message);
            }
        }
    }
}
