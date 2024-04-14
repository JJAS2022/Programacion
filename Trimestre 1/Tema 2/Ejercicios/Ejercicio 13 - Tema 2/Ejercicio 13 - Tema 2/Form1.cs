using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_13___Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int normal_hours = int.Parse(txtHours.Text);
            int extra_hours = int.Parse(txtExtra.Text);
            double salary_per_normal_hour = double.Parse(txtSalary.Text);
            double salary_per_extra_hour = salary_per_normal_hour * 2;
            double total_salary = (salary_per_normal_hour * normal_hours) + (salary_per_extra_hour * extra_hours);
            double taxes = total_salary * 0.18;
            double taxed_salary = total_salary - taxes;
            lblExtraSalary.Text = salary_per_extra_hour.ToString() + " €";
            lblTotalSalary.Text = total_salary.ToString() + " €";
            lblTaxes.Text = taxes.ToString() + " €";
            lblTaxedSalary.Text = taxed_salary.ToString() + " €";
        }
    }
}
