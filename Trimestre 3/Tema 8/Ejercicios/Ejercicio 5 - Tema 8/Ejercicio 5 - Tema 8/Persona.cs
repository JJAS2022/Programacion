using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5___Tema_8
{
    public abstract class Persona
    {
        // Miembros
        private string nombre;
        private string dni;
        private string telefono;

        // Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        // Constructor
        public Persona(string nombre, string dni, string telefono)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
        }

        // Métodos
        public virtual string MostrarDatos()
        {
            string texto = "";

            texto += "Nombre: " + nombre + ".\n";
            texto += "DNI: " + dni + ".\n";
            texto += "Teléfono: " + telefono + ".\n";

            return texto;
        }
    }
}
