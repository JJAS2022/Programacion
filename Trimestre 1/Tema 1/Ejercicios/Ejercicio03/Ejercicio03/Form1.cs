using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            TBox.Text = "Se ha pulsado el botón 1.";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            TBox.Text = "Se ha pulsado el botón 2.";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            TBox.Text = "";
        }
    }
}
