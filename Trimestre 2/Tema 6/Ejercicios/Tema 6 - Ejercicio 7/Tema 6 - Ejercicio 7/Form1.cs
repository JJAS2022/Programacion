using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tema_6___Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> listado = new List<string>();

        string NuevaPalabra()
        {
            string palabra = Interaction.InputBox("Introduzca la palabra a añadir.");
            palabra = palabra.ToLower();
            return palabra;
        }

        bool ComprobarPalabra(string palabra)
        {
            bool valida = false;

            if (Regex.IsMatch(palabra, "^[a-zA-Z]+$"))
            {
                valida = true;
            }
            
            return valida;
        }

        int BuscarPosición (string palabra)
        {
            int posicion = 0; 
            bool encontrado = false;
            
            foreach (string elemento in listado)
            {
                if (string.Compare(palabra, elemento) < 0 && !encontrado)
                {                  
                    posicion = listado.IndexOf(elemento);
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                return listado.Count;
            }
            else
            {
                return posicion;
            }
        }

        void AñadirPalabra(string palabra)
        {
            if (!listado.Contains(palabra))
            {
                if (listado.Count != 0)
                {
                    listado.Insert(BuscarPosición(palabra), palabra);
                }
                else
                {
                    listado.Add(palabra);
                }
            }
            else
            {
                MessageBox.Show("La palabra " + palabra + " ya ha sido añadida.");
            }
        }

        void MostrarListado()
        {
            if (listado.Count > 0)
            {
                string texto = "El listado contiene las siguientes palabras:\n";
                foreach (string palabra in listado)
                {
                    texto += palabra + "\n";
                }
                MessageBox.Show(texto);
            }
            else
                MessageBox.Show("El listado no contiene ninguna palabra.");
        }

        private void btnIntroducir_Click(object sender, EventArgs e)
        {
            string palabra = NuevaPalabra();

            if (ComprobarPalabra(palabra))
            {
                AñadirPalabra(palabra);
                MostrarListado();
            }
            else
            {
                MessageBox.Show("La palabra introducida no es válida.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarListado();
        }
    }
}
