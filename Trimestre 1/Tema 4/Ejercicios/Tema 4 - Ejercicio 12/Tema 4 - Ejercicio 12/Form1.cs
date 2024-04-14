using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_4___Ejercicio_12
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
                int day = int.Parse(txtNum1.Text);
                int month = int.Parse(txtNum2.Text);
                int year = int.Parse(txtNum3.Text);

                bool is_leap = check_year(year);
               
                if (check_month(month) && check_day(day, month, is_leap))
                {
                    MessageBox.Show("La fecha es válida.");
                }
                else
                {
                    MessageBox.Show("La fecha NO es válida.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        private bool check_year(int n1)
        {
            bool leap = false;

            if (n1 % 4 == 0)
            {
                if (n1 % 100 == 0)
                {
                    if (n1 % 400 == 0)
                    {
                        leap = true;
                    }
                }
                else
                {
                    leap = true;
                }
            }

            return leap;
        }

        private bool check_month(int month)
        {
            bool valid_month = false;

            if (month >= 1 && month <= 12)
            {
                valid_month = true;
            }

            return valid_month;
        }


        private bool check_day(int day, int month, bool leap)
        {
            bool valid_day = true;

            if (day < 1 || day > 31)
            {
                valid_day = false;
            }
            else if (day > 28 && month == 2 && !leap)
            {
                valid_day = false;
            }
            else if (day > 29 && month == 2 && leap)
            {
                valid_day = false;
            }
            else if (day > 30 && (month == 4 || month == 6 || month == 9 || month == 11))
            {
                valid_day = false;
            }

            return valid_day;
        }
    }
}
