using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_12___Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double product1 = double.Parse(textBox1.Text);
                double product2 = double.Parse(textBox2.Text);
                double product3 = double.Parse(textBox3.Text);

                double totalPrice = product1 + product2 + product3;
                lblTotalPrice.Text = totalPrice.ToString();

                double prod1wVAT = product1 + (product1 * 0.21);
                lblProd1.Text = prod1wVAT.ToString();
                double prod2wVAT = product2 + (product2 * 0.21);
                lblProd2.Text = prod2wVAT.ToString();
                double prod3wVAT = product3 + (product3 * 0.21);
                lblProd3.Text = prod3wVAT.ToString();

                double priceWithVAT = prod1wVAT + prod2wVAT + prod3wVAT;
                lblPriceWithVAT.Text = priceWithVAT.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error siguiente: " + fEx.Message);
            }
        }
    }
}
