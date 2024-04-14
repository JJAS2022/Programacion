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

namespace Tema_5___Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int CANTIDAD = 10;
            int[] vector = new int[CANTIDAD];
            int contador = 0;
            string texto = "Los valores introducidos son ";

            while (contador < CANTIDAD)
            {
                try
                {
                    int numero = 0;
                    if (contador == 0)
                    {
                        numero = int.Parse(Interaction.InputBox("Introduce elemento " + (contador + 1) + "."));
                        vector[contador] = numero;
                        contador++;
                    }
                    else
                    {
                        numero = int.Parse(Interaction.InputBox("Introduce elemento " + (contador + 1) + "."));
                        if (numero <= vector[(contador - 1)])
                        {
                            MessageBox.Show("El número debe ser superior a " + vector[(contador - 1)] + ".");
                        }
                        else
                        {
                            vector[contador] = numero;
                            contador++;
                        }
                    }
                }
                catch (FormatException fEx)
                {
                    MessageBox.Show(fEx.Message);
                }
            }

            for (int i = 0; i < CANTIDAD; i++)
            {
                if (i < (CANTIDAD - 1))
                    texto += vector[i] + ", ";
                else
                    texto += vector[i] + ".";
            }

            MessageBox.Show(texto);
        }
    }
}
