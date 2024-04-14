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

namespace Tema_5___Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            const int CANTIDAD = 10;
            int[] numeros = new int[CANTIDAD];
            int contador = 0;
            string texto = "";
            while (contador < CANTIDAD)
            {
                try
                {
                    int numero = int.Parse(Interaction.InputBox("Introduzca número " + (contador + 1) + "."));
                    numeros[contador] = numero;
                    contador++;
                }
                catch (FormatException fEx)
                {
                    MessageBox.Show(fEx.Message);
                }
            }
            for (int i = 0; i < CANTIDAD; i++)
            {
                if (i < (CANTIDAD-1))
                {
                    texto += numeros[i] + ", ";
                }
                else
                {
                    texto += numeros[i] + ".";
                }
            }
            MessageBox.Show(texto);
        }
    }
}
