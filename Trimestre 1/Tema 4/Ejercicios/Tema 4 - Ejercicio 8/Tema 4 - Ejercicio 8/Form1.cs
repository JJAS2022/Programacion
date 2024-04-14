using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                double grade1 = double.Parse(txtNum1.Text);
                double grade2 = double.Parse(txtNum2.Text);
                double grade3 = double.Parse(txtNum3.Text);

                double media;

                if (check_grades(grade1, grade2, grade3))
                {
                    calculate_media(grade1, grade2, grade3, out media);
                    MessageBox.Show("La media es " + media.ToString("0.##"));
                }
                else
                {
                    MessageBox.Show("Las notas deben estar entre 0 y 10 puntos");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private bool check_grades(double n1, double n2, double n3)
        {
            bool valid_grades = false;

            if ((n1 >=0 && n1 <= 10) && (n2 >=0 && n2 <= 10) && (n3 >=0 && n3 <= 10))
            {
                valid_grades = true;
            }

            return valid_grades;
        }

        private void calculate_media(double n1, double n2, double n3, out double media)
        {
            media = (n1 + n2 + n3) / 3;
        }
    }
}
