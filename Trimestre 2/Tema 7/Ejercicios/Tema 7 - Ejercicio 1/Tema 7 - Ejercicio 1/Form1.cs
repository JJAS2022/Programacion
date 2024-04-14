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

namespace Tema_7___Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Instancia de la clase (solamente 1 persona)
        Persona persona = new Persona();

        private void btnIntroducir_Click(object sender, EventArgs e)
        {
            string sexo;
            DialogResult casado;

            persona.Nombre = Interaction.InputBox("Introduzca el nombre.");
            persona.Edad = int.Parse(Interaction.InputBox("Introduzca la edad."));
            persona.Telefono = Interaction.InputBox("Introduzca el teléfono.");

            do
            {
                sexo = Interaction.InputBox("Introduzca M (masculino) o F (femenino).");
            } while (sexo != "M" && sexo != "F");

            if (sexo == "M")
                persona.Sexo = 'M';
            else
                persona.Sexo = 'F';

            casado = MessageBox.Show("¿Está casado?", "Casado", MessageBoxButtons.YesNo);
            if (casado == DialogResult.Yes)
                persona.Casado = true;
            else 
                persona.Casado = false;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string texto = persona.MostrarDatos();
            MessageBox.Show(texto);
        }
    }
}
