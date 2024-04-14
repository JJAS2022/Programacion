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

namespace Tema_6___Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> bases = new List<int>();
        List<int> exponentes = new List<int>();
        List<int> potencias = new List<int>();

        void RellenarLista(List<int> lista)
        {
            lista.Clear();
            int contador = 0;
            try
            {
                while (contador < 10)
                {
                    int numero = int.Parse(Interaction.InputBox("Introduzca el valor."));
                    lista.Add(numero);
                    contador++;
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        void MostrarLista(List<int> lista)
        {
            string texto = "";
            int posicion = 0;
            foreach (int numero in lista)
            {
                if (posicion < (lista.Count - 1))
                {
                    texto += numero + ", ";
                    posicion++;
                }
                else
                {
                    texto += numero + ".";
                }
            }
            MessageBox.Show(texto);
        }

        int CalcularPotencias(int numeroBase, int exponente)
        {
            if (exponente == 1)
            {
                return numeroBase;
            }
            else
            {
                return numeroBase * (CalcularPotencias(numeroBase, (exponente - 1)));
            }                     
        }

        void RellenarPotencias()
        {
            potencias.Clear();
            if (bases.Count == 10 && exponentes.Count == 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    potencias.Add(CalcularPotencias(bases[i], exponentes[i]));
                }
            }
            else
                MessageBox.Show("Debe rellenar antes las bases y exponentes.");
        }

        private void btnBases_Click(object sender, EventArgs e)
        {
            RellenarLista(bases);
        }

        private void btnMostrarBases_Click(object sender, EventArgs e)
        {
            MostrarLista(bases);
        }

        private void btnExponentes_Click(object sender, EventArgs e)
        {
            RellenarLista(exponentes);
        }

        private void btnMostrarExponentes_Click(object sender, EventArgs e)
        {
            MostrarLista(exponentes);
        }

        private void btnPotencias_Click(object sender, EventArgs e)
        {
            RellenarPotencias();
        }

        private void btnMostrarPotencias_Click(object sender, EventArgs e)
        {
            MostrarLista(potencias);
        }
    }
}
