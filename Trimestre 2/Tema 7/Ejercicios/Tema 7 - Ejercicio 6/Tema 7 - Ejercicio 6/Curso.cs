using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7___Ejercicio_6
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
        // Método que devuelve los miembros de la clase en un string 
        public string MostrarCurso()
        {
            string texto = "";

            texto += "Nombre: " + nombre + ".\n";
            texto += "Código: " + codigo + ".\n";

            return texto;
        }
    }
}
