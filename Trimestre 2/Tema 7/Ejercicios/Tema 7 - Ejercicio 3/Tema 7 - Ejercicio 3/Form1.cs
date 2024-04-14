using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_7___Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Fecha> lista = new List<Fecha>();

        // -------------------------------- FUNCIONES --------------------------------------

        bool anyoValido(int anyo)
        {
            bool valido = false;

            if (anyo > 0)
                valido = true;

            return valido;
        }

        bool bisiesto(int anyo)
        {
            bool bisiesto = false;

            if (anyo % 4 == 0)
            {
                if (anyo % 100 == 0 && anyo % 400 != 0)
                {
                    bisiesto = false;
                }
                else
                {
                    bisiesto = true;
                }
            }

            return bisiesto;
        }

        bool mesValido(int mes)
        {
            bool valido = false;

            if (mes > 0 && mes < 13)
                valido = true;

            return valido;
        }

        bool diaValido(int dia, int mes, int anyo)
        {
            bool valido = false;

            if (dia > 0 && dia <= 31)
            {
                if (dia == 29 && mes == 2 && !bisiesto(anyo))
                {
                    valido = false;
                }
                else if (dia == 30 && mes == 2)
                {
                    valido = false;
                }
                else if (dia == 31 && (mes == 2 || mes == 4 || mes == 6 || mes == 9 || mes == 11))
                {
                    valido = false;
                }
                else
                {
                    valido = true;
                }
            }

            return valido;
        }

        bool fechaRepetida(int dia, int mes, int anyo)
        {
            bool repetida = false;

            foreach (Fecha fecha in lista)
            {
                if (fecha.Dia == dia && fecha.Mes == mes && fecha.Anyo == anyo)
                    repetida = true;
            }

            return repetida;
        }

        void AñadirFecha()
        {
            Fecha fecha = new Fecha();

            try
            {
                int dia = int.Parse(txtDia.Text);
                int mes = int.Parse(txtMes.Text);
                int anyo = int.Parse(txtAnyo.Text);

                if (diaValido(dia, mes, anyo) && mesValido(mes) && anyoValido(anyo))
                {
                    if (!fechaRepetida(dia, mes, anyo))
                    {
                        fecha.Dia = dia;
                        fecha.Mes = mes;
                        fecha.Anyo = anyo;

                        lista.Add(fecha);
                        MessageBox.Show("La fecha se ha añadido correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("La fecha ya se ha introducido.");
                    }
                }
                else
                {
                    MessageBox.Show("La fecha introducida no es correcta");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        void MostrarLista()
        {
            if (lista.Count > 0)
            {
                string texto = "Las fechas introducidas son las siguientes:\n\n";

                foreach (Fecha fecha in lista)
                {
                    texto += fecha.MostrarFecha();
                }

                MessageBox.Show(texto);
            }
            else
            {
                MessageBox.Show("Añada fechas para operar con ellas.");
            }
        }

        void OrdenarLista()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = (i + 1); j < lista.Count; j++)
                {
                    if (lista[j].Anyo < lista[i].Anyo)
                    {
                        Fecha tmp = lista[i];
                        lista[i] = lista[j];
                        lista[j] = tmp;
                    }
                    else if (lista[j].Anyo == lista[i].Anyo && lista[j].Mes < lista[i].Mes)
                    {
                        Fecha tmp = lista[i];
                        lista[i] = lista[j];
                        lista[j] = tmp;
                    }
                    else if (lista[j].Anyo == lista[i].Anyo && lista[j].Mes == lista[i].Mes && lista[j].Dia < lista[i].Dia)
                    {
                        Fecha tmp = lista[i];
                        lista[i] = lista[j];
                        lista[j] = tmp;
                    }
                }
            }
        }

        // -------------------------------- BOTONES --------------------------------------

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            AñadirFecha();    
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            OrdenarLista();
            MostrarLista();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }
    }
}
