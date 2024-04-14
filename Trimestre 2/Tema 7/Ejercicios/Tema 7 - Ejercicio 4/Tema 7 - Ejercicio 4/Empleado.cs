using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7___Ejercicio_4
{
    internal class Empleado
    {
        // Miembros
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
            set {
                if (value > 0 && value < 100)
                { 
                    edad = value;
                }
            }
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
        }

        // Métodos
        private string MostrarVentas()
        {
            string texto = ""; 
            
            if (ventas.Count > 0)
            {
                foreach (double venta in ventas)
                {
                    texto += venta.ToString("0.##") + " euros.\n"; 
                }
            }
            else
            {
                texto = "No hay ventas.\n";
            }

            return texto;
        }
        
        public string MostrarDatos()
        {
            string texto = "";
            texto += "Nombre: " + nombre + ".\n";
            texto += "Apellido: " + apellido + ".\n";
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
            texto += "Ventas:\n";
            texto += MostrarVentas() + "\n";
            return texto;
        }

        public void Cumpleanyos()
        {
            edad += 1;
        }

        public void Venta(double importe)
        {
            ventas.Add(importe);
        }
    }
}
