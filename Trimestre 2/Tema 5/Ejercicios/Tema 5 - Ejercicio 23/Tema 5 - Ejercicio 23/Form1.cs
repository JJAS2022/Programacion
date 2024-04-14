using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_5___Ejercicio_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int FILAS = 5;
        const int COLUMNAS = 5;
        int[,] matriz = new int[FILAS, COLUMNAS];

        void rellenarMatriz()
        {
            int contadorFilas = 0;
            int contadorColumnas = 0;

            while (contadorFilas < FILAS)
            {
                int numero = int.Parse(Interaction.InputBox("Introduce elemento " + (contadorFilas + 1) + "x" + (contadorColumnas + 1) + "."));
                matriz[contadorFilas, contadorColumnas] = numero;
                contadorColumnas++;
                if (contadorColumnas == COLUMNAS)
                {
                    contadorFilas++;
                    contadorColumnas = 0;
                }
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

        void sumarDiagonal()
        {
            int suma = 0;
            
            for (int i = 0; i < FILAS; i++)
            {
                if (i == 0 || i == (FILAS - 1))
                {
                    suma += matriz[i, 0] + matriz[i, (COLUMNAS - 1)];
                }
                else if (i == 1 || i == (FILAS - 2))
                {
                    suma += matriz[i, 1] + matriz[i, (COLUMNAS - 2)];
                }
                else
                {
                    suma += matriz[2, 2]; 
                }
            }

            MessageBox.Show("La suma es " + suma + ".");
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            rellenarMatriz();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarMatriz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sumarDiagonal();
        }
    }
}
