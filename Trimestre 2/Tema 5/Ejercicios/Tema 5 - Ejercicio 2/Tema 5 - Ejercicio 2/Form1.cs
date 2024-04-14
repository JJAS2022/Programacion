using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tema_5___Ejercicio_2
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
            int suma = 0; 
            double media;
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
            for (int i = 0; i < CANTIDAD; i++)
            {
                suma += numeros[i];
            }
            media = (double)suma / CANTIDAD;
            MessageBox.Show("La media es " + media + ".");
        }
    }
}
