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

namespace Tema_5___Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int CANTIDAD = 10;
        int[] numeros = new int[CANTIDAD];

        private void sustituirPositivos()
        {
            for (int i = 0; i < CANTIDAD; i++)
            {
                if (numeros[i] > 0)
                {
                    numeros[i] = 0;
                }
            }
        }

        private void mostrarArray()
        {
            string texto = "Los valores del array son ";
            for (int i = 0; i < CANTIDAD; i++)
            {
                if (i < (CANTIDAD - 1))
                    texto += numeros[i] + ", ";
                else
                    texto += numeros[i] + ".";
            }
            MessageBox.Show(texto);
        }

        private void contarNegativos()
        {
            int contador = 0;
            for (int i = 0; i < CANTIDAD; i++)
            {
                if (numeros[i] < 0)
                {
                    contador++;
                }
            }
            MessageBox.Show("El array contiene " + contador + " numeros negativos.");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            while (contador < CANTIDAD) 
            {
                try
                {
                    int numero = int.Parse(Interaction.InputBox("Introduce número " + (contador + 1) + "."));
                    numeros[contador] = numero; 
                    contador++;
                }
                catch (FormatException fEx) 
                { 
                    MessageBox.Show(fEx.Message); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sustituirPositivos();
            mostrarArray();
            contarNegativos();
        }
    }
}
