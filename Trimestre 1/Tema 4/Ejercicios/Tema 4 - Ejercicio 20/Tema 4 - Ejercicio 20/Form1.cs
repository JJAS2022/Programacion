using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int potencia (int n, int m)
        {
            if (m == 1)
            {
                return n;
            }
            else
            {
                return n * potencia(n, m - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numBase = int.Parse(txtNum1.Text);
                int numExponente = int.Parse(txtNum2.Text);
                int resultado = potencia(numBase, numExponente);
                MessageBox.Show("La potencia es " + resultado + ".");
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int numBase = int.Parse(txtNum1.Text);
                int numExponente = int.Parse(txtNum2.Text);
                int resultado = 1;
                for (int i = 1; i <= numExponente; i++) 
                {
                    resultado *= numBase;
                }
                MessageBox.Show("La potencia es " + resultado + ".");
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }
    }
}
