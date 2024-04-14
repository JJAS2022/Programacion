﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tema_5___Ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int ELEMENTOS = 10;
        int[] vector1 = new int[ELEMENTOS];
        int[] vector2 = new int[ELEMENTOS];

        private void mostrarVector(int[] vector)
        {
            string texto = "";

            for (int i = 0; i < ELEMENTOS; i++)
            {
                if (i < (ELEMENTOS - 1))
                {
                    texto += vector[i] + ", ";
                }
                else
                {
                    texto += vector[i] + ".";
                }
            }

            MessageBox.Show(texto);
        }

        private void invertirVector()
        {
            for (int i = 0; i < ELEMENTOS; i++)
            {
                vector2[i] = vector1[(ELEMENTOS - 1) - i];
            }
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            int contador = 0;

            try
            {
                while (contador < ELEMENTOS)
                {
                    int numero = int.Parse(Interaction.InputBox("Introduce elemento " + (contador + 1) + "."));
                    vector1[contador] = numero;
                    contador++;
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private void btnMostrarInicial_Click(object sender, EventArgs e)
        {
            mostrarVector(vector1);
        }

        private void btnMostrarInvertido_Click(object sender, EventArgs e)
        {
            mostrarVector(vector2);
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            invertirVector();
        }
    }
}