using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1___Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtNumber.Text);

                if (number == 2)
                {
                    MessageBox.Show("El número introducido es el 2.");
                }
                else
                {
                    MessageBox.Show("El número introducido NO es el 2.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }
    }
}
