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

namespace Tema_5___Ejercicio_11
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

            try
            {
                while (contador < ELEMENTOS)
                {
                    int numero = int.Parse(Interaction.InputBox("Introduce elemento " + (contador + 1) + "."));
                    vector[contador] = numero;
                    contador++;
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        void mostrarVector()
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

        void rotarVector()
        {
            int tmp = 0;

            for (int i = (ELEMENTOS - 1); i >= 0; i--)
            {                
                if (i == (ELEMENTOS - 1))
                {
                    tmp = vector[i];
                }
                if (i > 0 )
                {
                    vector[i] = vector[(i - 1)];
                }
                else
                {
                    vector[i] = tmp;
                }
            }
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            rellenarVector();
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            rotarVector();
            mostrarVector();
        }
    }
}
