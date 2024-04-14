using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6___Tema_3
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
                double grade = double.Parse(txtNum.Text);

                if (grade >= 0 && grade <=10)
                {
                    if (grade < 3)
                    {
                        lblResultado.Text = "Muy deficiente";
                    }
                    else if (grade >= 3 && grade < 5)
                    {
                        lblResultado.Text = "Insuficiente";
                    }
                    else if (grade >= 5 && grade < 6)
                    {
                        lblResultado.Text = "Suficiente";
                    }
                    else if (grade >= 6 && grade < 7)
                    {
                        lblResultado.Text = "Bien";
                    }
                    else if (grade >= 7 && grade < 9)
                    {
                        lblResultado.Text = "Notable";
                    }
                    else
                    {
                        lblResultado.Text = "Sobresaliente";
                    }
                }
                else
                {
                    MessageBox.Show("La nota debe estar entre 0 y 10.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }
    }
}
