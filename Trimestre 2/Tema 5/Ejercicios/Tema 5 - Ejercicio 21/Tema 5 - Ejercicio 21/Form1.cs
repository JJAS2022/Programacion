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

namespace Tema_5___Ejercicio_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int FILAS = 5;
        const int COLUMNAS = 4;
        int[,] matriz = new int[FILAS, COLUMNAS];

        private void rellenarMatriz()
        {
            try
            {
                int contadorFilas = 0;
                int contadorColumnas = 0;
                while (contadorFilas < FILAS)
                {
                    int numero = int.Parse(Interaction.InputBox("Introduzca elemento " + (contadorFilas + 1) + " x " + (contadorColumnas + 1) + "."));
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

        private void rotarMatriz()
        {           
            for (int i = 0; i < FILAS; i++)
            {
                int tmp = 0;
                for (int j = (COLUMNAS - 1); j >= 0; j--)
                {
                    if (j == (COLUMNAS - 1))
                    {
                        tmp = matriz[i, j];
                    }
                    if (j > 0)
                    {
                        matriz[i, j] = matriz[i, (j - 1)];
                    }
                    else
                    {
                        matriz[i, j] = tmp;
                    }                                    
                }
            }
        }

        private void mostrarMatriz()
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

        private void button1_Click(object sender, EventArgs e)
        {
            rellenarMatriz();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rotarMatriz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrarMatriz();
        }
    }
}
