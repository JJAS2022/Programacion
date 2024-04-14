using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5___Tema_8
{
    internal class Profesor : Persona
    {
        // Miembros
        private string email;
        private string codigoCurso;
        private bool tutor;
        private List<string> asignaturas;

        // Propiedades      
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string CodigoCurso
        {
            get { return codigoCurso; }
            set { codigoCurso = value; }
        }

        public bool Tutor
        {
            get { return tutor; }
            set { tutor = value; }
        }

        // Constructor
        public Profesor(string nombre, string dni, string telefono, string email, string codigoCurso, bool tutor) : base (nombre, dni, telefono)
        {
            this.email = email;
            this.codigoCurso = codigoCurso;
            this.tutor = tutor;
            asignaturas = new List<string>();
        }

        // Métodos
        public void AnyadirAsignatura(string asignatura)
        {
            asignaturas.Add(asignatura);
        }

        public void EliminarAsignaturas()
        {
            asignaturas.Clear();
        }

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

        public override string MostrarDatos()
        {
            string texto = "";

            texto += base.MostrarDatos();
            texto += "Correo electrónico: " + email + ".\n";
            if (tutor)
                texto += "Código del curso del que es tutor: " + codigoCurso + ".\n";
            else
                texto += "No tutoriza ningún curso.\n";
            texto += MostrarAsignaturas();

            return texto;
        }

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
