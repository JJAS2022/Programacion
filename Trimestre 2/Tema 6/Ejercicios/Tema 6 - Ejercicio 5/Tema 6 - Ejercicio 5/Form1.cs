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

namespace Tema_6___Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> lista1 = new List<int>();
        List<int> lista2 = new List<int>();
        List<int> lista3 = new List<int>();

        // --------------------------------- FUNCIONES -----------------------------------

        void RellenarLista(List<int> lista)
        {
            lista.Clear();
            DialogResult respuesta;
            try
            {
                do
                {
                    int numero = int.Parse(Interaction.InputBox("Introduce el valor."));
                    lista.Add(numero);
                    respuesta = MessageBox.Show("¿Desea introducir otro valor?", "Continuar", MessageBoxButtons.YesNo);
                } while (respuesta == DialogResult.Yes);
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
            foreach(int numero in lista)
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

        void RellenarListaPorCopia(List<int> lista)
        {
            foreach (int numero in lista)
                lista3.Add(numero);
        }

        void IntercalarPorCopia()
        {
            lista3.Clear();
            RellenarListaPorCopia(lista1);
            RellenarListaPorCopia(lista2);
            lista3.Sort();
        }

        void RellenarListaPorMovimiento(List<int> lista)
        {
            while (lista.Count != 0)
            {
                lista3.Add(lista[0]);
                lista.RemoveAt(0);
            }
        }

        void IntercalarPorMovimiento()
        {
            lista3.Clear();
            RellenarListaPorMovimiento(lista1);
            RellenarListaPorMovimiento(lista2);
            lista3.Sort();
        }

        // ------------------------------BOTONES -----------------------------------------

        private void btnRellenar1_Click(object sender, EventArgs e)
        {
            RellenarLista(lista1);
            MostrarLista(lista1);
        }

        private void btnRellenar2_Click(object sender, EventArgs e)
        {
            RellenarLista(lista2);
            MostrarLista(lista2);
        }

        private void btnMostrar1_Click(object sender, EventArgs e)
        {
            MostrarLista(lista1);
        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            MostrarLista(lista2);
        }

        private void btnMostrar3_Click(object sender, EventArgs e)
        {
            MostrarLista(lista3);
        }

        private void btnIntercalarCopia_Click(object sender, EventArgs e)
        {
            IntercalarPorCopia();
            MostrarLista(lista3);
        }

        private void btnIntercalarMover_Click(object sender, EventArgs e)
        {
            IntercalarPorMovimiento();
            MostrarLista(lista3);
        }
    }
}
