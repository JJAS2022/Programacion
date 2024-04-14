using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_5___Ejercicio_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int FILAS = 4;
        const int COLUMNAS = 5;
        int[,] matriz = new int[FILAS, COLUMNAS];

        void rellenarMatriz()
        {
            int numero = 1;
            int contador = 0;

            while (contador < COLUMNAS)
            {
                if (contador % 2 == 0)
                {
                    for (int i = 0; i < FILAS; i++)
                    {
                        matriz[i, contador] = numero;
                        numero++;
                    }
                }
                else
                {
                    for (int i = (FILAS - 1); i >= 0; i--)
                    {
                        matriz[i, contador] = numero;
                        numero++;
                    }
                }
                contador++;
            }
        }

        void mostrarMatriz()
        {
            string texto = "";

            for (int i = 0; i < FILAS; i++)
            {
                for (int j = 0; j < COLUMNAS; j++)
                {
                    texto += matriz[i, j] + " ";
                }
                texto += "\n";
            }

            MessageBox.Show(texto);
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            rellenarMatriz();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarMatriz();
        }
    }
}
