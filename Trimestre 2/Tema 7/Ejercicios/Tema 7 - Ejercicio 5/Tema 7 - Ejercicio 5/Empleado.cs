using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_7___Ejercicio_5
{
    internal class Empleado
    {
        // Miembros de la clase
        private string nombre;
        private string apellido;
        private int edad;
        private string telefono;
        private string sexo;
        private bool casado;
        private List<double> ventas = new List<double>();

        // Propiedades
        public string Nombre
        {
            get { return nombre; } 
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public bool Casado
        {
            get { return casado; }
            set { casado = value; }
        }

        // Constructor
        public Empleado()
        {
            nombre = "";
            apellido = "";
            edad = 0;
            telefono = "";
            sexo = "";
            casado = false;
        }

        // Métodos
        // Método para añadir ventas a la lista de ventas propia del empleado
        public void AnyadirVentas(double venta)
        {
            ventas.Add(venta);
        }

        // Método para limpiar todos los elementos en la lista propia de ventas del empleado
        public void EliminarVentas()
        {
            ventas.Clear();
        }

        // Método para mostrar los datos del empleado, con remisión a otro método para mostrar las ventas
        public string MostrarDatos()
        {
            string texto = "";

            texto += "Nombre: " + nombre + " " + apellido + ".\n";
            texto += "Edad: " + edad + " años.\n";
            texto += "Teléfono: " + telefono + ".\n";
            if (sexo == "M")
                texto += "Sexo: Masculino.\n";
            else
                texto += "Sexo: Femenino.\n";
            if (casado)
                texto += "Estado civil: Casado.\n";
            else
                texto += "Estado civil: Soltero.\n";
            texto += "Ventas: \n";
            texto += MostrarVentas() + "\n";

            return texto;
        }

        // Método para mostrar la lista de ventas propia del empleado con un formato específico
        public string MostrarVentas()
        {
            string texto = "";

            if (ventas.Count > 0)
            {
                foreach (double venta in ventas)
                {
                    texto += "          " + venta.ToString("0.##") + " euros.\n";
                }
                texto += "Total: " + TotalVentas().ToString("0.##") + " euros.\n";
            }
            else
            {
                texto = "No hay ventas.";
            }

            return texto;
        }

        // Método para calcular el importe total de las ventas del empleado, iterando la lista de ventas propia
        public double TotalVentas()
        {
            double suma = 0;

            foreach (double venta in ventas)
            {
                suma += venta;
            }

            return suma;
        }
    }
}
