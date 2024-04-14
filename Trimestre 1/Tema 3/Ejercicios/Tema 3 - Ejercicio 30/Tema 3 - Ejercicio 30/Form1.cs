using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tema_3___Ejercicio_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int counter = 0;

            while (counter < 5)
            {
                try
                {
                    string user = Interaction.InputBox("Introduzca el usuario.", "Ejercicio 30");
                    int password = int.Parse(Interaction.InputBox("Introduzca la contraseña.", "Ejercicio 30"));

                    counter++;

                    bool validUser = false;
                    bool validPassword = false;

                    if (user == "root")
                    {
                        validUser = true;
                    }

                    if (password == 1234)
                    {
                        validPassword = true;
                    }

                    if (validUser && validPassword)
                    {
                        MessageBox.Show("Bienvenido al sistema.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecto.");
                    }
                }
                catch (FormatException fEx)
                {
                    MessageBox.Show(fEx.Message);
                }
            }

            MessageBox.Show("Se ha superado el número de intentos permitidos.");
        }
    }
}
