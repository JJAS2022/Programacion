using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tema_5___Ejercicio_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int FILAS = 3;
        const int COLUMNAS = 4;
        int[,] matriz1 = new int[FILAS, COLUMNAS];
        int[,] matriz2 = new int[FILAS, COLUMNAS];
        int[,] matriz3 = new int[FILAS, COLUMNAS];

        private void rellenarMatriz(int[,] matriz)
        {
            try
            {
                int contadorFilas = 0;
                int contadorColumnas = 0;
                while (contadorFilas < FILAS)
                {
                    int numero = int.Parse(Interaction.InputBox("Introduzca el elemento " + (contadorFilas + 1) + " x " + (contadorColumnas + 1) + "."));
                    matriz[contadorFilas, contadorColumnas] = numero;
                    contadorColumnas++;
                    if (contadorColumnas == COLUMNAS)
                    {
                        contadorFilas++;
                        contadorColumnas = 0;
                    }
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private void mostrarMatriz(int[,] matriz)
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

        private void sumarMatrices()
        {
            for (int i = 0; i < FILAS; i++)
            {
                for (int j = 0; j < COLUMNAS; j++)
                {
                    matriz3[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rellenarMatriz(matriz1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rellenarMatriz(matriz2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sumarMatrices();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mostrarMatriz(matriz1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mostrarMatriz(matriz2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mostrarMatriz(matriz3);
        }
    }
}
