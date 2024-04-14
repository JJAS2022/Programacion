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

namespace Tema_5___Ejercicio_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int ELEMENTOS = 10;
        int[] vector = new int[ELEMENTOS];

        void rellenarVector()
        {            
            int contador = 0;

            while (contador < ELEMENTOS)
            {
                try
                {
                    int numero = int.Parse(Interaction.InputBox("Introduce el elemento " + (contador + 1) + " del vector."));
                    bool repetido = false;

                    for (int i = 0; i < contador; i++)
                    {
                        if (vector[i] == numero)
                            repetido = true;
                    }

                    if (!repetido)
                    {
                        vector[contador] = numero;
                        contador++;
                    }
                    else
                    {
                        MessageBox.Show("El número " + numero + " ya ha sido introducido.");
                    }
                }
                catch (FormatException fEx)
                {
                    MessageBox.Show(fEx.Message);
                }
            }
        }
        private void btnRellenar_Click(object sender, EventArgs e)
        {
            rellenarVector();
        }
    }
}
