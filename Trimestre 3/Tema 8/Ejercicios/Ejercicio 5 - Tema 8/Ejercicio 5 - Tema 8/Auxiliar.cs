using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_5___Tema_8
{
    public static class Auxiliar
    {
        public static string IntroducirValor(string tipo, string gestion)
        {
            string valor = "";
            do
            {
                try
                {
                    valor = Interaction.InputBox("Introduzca el " + tipo + " del " + gestion + ".", "Introducir " + tipo);
                }
                catch (FormatException fEx)
                {
                    MessageBox.Show(fEx.Message);
                }
            } while (valor == "");
            return valor;
        }

        public static double IntroducirNota()
        {
            double valor = -1;
            do
            {
                try
                {
                    valor = double.Parse(Interaction.InputBox("Introduzca la nota del alumno.", "Introducir nota"));
                    if (valor < 0 || valor > 10)
                    {
                        MessageBox.Show("La nota debe estar entre 0 y 10 puntos.");
                        valor = -1;
                    }
                }
                catch (FormatException fEx)
                {
                    MessageBox.Show(fEx.Message);
                }
            } while (valor == -1);
            return valor;
        }

        public static void MensajeExito()
        {
            MessageBox.Show("La operación se ha completado satisfactoriamente");
        }

        public static void MensajeListaVacia(string lista)
        {
            MessageBox.Show("La lista de " + lista + " está vacía.");
        }

        public static void MensajeValorNoExiste(string tipo)
        {
            MessageBox.Show("El " + tipo + " introducido no existe.");
        }

        public static void MensajeValorRepetido(string valor)
        {
            MessageBox.Show("El " + valor + " introducido ya existe y no se puede repetir.");
        }
    }
}
