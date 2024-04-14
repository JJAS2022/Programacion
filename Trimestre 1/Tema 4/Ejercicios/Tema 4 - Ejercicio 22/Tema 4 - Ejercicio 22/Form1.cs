using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int digitos(int n) 
        { 
            if (n / 10 == 0) 
            {
                return 1;
            }
            else
            {
                return 1 + digitos(n / 10);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNum.Text);
                int resultado = digitos(numero);
                MessageBox.Show("El número " + numero + " tiene " + resultado + " dígitos.");
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
                int digitos = 1;
                int tmp = numero;
                while (tmp / 10 != 0)
                {
                    digitos++;
                    tmp = tmp / 10;
                }
                MessageBox.Show("El número " + numero + " tiene " + digitos + " dígitos.");
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }
    }
}
