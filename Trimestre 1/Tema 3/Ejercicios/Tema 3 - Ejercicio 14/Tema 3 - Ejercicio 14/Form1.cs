﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            MessageBox.Show(sum.ToString());
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int i = 1;
            while (i <= 10)
            {
                sum += i;
                i++;
            }
            MessageBox.Show(sum.ToString());
        }
    }
}