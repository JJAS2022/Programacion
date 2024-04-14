using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7___Ejercicio_2
{
    internal class Persona
    {
        // Miembros de la clase
        private string nombre;
        private int edad;
        private string telefono;
        private char sexo;
        private bool casado;

        // Propiedades de la clase
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set 
            {
                if (value >= 0 && value <= 100)
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

        public char Sexo
        {
            get { return sexo; }
            set 
            {
                if (value == 'M' || value == 'F')
                {
                    sexo = value;
                }
            }
        }

        public bool Casado
        {
            get { return casado; }
            set { casado = value; }
        }

        // Constructor
        public Persona()
        {
            nombre = "";
            edad = 0;
        }

        // Métodos de la clase
        public string MostrarDatos()
        {
            string texto = "";

            texto += "Nombre: " + nombre + ".\n";
            texto += "Edad: " + edad + " años.\n";
            texto += "Teléfono: " + telefono + ".\n";
            
            if (sexo == 'M')
                texto += "Sexo: Masculino.\n";
            else
                texto += "Sexo: Femenino.\n";

            if (casado == true)
                texto += "Estado civil: Casado.\n";
            else
                texto += "Estado civil: Soltero.\n";

            return texto;
        }
    }
}
