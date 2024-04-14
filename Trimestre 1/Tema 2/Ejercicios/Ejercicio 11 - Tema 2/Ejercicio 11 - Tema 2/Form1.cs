using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_11___Tema_2
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
                double capital = double.Parse(txtAmount.Text);
                double interest = double.Parse(txtInterest.Text) / 100;
                double accrued = capital + (capital * interest);
                txtResult.Text = accrued.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }
        }
    }
}
