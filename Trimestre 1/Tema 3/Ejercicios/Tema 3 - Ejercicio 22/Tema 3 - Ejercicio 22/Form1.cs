using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_22
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

                if (number >= 14681 && number <= 15681 || number >= 70001 && number <= 79999 || number >= 88888 && number <= 111111)
                {
                    MessageBox.Show("El producto es defectuoso.");
                }
                else
                {
                    MessageBox.Show("El producto no es defectuoso.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }
    }
}
