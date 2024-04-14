using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int fact(int numero)
        {
            if (numero == 1)
            {
                return 1;
            }
            else
            {
                return numero * fact(numero - 1);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNum.Text);

                int factorial = fact(numero);

                MessageBox.Show("El factorial de " + numero + " es " + factorial + ".");
            }
            catch (FormatException fEx) 
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNum.Text);
                int resultado = 1;

                for (int i = numero; i > 0; i--) 
                {
                    resultado *= i;
                }

                MessageBox.Show("El factorial de " + numero + " es " + resultado + ".");
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }
    }
}
