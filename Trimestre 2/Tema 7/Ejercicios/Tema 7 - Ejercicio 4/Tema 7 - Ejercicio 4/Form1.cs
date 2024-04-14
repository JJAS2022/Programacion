using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_7___Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Instanciar un objeto de la clase Lista
        Lista empresa = new Lista();

        // ----------------------------------------------- FUNCIONES ------------------------------------------------------
        void DatosEmpleado()
        {
            string nombre = Interaction.InputBox("Nombre del empleado.");
            string apellido = Interaction.InputBox("Apellido del empleado.");
            int edad = int.Parse(Interaction.InputBox("Edad del empleado."));
            string telefono = Interaction.InputBox("Teléfono del empleado.");
            
            string sexo;
            do
            {
                sexo = Interaction.InputBox("Sexo del empleado (M/F).", "Sexo");
            } while (sexo != "M" && sexo != "F");

            bool casado = false;
            DialogResult estado = MessageBox.Show("¿Está casado?", "Estado civil", MessageBoxButtons.YesNo);
            if (estado == DialogResult.Yes)
                casado = true;

            empresa.AnyadirEmpleado(nombre, apellido, edad, telefono, sexo, casado);
        }

        string IntroducirNombre()
        {
            string nombre = Interaction.InputBox("Introducir el nombre del empleado.");
            return nombre;
        }

        double IntroducirVenta()
        {
            double venta = double.Parse(Interaction.InputBox("Introducir el importe de la venta."));               
            return venta;
        }

        // ------------------------------------------------ BOTONES -------------------------------------------------------
        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            DatosEmpleado();
            MessageBox.Show("El empleado se ha añadido satisfactoriamente.");
        }

        private void btnCumpleanyos_Click(object sender, EventArgs e)
        {
            int numeroEmpleados = empresa.ComprobarTamaño();
            
            if (numeroEmpleados > 0)
            {
                string nombre = IntroducirNombre();
                int posicion = empresa.BuscarEmpleado(nombre);

                if (posicion >= 0)
                {
                    empresa.AnyadirCumpleaños(posicion);
                    MessageBox.Show("Se ha añadido el cumpleaños satisfactoriamente.");
                }
                else
                {
                    MessageBox.Show("No se ha encontrado ningún empleado con ese nombre.");
                } 
            }
            else
            {
                MessageBox.Show("No hay ningún empleado al que añadir cumpleaños.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            empresa.MostrarLista();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            int numeroEmpleados = empresa.ComprobarTamaño();

            if (numeroEmpleados > 0)
            {
                string nombre = IntroducirNombre();
                int posicion = empresa.BuscarEmpleado(nombre);

                if (posicion >= 0)
                {
                    try
                    {
                        double venta = IntroducirVenta();
                        empresa.AnyadirVenta(posicion, venta);
                        MessageBox.Show("Se ha añadido la venta satisfactoriamente.");
                    }
                    catch (FormatException fEx)
                    {
                        MessageBox.Show(fEx.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha encontrado ningún empleado con ese nombre.");
                }
            }
            else
            {
                MessageBox.Show("No hay ningún empleado al que añadir ventas.");
            }
        }
    }
}
