using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ---------------------------------------------- CALCULAR FALLOS -------------------------------------
        double CalcularFallos(int preguntas, int noContestadas, double nota)
        {
            double fallos = 0;

            double valorAcierto = (double) 10 / preguntas;
            double valorFallo = valorAcierto / 3;
            double valorPerdida = valorAcierto + valorFallo;

            double notaSinFallos = 10 - (noContestadas * valorAcierto) - nota;

            fallos = notaSinFallos / valorPerdida;

            double devuelve = Math.Round(fallos);

            return devuelve;
        }

        private void btnCalcularAciertosFallos_Click(object sender, EventArgs e)
        {
            try
            {
                int preguntas = int.Parse(txtPreguntas.Text);
                int noContestadas = int.Parse(txtNoContestadas.Text);
                double notaSobreDiez = double.Parse(txtNotaDiez.Text);

                double fallos = CalcularFallos(preguntas, noContestadas, notaSobreDiez);
                int aciertos = preguntas - noContestadas - (int)fallos;
                double notaPreguntas = CalcularNotaPreguntas(preguntas, (int)fallos, noContestadas);

                txtAciertos.Text = aciertos.ToString();
                txtFallos.Text = fallos.ToString();
                txtNotaPreguntas.Text = notaPreguntas.ToString("0.##");
            }
            catch (FormatException)
            {
                MessageBox.Show("Introducir cantidad de preguntas, número de no contestadas y nota sobre 10.");
            }           
        }

        // --------------------------------------------- CALCULAR NOTAS ----------------------------------------------------
        double CalcularNotaPreguntas(int preguntas, int fallos, int noContestadas)
        {
            double valorAcierto = preguntas / preguntas;
            double valorFallo = valorAcierto / 3;

            double nota = (preguntas * valorAcierto) - ((noContestadas + fallos) * valorAcierto) - (fallos * valorFallo);

            return nota;
        }

        double CalcularNotaDiez(int preguntas, int fallos, int noContestadas)
        {
            double valorAcierto = (double)10 / preguntas;
            double valorFallo = valorAcierto / 3;

            double nota = 10 - ((noContestadas + fallos) * valorAcierto) - (fallos * valorFallo);

            return nota;
        }

        private void CalcularNotas_Click(object sender, EventArgs e)
        {
            try
            {
                int preguntas = int.Parse(txtPreguntas.Text);
                int fallos = int.Parse(txtFallos.Text);
                int noContestadas = int.Parse(txtNoContestadas.Text);

                int aciertos = preguntas - noContestadas - fallos;
                txtAciertos.Text = aciertos.ToString();

                double notaPreguntas = CalcularNotaPreguntas(preguntas, fallos, noContestadas);
                double notaDiez = CalcularNotaDiez(preguntas, fallos, noContestadas);

                txtNotaPreguntas.Text = notaPreguntas.ToString("0.##");
                txtNotaDiez.Text = notaDiez.ToString("0.##");
            }
            catch(FormatException)
            {
                MessageBox.Show("Introducir cantidad de preguntas, número de no contestadas y fallos");
            }            
        }
    }
}
