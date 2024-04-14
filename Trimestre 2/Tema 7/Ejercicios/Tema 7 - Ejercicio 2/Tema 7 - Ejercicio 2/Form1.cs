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

namespace Tema_7___Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Persona> lista = new List<Persona>();

        private void btnIntroducir_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.Nombre = Interaction.InputBox("Introduzca el nombre de la persona.", "Nombre");
            persona.Edad = int.Parse(Interaction.InputBox("Introduzca la edad de la persona.", "Edad"));
            persona.Telefono = Interaction.InputBox("Introduzca el número de teléfono de la persona.", "Teléfono");

            string sexo;
            do
            {
                sexo = Interaction.InputBox("Introduzca el sexo de la persona (M / F)", "Sexo");
            } while (sexo != "M" && sexo != "F");

            if (sexo == "M")
            {
                persona.Sexo = 'M';
            }
            else
            {
                persona.Sexo = 'F';
            }

            DialogResult casado;
            casado = MessageBox.Show("¿La persona está casada?", "Estado civil", MessageBoxButtons.YesNo);
            if (casado == DialogResult.Yes)
            {
                persona.Casado = true;
            }
            else
            {
                persona.Casado = false;
            }

            lista.Add(persona);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string texto = "Datos de las personas:\n\n";
            int contador = 1;

            foreach (Persona persona in lista)
            {
                texto += "Persona " + contador + ":\n";
                texto += persona.MostrarDatos();
                texto += "\n";

                contador++;
            }

            MessageBox.Show(texto);
        }
    }
}
