using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_9___Ejercicio_2
{
    internal class Profesor
    {
        //Miembros
        private string dni;
        private string nombre;
        private string apellido;
        private string telefono;
        private string email;

        //Propiedades
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

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

        public string Telefono
        { 
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Constructor
        public Profesor(string dni, string nombre, string apellido, string telefono, string email)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.email = email;
        }
    }
}
