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

namespace Tema_3___Ejercicio_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            int number = 0;
            int totalStudents = 0;
            int studentsLess50 = 0;
            int studentsLess65 = 0;
            int studentsLess80 = 0;
            int studentsMore80 = 0;
            int totalWeight = 0;

            // Limpia los datos para reutilizar el formulario
            lblTotal.Text = "0";
            lblMedia.Text = "0";
            lblNumLess50.Text = "0";
            lblNumLess65.Text = "0";
            lblNumLess80.Text = "0";
            lblNumMore80.Text = "0";
            lblPerLess50.Text = "0";
            lblPerLess65.Text = "0";
            lblPerLess80.Text = "0";
            lblPerMore80.Text = "0";

            // Pide información del peso de los alumnos mientras no se introduzca número negativo
            do
            {
                // Captura la excepción si no se intruduce nada
                try
                {
                    number = int.Parse(Interaction.InputBox("Introduzca el peso de un alumno.", "Ejercicio 23"));

                    // Actualiza la tabla si se introducen números positivos
                    if (number > 0)
                    {
                        // Actualiza el total de estudiantes y lo muestra en un label
                        totalStudents++;
                        lblTotal.Text = totalStudents.ToString();

                        // Actualiza el peso total para la media
                        totalWeight += number;

                        // Actualiza los pesos por rango
                        if (number <= 50)
                        {
                            studentsLess50++;
                            lblNumLess50.Text = studentsLess50.ToString();
                        }
                        else if (number > 50 && number <= 65)
                        {
                            studentsLess65++;
                            lblNumLess65.Text = studentsLess65.ToString();
                        }
                        else if (number > 65 && number <= 80)
                        {
                            studentsLess80++;
                            lblNumLess80.Text = studentsLess80.ToString();
                        }
                        else
                        {
                            studentsMore80++;
                            lblNumMore80.Text = studentsMore80.ToString();
                        }
                    }
                }
                catch (FormatException fEx)
                {
                    MessageBox.Show("Se ha producido el siguiente error: " + fEx.Message);
                }
            }
            while (number > 0);

            // Comprueba que se haya introducido al menos un dato válido
            if (totalStudents != 0)
            {
                // Actualiza los porcentajes por rango con los datos finales
                lblPerLess50.Text = ((double)studentsLess50 * 100 / totalStudents).ToString("0.##") + "%";
                lblPerLess65.Text = ((double)studentsLess65 * 100 / totalStudents).ToString("0.##") + "%";
                lblPerLess80.Text = ((double)studentsLess80 * 100 / totalStudents).ToString("0.##") + "%";
                lblPerMore80.Text = ((double)studentsMore80 * 100 / totalStudents).ToString("0.##") + "%";

                // Indica la media del peso de los estudiantes
                lblMedia.Text = ((double)totalWeight / totalStudents).ToString("0.##") + " kg";
            }
            else
            {
                MessageBox.Show("Debe introducir al menos un dato.");
            }
        }
    }
}
