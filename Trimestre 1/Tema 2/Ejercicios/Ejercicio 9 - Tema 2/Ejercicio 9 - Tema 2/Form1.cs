using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9___Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 + num2;
                textBox3.Text = result.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 - num2;
                textBox3.Text = result.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 * num2;
                textBox3.Text = result.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double result = num1 / num2;
                textBox3.Text = result.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }
            catch (DivideByZeroException zeroEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + zeroEx.Message);
            }
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 % num2;
                textBox3.Text = result.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }
            catch (DivideByZeroException zeroEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + zeroEx.Message);
            }
        }
    }
}
