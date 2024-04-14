using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Tema_3___Ejercicio_21
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
                int number = int.Parse(txtNum.Text);

                if (number >= 1 && number <= 15)
                {
                    string text = "";

                    for (int i = 0; i < number; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            if (j != 10)
                            {
                                text = text + j.ToString() + ",";
                            }
                            else
                            {
                                text = text + j.ToString() + "." + "\n";
                            }
                        }
                    }

                    MessageBox.Show(text);
                }
                else
                {
                    MessageBox.Show("Introduce un número entre 1 y 15");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }
    }
}
