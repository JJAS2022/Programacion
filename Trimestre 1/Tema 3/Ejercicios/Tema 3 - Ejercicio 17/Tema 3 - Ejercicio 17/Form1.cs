using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string text = "";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    text = text + i.ToString() + ",";
                }
            }

            MessageBox.Show(text);
        }
    }
}
