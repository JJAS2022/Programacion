using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_10
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
                int number = int.Parse(txtNum.Text);

                int potencia2 = potencia(number, 2);
                int potencia5 = potencia(number, 5);
                int potencia7 = potencia(number, 7);

                MessageBox.Show("El número elevado a la 2 es " + potencia2.ToString() + ".\n" +
                                "El número elevado a la 5 es " + potencia5.ToString() + ".\n" +
                                "El número elevado a la 7 es " + potencia7.ToString() + ".");
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private int potencia(int n1, int n2)
        {
            int n3 = 1;

            for (int i = 1; i<= n2; i++)
            {
                n3 *= n1;
            }

            return n3;
        }
    }
}
