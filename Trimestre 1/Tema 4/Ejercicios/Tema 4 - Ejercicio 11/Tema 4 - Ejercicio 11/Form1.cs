using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_11
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
                int year = int.Parse(txtNum.Text);

                if (bisiesto(year))
                {
                    MessageBox.Show("El año introducido es bisiesto.");
                }
                else
                {
                    MessageBox.Show("El año introducido NO es bisiesto.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private bool bisiesto(int number)
        {
            bool bisiesto = false;

            if (number % 4 == 0)   
            {
                if (number % 100 == 0)
                {
                    if (number % 400 == 0)
                    {
                        bisiesto = true;
                    }
                }
                else
                {
                    bisiesto = true;
                }              
            }

            return bisiesto;
        }
    }
}
