using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtNum.Text);
                string text = "";

                for (int i = 1; i <= number; i++)
                {
                    if (i != number)
                    {
                        text = text + i.ToString() + ",";
                    }
                    else
                    {
                        text = text + i.ToString() + ".";
                    }
                }
                MessageBox.Show(text);
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtNum.Text);
                string text = "";
                int i = 1;


                while (i < number)
                {
                    text = text + i.ToString() + ",";
                    i++;
                }

                MessageBox.Show(text + number + ".");
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtNum.Text);
                string text = "";
                int i = 1;

                do
                {
                    text = text + i.ToString() + ",";
                    i++;
                }
                while (i < number);

                MessageBox.Show(text + number + ".");
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }
    }
}
