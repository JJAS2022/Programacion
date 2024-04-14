using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10___Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPesetas_Click(object sender, EventArgs e)
        {
            try
            {
                double euros = double.Parse(txtEuros.Text);
                double pesetas = euros * 166.3860;
                txtPesetas.Text = pesetas.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }
        }

        private void btnEuros_Click(object sender, EventArgs e)
        {
            try
            {
                double pesetas = double.Parse(txtPesetas.Text);
                double euros = pesetas * 0.0060;
                txtEuros.Text = euros.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
            }
        }
    }
}
