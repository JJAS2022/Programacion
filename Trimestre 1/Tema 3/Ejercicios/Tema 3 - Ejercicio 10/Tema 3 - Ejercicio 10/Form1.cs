using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_3___Ejercicio_10
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
                lResultado.Text = "";
                txtNum.Focus();

                double valor = double.Parse(txtNum.Text);
                int cantidad = (int)valor;
                double céntimos = Math.Round((valor - (double)cantidad) * 100);
                int monedas = (int)céntimos;
                int billetes = 0;
                txtNum.Text = "";

                // Calcular billetes
                if (cantidad >= 500)
                {
                    billetes = cantidad / 500;
                    cantidad = cantidad % 500;
                    lResultado.Text = lResultado.Text + billetes + " billetes de 500 euros" + "\n";
                }
                if (cantidad >= 200)
                {
                    billetes = cantidad / 200;
                    cantidad = cantidad % 200;
                    lResultado.Text = lResultado.Text + billetes + " billetes de 200 euros" + "\n";
                }
                if (cantidad >= 100)
                {
                    billetes = cantidad / 100;
                    cantidad = cantidad % 100;
                    lResultado.Text = lResultado.Text + billetes + " billetes de 100 euros" + "\n";
                }
                if (cantidad >= 50)
                {
                    billetes = cantidad / 50;
                    cantidad = cantidad % 50;
                    lResultado.Text = lResultado.Text + billetes + " billetes de 50 euros" + "\n";
                }
                if (cantidad >= 20)
                {
                    billetes = cantidad / 20;
                    cantidad = cantidad % 20;
                    lResultado.Text = lResultado.Text + billetes + " billetes de 20 euros" + "\n";
                }
                if (cantidad >= 10)
                {
                    billetes = cantidad / 10;
                    cantidad = cantidad % 10;
                    lResultado.Text = lResultado.Text + billetes + " billetes de 10 euros" + "\n";
                }
                if (cantidad >= 5)
                {
                    billetes = cantidad / 5;
                    cantidad = cantidad % 5;
                    lResultado.Text = lResultado.Text + billetes + " billetes de 5 euros" + "\n";
                }
                if (cantidad >= 2)
                {
                    billetes = cantidad / 2;
                    cantidad = cantidad % 2;
                    lResultado.Text = lResultado.Text + billetes + " monedas de 2 euros" + "\n";
                }
                if (cantidad >= 1)
                {
                    billetes = cantidad / 1;
                    cantidad = cantidad % 1;
                    lResultado.Text = lResultado.Text + billetes + " monedas de 1 euro" + "\n";
                }

                // Calculate cent coins
                if (monedas >= 50)
                {
                    billetes = monedas / 50;
                    monedas = monedas % 50;
                    lResultado.Text = lResultado.Text + billetes + " monedas de 50 céntimos" + "\n";
                }
                if (monedas >= 20)
                {
                    billetes = monedas / 20;
                    monedas = monedas % 20;
                    lResultado.Text = lResultado.Text + billetes + " monedas de 20 céntimos" + "\n";
                }
                if (monedas >= 10)
                {
                    billetes = monedas / 10;
                    monedas = monedas % 10;
                    lResultado.Text = lResultado.Text + billetes + " monedas de 10 céntimos" + "\n";
                }
                if (monedas >= 5)
                {
                    billetes = monedas / 5;
                    monedas = monedas % 5;
                    lResultado.Text = lResultado.Text + billetes + " monedas de 5 céntimos" + "\n";
                }
                if (monedas >= 2)
                {
                    billetes = monedas / 2;
                    monedas = monedas % 2;
                    lResultado.Text = lResultado.Text + billetes + " monedas de 2 céntimos" + "\n";
                }
                if (monedas >= 1)
                {
                    billetes = monedas / 1;
                    monedas = monedas % 1;
                    lResultado.Text = lResultado.Text + billetes + " monedas de 1 céntimo" + "\n";
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }
    }
}
