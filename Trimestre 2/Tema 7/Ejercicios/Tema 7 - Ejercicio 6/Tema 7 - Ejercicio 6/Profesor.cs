using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7___Ejercicio_6
{
    internal class Profesor
    {
        // Miembros
        private string nombre;
        private string dni;
        private string telefono;
        private string codigoCurso;
        private bool tutor;
        private List<string> asignaturas;
        
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
            set { telefono= value; }
        }

        public string CodigoCurso
        { 
            get { return codigoCurso;} 
            set { codigoCurso = value; } 
        } 

        public bool Tutor
        {
            get { return tutor; }
            set { tutor = value; }
        }

        // Constructor
        public Profesor()
        {
            nombre = "";
            dni = "";
            telefono = "";
            codigoCurso = "";
            tutor = false;
            asignaturas = new List<string>();            
        }

        // Métodos
        // Método que permite añadir asignaturas a la lista propia del profesor
        public void AnyadirAsignatura(string asignatura)
        {
            asignaturas.Add(asignatura);
        }

        // Método que permite eliminar las asignaturas de la lista propia del profesor
        public void EliminarAsignaturas()
        {
            asignaturas.Clear();
        }

        // Método que comprueba si la asignatura recibida por parámetro está entre las que imparte el profesor
        public bool ImparteAsignatura(string materia)
        {
            bool imparte = false;

            foreach (string asignatura in asignaturas)
            {
                if (materia == asignatura)
                    imparte = true;
            }

            return imparte;
        }

        // Método que devuelve los miembros de la clase en un string 
        public string MostrarProfesor()
        {
            string texto = "";

            texto += "Nombre: " + nombre + ".\n";
            texto += "DNI: " + dni + ".\n";
            texto += "Teléfono: " + telefono + ".\n";
            if (tutor)
                texto += "Código del curso del que es tutor: " + codigoCurso + ".\n";
            else
                texto += "No tutoriza ningún curso.\n";
            texto += MostrarAsignaturas();

            return texto;
        }

        // Método que devuelve la lista propia de asignaturas en un string
        private string MostrarAsignaturas()
        {
            string texto = "Asignaturas que imparte:\n";

            foreach (string asignatura in asignaturas)
            {
                texto += asignatura + ".\n";
            }

            if (asignaturas.Count == 0)
                texto += "No imparte ninguna asignatura.\n";

            return texto;
        }
    }
}
