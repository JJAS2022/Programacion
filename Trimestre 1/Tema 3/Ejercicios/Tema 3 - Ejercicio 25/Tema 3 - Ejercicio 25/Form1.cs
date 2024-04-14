using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ShowTable(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ShowTable(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ShowTable(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ShowTable(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ShowTable(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ShowTable(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ShowTable(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ShowTable(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ShowTable(9);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            ShowTable(10);
        }

        private void ShowTable(int number)
        {
            string text = "Tabla de multiplicar del " + number + "\n";

            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                text = text + number + " * " + i + " = " + result + "\n";
            }

            MessageBox.Show(text);
        }
    }
}
