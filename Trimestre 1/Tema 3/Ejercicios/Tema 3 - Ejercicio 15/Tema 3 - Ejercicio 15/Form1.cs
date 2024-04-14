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

namespace Tema_3___Ejercicio_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int number = 0;
            int lower = 0;
            int higher = 0;
            int counter = 0;
            do
            {
                try
                {
                    number = int.Parse(Interaction.InputBox("Escribe un número", "Ejercicio 15"));
                }
                catch (FormatException fEx)
                {
                    MessageBox.Show("Se ha producido el error: " + fEx.Message);
                }

                if (counter == 0)
                {
                    higher = number;
                    lower = number;
                }
                else
                {
                    if (number > higher)
                    {
                        higher = number;
                    }
                    if (number <= lower && number >= 0)
                    {
                        lower = number;
                    }
                }
                counter++;
            }
            while (number >= 0);

            MessageBox.Show("El mayor número introducido ha sido el " + higher.ToString() + " y el menor ha sido el " + lower.ToString() + ".");
        }
    }
}
