using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7___Ejercicio_6
{
    internal class Alumno
    {
        // Miembros
        private string nombre;
        private string dni;
        private string telefono;
        private string codigoCurso;
        private List<double> notas;

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

        public string CodigoCurso
        {
            get { return codigoCurso;}
            set { codigoCurso= value; }
        }

        // Constructor
        public Alumno()
        {
            nombre = "";
            dni = "";
            telefono = "";
            codigoCurso = "";
            notas = new List<double>();
        }

        // Métodos
        // Método que permite añadir notas a la lista propia del alumno
        public void AnyadirNota(double nota)
        {
            notas.Add(nota);
        }

        // Método que permite calcular la nota media del alumno
        public double CalcularMedia()
        {
            double total = 0;
            int evaluaciones = 0;

            foreach (double nota in notas)
            {
                total += nota;
                evaluaciones++;
            }

            double media = total / evaluaciones; 

            return media;
        }

        // Método que permite eliminar las notas de la lista propia del alumno
        public void EliminarNotas()
        {
            notas.Clear();
        }

        // Método que devuelve los miembros de la clase en un string 
        public string MostrarAlumno()
        {
            string texto = "";

            texto += "Nombre: " + nombre + ".\n";
            texto += "DNI: " + dni + ".\n";
            texto += "Teléfono: " + telefono + ".\n";
            texto += "Código del curso al que pertenece: " + codigoCurso + ".\n";
            texto += MostrarNotas();

            return texto;
        }

        // Método que devuelve la lista propia de notas y la nota media en un string
        private string MostrarNotas()
        {
            string texto = "Notas:\n";

            foreach (double nota in notas)
            {
                texto += "      " + nota.ToString() + " puntos.\n";
            }

            if (notas.Count > 0)
                texto += "Media: " + CalcularMedia().ToString("0.##") + " puntos.\n";
            else
                texto += "No hay notas que mostrar.\n";

            return texto;
        }
    }
}
