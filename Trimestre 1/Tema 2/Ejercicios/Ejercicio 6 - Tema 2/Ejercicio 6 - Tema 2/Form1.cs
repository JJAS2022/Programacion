using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6___Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt1.Text);
            int num2 = int.Parse(txt2.Text);
            int cociente = num1 / num2;
            int resto = num1 % num2;

            MessageBox.Show("El cociente es " + cociente + " y el resto es " + resto + ".");
        }
    }
}
