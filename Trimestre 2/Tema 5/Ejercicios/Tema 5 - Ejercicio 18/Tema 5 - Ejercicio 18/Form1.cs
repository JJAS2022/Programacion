using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_5___Ejercicio_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] matriz = new int[3, 3];

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = int.Parse(txtFila.Text);
                int columna = int.Parse(txtColumna.Text);
                int valor = int.Parse(txtValor.Text);

                if ((fila < 0 || fila > 3) || (columna < 0 || columna > 3))
                {
                    MessageBox.Show("Las filas y columnas van de la 1 a la 3.");
                }
                else 
                {
                    matriz[(fila - 1), (columna - 1)] = valor;
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "Los valores de la matriz son los siguientes:\n";

            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++)
                {
                    texto += matriz[i, j] + " ";
                }
                texto += "\n";
            }

            MessageBox.Show(texto);
        }
    }
}
