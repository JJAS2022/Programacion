using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_9
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
                int num1 = int.Parse(txtNum1.Text);
                int num2 = int.Parse(txtNum2.Text);

                int potencia = calcular_potencia(num1, num2);

                MessageBox.Show("La potencia es " + potencia.ToString());
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private int calcular_potencia(int n1, int n2)
        {
            int n3 = 1;

            for (int i = 1; i <= n2; i++)
            {
                n3 *= n1;
            }

            return n3;
        }
    }
}
