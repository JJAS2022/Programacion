using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            bool primo = true;
            int number = int.Parse(txtNum.Text);

            // Itera los números del 2 al inmediatamente anterior al número introducido
            for (int i = 2; i < number; i++)
            {
                // Si el número es divisible entre alguno de ellos, entonces no es primo
                if (number % i == 0)
                {
                    primo = false;
                }
            }

            // Imprime el resultado según el número sea primo o no
            if (primo)
            {
                MessageBox.Show("El número " + number + " es primo.");
            }
            else
            {
                MessageBox.Show("El número " + number + " NO es primo.");
            }
        }
    }
}
