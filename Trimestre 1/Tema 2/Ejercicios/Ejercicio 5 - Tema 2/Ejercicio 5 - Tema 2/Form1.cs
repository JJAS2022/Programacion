using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5___Tema_2
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
                int num1 = int.Parse(BoxNum1.Text);
                int num2 = int.Parse(BoxNum2.Text);
                int resultado = num1 + num2;
                BoxResult.Text = resultado.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(BoxNum1.Text);
            int num2 = int.Parse(BoxNum2.Text);
            int resultado = num1 - num2;
            BoxResult.Text = resultado.ToString();
        }
    }
}
