using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int baseNum = int.Parse(txtBase.Text);
            int expNum = int.Parse(txtExponente.Text);

            int potencia = 1;

            for (int i = 0; i < expNum; i++)
            {
                potencia *= baseNum;
            }

            MessageBox.Show("El resultado de " + baseNum + " elevado a la " + expNum + " es " + potencia + ".");
        }
    }
}
