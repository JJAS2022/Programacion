using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___Tema_9
{
    public class Curso
    {
        // Miembros
        private string nombre;
        private string codigo;

        // Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        // Constructor
        public Curso(string nombre, string codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }
    }
}
