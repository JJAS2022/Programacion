using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5___Tema_8
{
    internal class Curso
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
        public Curso()
        {
            nombre = "";
            codigo = "";
        }

        // Métodos
        public string MostrarCurso()
        {
            string texto = "";

            texto += "Nombre: " + nombre + ".\n";
            texto += "Código: " + codigo + ".\n";

            return texto;
        }
    }
}
