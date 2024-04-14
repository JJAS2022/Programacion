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

namespace Tema_6___Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> lista = new List<int>();

        void MostrarLista()
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

        int IntroducirValor()
        {            
            int valor = int.Parse(Interaction.InputBox("Introduzca el valor."));                        
            return valor;
        }

        int IntroducirPosicion()
        {
            int posicion = int.Parse(Interaction.InputBox("Introduzca la posición."));
            return posicion;
        }

        void AñadirNumero(int numero)
        {
            lista.Add(numero);
        }

        void InsertarNumero(int posicion, int numero)
        {
            lista.Insert(posicion, numero);
        }

        void EliminarNumero(int numero)
        {
            lista.Remove(numero);
        }

        void EliminarTodo()
        {
            lista.Clear();
        }

        void EliminarPosicion(int posicion)
        {
            lista.RemoveAt(posicion);
        }

        int BuscarPosicion(int valor)
        {
            if (lista.Contains(valor))
            {
                return lista.IndexOf(valor);
            }
            else
            {
                return -1;
            }
        }

        void OrdenarLista()
        {
            lista.Sort();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = IntroducirValor();
                AñadirNumero(valor);
                MostrarLista();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }            
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = IntroducirValor();
                int posicion = IntroducirPosicion();
                if (posicion <= lista.Count)
                {
                    InsertarNumero(posicion, valor);
                    MostrarLista();
                }
                else
                {
                    MessageBox.Show("Debe introducir un valor entre 0 y " + lista.Count + ".");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = IntroducirValor();
                if (lista.Contains(valor))
                {
                    EliminarNumero(valor);
                    MostrarLista();
                }
                else
                {
                    MessageBox.Show("El valor introducido no está en la lista.");
                }               
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private void btn_RemoveAt_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion = IntroducirPosicion();
                if (posicion <= lista.Count)
                {
                    EliminarPosicion(posicion);
                    MostrarLista();
                }
                else
                {
                    MessageBox.Show("Debe introducir un valor entre 0 y " + lista.Count + ".");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            EliminarTodo();
            MostrarLista();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = IntroducirValor();
                int posicion = BuscarPosicion(valor);
                if (posicion == -1)
                {
                    MessageBox.Show("El número introducido no se encuentra en la lista.");
                }
                else
                {
                    MessageBox.Show("El número introducido se encuentra por primera vez en la posición " + posicion + ".");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrdenarLista();
            MostrarLista();
        }
    }
}
