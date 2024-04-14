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

namespace Tema_5___Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int CANTIDAD = 10;
        int[] vector1 = new int[CANTIDAD];
        int[] vector2 = new int[CANTIDAD];

        private void mostrarVector(int[] vector)
        {
            string texto = "";

            for (int i = 0; i < CANTIDAD; i++)
            {
                if (i < (CANTIDAD - 1))
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

        private void sustituirRepetidos()
        {
            int contador = 0;

            for (int i = 0; i < CANTIDAD; i++)
            {
                bool repetido = false;    
                if (i > 0)
                {
                    for (int j = (i - 1); j >= 0; j--)
                    {
                        if (vector1[i] == vector1[j])
                        {                            
                            repetido = true;                           
                        }                                         
                    }

                    if (repetido)
                    {
                        vector2[i] = -1;
                        contador++;
                    }
                    else
                    {
                        vector2[i] = vector1[i];
                    }
                }
                else
                {
                    vector2[i] = vector1[i];
                }
            }

            MessageBox.Show("Se han producido " + contador + " cambios.");
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {        
            int contador = 0;

            try
            {
                while (contador < CANTIDAD)
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

        private void btnAccion_Click(object sender, EventArgs e)
        {
            sustituirRepetidos();
        }

        private void btnMostrarVector1_Click(object sender, EventArgs e)
        {
            mostrarVector(vector1);
        }

        private void btnMostrarVector2_Click(object sender, EventArgs e)
        {
            mostrarVector(vector2);
        }
    }
}
