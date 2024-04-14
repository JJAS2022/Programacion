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

namespace Tema_5___Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int CANTIDAD = 5;
        int[] vector1 = new int[CANTIDAD];
        int[] vector2 = new int[CANTIDAD];
        int[] vector3 = new int[CANTIDAD];

        private void rellenarVector1()
        {
            int contador = 0;
            while (contador < CANTIDAD)
            {
                try
                {
                    int numero = int.Parse(Interaction.InputBox("Introduce número " + (contador +1) + " del vector 1."));
                    vector1[contador] = numero; 
                    contador++;
                }
                catch (FormatException fEx)
                {
                    MessageBox.Show(fEx.Message);
                }
            }
        }

        private void rellenarVector2()
        {
            int contador = 0;
            while (contador < CANTIDAD)
            {
                try
                {
                    int numero = int.Parse(Interaction.InputBox("Introduce número " + (contador + 1) + " del vector 2."));
                    vector2[contador] = numero;
                    contador++;
                }
                catch (FormatException fEx)
                {
                    MessageBox.Show(fEx.Message);
                }
            }
        }

        private void sumarValores()
        {
            for (int i = 0; i < CANTIDAD; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }
        }

        private void mostrarVectorFinal()
        {
            string texto = "La suma de posiciones de ambos vectores es ";
            for (int i = 0; i < CANTIDAD; i++)
            {
                if (i < (CANTIDAD - 1))
                    texto += vector3[i] + ", ";
                else
                    texto += vector3[i] + ".";
            }
            MessageBox.Show(texto);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            rellenarVector1();
            rellenarVector2();
            sumarValores();
            mostrarVectorFinal();
        }
    }
}
