using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tema_7___Ejercicio_6
{
    // Declara una clase estática pues no tiene miembros, solamente funciones auxiliares
    public static class Auxiliar
    {
        // Métodos       
        // Método para introducir un string que recibe por parámetro la gestión que se
        // está realizando (curso/alumno/profesor/módulo) y el tipo de valor que se pide (nombre/código)
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

        // Método para introducir un valor double que debe estar entre 0 y 10
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

        // Método que muestra un mensaje sobre una operación satisfactoria
        public static void MensajeExito()
        {
            MessageBox.Show("La operación se ha completado satisfactoriamente");
        }

        // Método que muestra un mensaje indicando que la lista está vacía
        // según la lista a la que se esté refiriendo (cursos/alumnos/profesores)
        public static void MensajeListaVacia(string lista)
        {
            MessageBox.Show("La lista de " + lista + " está vacía.");
        }

        // Método que muestra un mensaje que indica que el valor introducido no existe en la lista,
        // según se trate de un nombre o código
        public static void MensajeValorNoExiste(string tipo)
        {
            MessageBox.Show("El " + tipo + " introducido no existe.");
        }
    }
}
