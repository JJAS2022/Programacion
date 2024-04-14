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

namespace Tema_6___Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> lista1 = new List<int>();
        List<int> lista2 = new List<int>();

        void RellenarLista()
        {
            DialogResult respuesta;
            do
            {
                int valor = int.Parse(Interaction.InputBox("Introduzca el valor a añadir."));
                lista1.Add(valor);
                respuesta = MessageBox.Show("¿Desea añadir más elementos?", "¿Continuar?", MessageBoxButtons.YesNo);
            } while (respuesta == DialogResult.Yes);
        }

        string ListaTexto(List<int> lista)
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
                    texto += numero + ".";
            }
            return texto;
        }

        void MostrarListas()
        {
            string texto = "Los valores de las listas son: \n";

            texto += "Primera lista: " + ListaTexto(lista1) + "\n";
            texto += "Segunda lista: " + ListaTexto(lista2) + "\n";

            MessageBox.Show(texto);
        }

        void CopiarPares()
        {
            lista2.Clear();
            foreach (int numero in lista1)
            {
                if (numero % 2 == 0)
                    lista2.Add(numero);
            }
        }

        void MoverPares()
        {
            lista2.Clear();
            int contador = 0;
            while (contador < lista1.Count)
            {
                if (lista1[contador] % 2 == 0)
                {
                    lista2.Add(lista1[contador]);
                    lista1.RemoveAt(contador);
                }
                else
                {
                    contador++;
                }
            }
        }

        private void btn_Rellenar_Click(object sender, EventArgs e)
        {
            RellenarLista();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            MostrarListas();
        }

        private void btn_Copiar_Click(object sender, EventArgs e)
        {
            CopiarPares();
            MostrarListas();
        }

        private void btn_Mover_Click(object sender, EventArgs e)
        {
            MoverPares();
            MostrarListas();
        }
    }
}
