using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3___Tema_3
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
                if (number1 > number2)
                {
                    MessageBox.Show("El número " + number1.ToString() + " es el mayor.");
                }
                else 
                {
                    MessageBox.Show("El número " + number2.ToString() + " es el mayor.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }
        }
    }
}
