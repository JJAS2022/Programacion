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

namespace Tema_5___Ejercicio_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int ELEMENTOS = 3;    
        int[,] matriz = new int[ELEMENTOS, ELEMENTOS];
        int contadorFilas = 0;
        int contadorColumnas = 0;

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                while (contadorFilas < ELEMENTOS)
                {
                    int numero = int.Parse(Interaction.InputBox("Introduzca el elemento " + (contadorFilas + 1) + " x " + (contadorColumnas + 1) + "."));
                    matriz[contadorFilas, contadorColumnas] = numero;
                    contadorColumnas++;
                    if (contadorColumnas == ELEMENTOS)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "";           

            for (int i = 0; i < ELEMENTOS; i++)
            {
                int sumaFila = 0;
                for (int j = 0; j < ELEMENTOS; j++)
                {
                    texto += matriz[i, j] + "  ";
                    sumaFila += matriz[i, j];
                }
                texto += sumaFila;
                texto += "\n";
            }

            for (int i = 0; i < ELEMENTOS; i++)
            {
                int sumaColumna = matriz[0, i] + matriz[1, i] + matriz[2, i];
                texto += sumaColumna + " ";
            }

            MessageBox.Show(texto);
        }
    }
}
