using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_9
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
                lblResult.Text = "";

                int number = int.Parse(txtNum.Text);
                int bills = 0;

                if (number >= 10000)
                {
                    bills = number / 10000;
                    number = number % 10000;
                    lblResult.Text = lblResult.Text + bills.ToString() + " billetes de 10000" + "\n";
                }
                if (number >= 5000)
                {
                    bills = number / 5000;
                    number = number % 5000;
                    lblResult.Text = lblResult.Text + bills.ToString() + " billetes de 5000" + "\n";
                }
                if (number >= 2000)
                {
                    bills = number / 2000;
                    number = number % 2000;
                    lblResult.Text = lblResult.Text + bills.ToString() + " billetes de 2000" + "\n";
                }
                if (number >= 1000)
                {
                    bills = number / 1000;
                    number = number % 1000;
                    lblResult.Text = lblResult.Text + bills.ToString() + " billetes de 1000" + "\n";
                }
                if (number >= 100)
                {
                    bills = number / 100;
                    number = number % 100;
                    lblResult.Text = lblResult.Text + bills.ToString() + " monedas de 100" + "\n";
                }           
                if (number >= 25)
                {
                    bills = number / 25;
                    number = number % 25;
                    lblResult.Text = lblResult.Text + bills.ToString() + " monedas de 25" + "\n";
                }             
                if (number < 0)
                {
                    MessageBox.Show("Introduce una cantidad válida.");
                }

                txtNum.Focus();
                txtNum.Text = "";
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }
    }
}
