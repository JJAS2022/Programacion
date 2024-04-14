using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5___Tema_8
{
    public class ListaPersonas
    {
        // Miembros
        private List<Persona> personas;
        private List<Alumno> alumnos;
        private List<Profesor> profesores;

        // Constructor
        public ListaPersonas()
        {
            personas = new List<Persona>();
            alumnos = new List<Alumno>();
            profesores = new List<Profesor>();
        }

        // Métodos 
        // --------------------------- MÉTODOS DE LA LISTA DE PERSONAS ------------------------------------
        public bool ComprobarDni(string dni)
        {
            bool unico = true;

            foreach (Persona persona in personas)
            {
                if (persona.Dni == dni)
                    unico = false;
            }

            return unico;
        }

        public void EliminarPersona(string dni)
        {
            int posicion = 0;

            for (int i = 0; i < personas.Count; i++)
            {
                if (personas[i].Dni == dni)
                    posicion = i;
            }

            personas.RemoveAt(posicion);
        }
        
        public void Limpiar()
        {
            personas.Clear();
            alumnos.Clear();
            profesores.Clear();
            Auxiliar.MensajeExito();
        }

        public void MostrarPersonas()
        {
            if (personas.Count > 0)
            {
                string texto = "Datos de todas las personas adscritas al centro:\n\n";

                foreach (Persona persona in personas)
                {
                    if (persona.GetType() == typeof(Alumno))
                        texto += "Rol: Alumno.\n";
                    else
                        texto += "Rol: Profesor.\n";

                    texto += persona.MostrarDatos() + "\n";
                }

                MessageBox.Show(texto);
            }
            else
                Auxiliar.MensajeListaVacia("personas");
        }


        // --------------------------- MÉTODOS DE LA LISTA DE ALUMNOS ----------------------------------------
        public void AnyadirAlumno(string nombre, string dni, string telefono, string codigo)
        {
            Alumno alumno = new Alumno(nombre, dni, telefono, codigo);

            alumnos.Add(alumno);
            personas.Add(alumno);
        }

        public void AnyadirNota(int posicion, double nota)
        {
            alumnos[posicion].AnyadirNota(nota);
        }

        public int BuscarPosicionAlumno(string nombre)
        {
            int posicion = -1;

            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].Nombre == nombre)
                    posicion = i;
            }

            return posicion;
        }

        public bool ComprobarAlumnos()
        {
            bool contiene = false;

            if (alumnos.Count > 0)
            {
                contiene = true;
            }

            return contiene;
        }

        public string DniAlumno(int posicion)
        {
            return alumnos[posicion].Dni;
        }

        public void EliminarAlumno(int posicion)
        {
            alumnos.RemoveAt(posicion);
        }

        public void EliminarNotas(int posicion)
        {
            alumnos[posicion].EliminarNotas();
        }

        public void MostrarAlumnos()
        {
            string texto = "Lista de alumnos:\n\n";

            foreach (Alumno alumno in alumnos)
            {
                texto += alumno.MostrarDatos() + "\n";
            }

            MessageBox.Show(texto);
        }

        public void MostrarAlumnosAprobados()
        {
            string texto = "Lista de alumnos aprobados:\n\n";
            int contador = 0;

            foreach (Alumno alumno in alumnos)
            {
                if (alumno.CalcularMedia() >= 5)
                {
                    texto += alumno.MostrarDatos() + "\n";
                    contador++;
                }
            }

            if (contador == 0)
                texto += "No hay alumnos aprobados.\n";

            MessageBox.Show(texto);
        }

        public void MostrarAlumnosPorCurso(string codigo)
        {
            string texto = "Lista de alumnos del curso con código " + codigo + ":\n\n";
            int contador = 0;

            foreach (Alumno alumno in alumnos)
            {
                if (alumno.CodigoCurso == codigo)
                {
                    texto += alumno.MostrarDatos() + "\n";
                    contador++;
                }
            }

            if (contador == 0)
                texto += "No hay alumnos adscritos a este curso.\n";

            MessageBox.Show(texto);
        }

        public void MostrarAlumnosSuspensos()
        {
            string texto = "Lista de alumnos suspensos:\n\n";
            int contador = 0;

            foreach (Alumno alumno in alumnos)
            {
                if (alumno.CalcularMedia() < 5)
                {
                    texto += alumno.MostrarDatos() + "\n";
                    contador++;
                }
            }

            if (contador == 0)
                texto += "No hay alumnos suspensos.\n";

            MessageBox.Show(texto);
        }

        public void MostrarUnAlumno(int posicion)
        {
            string texto = "Datos del alumno:\n\n";

            texto += alumnos[posicion].MostrarDatos() + "\n";

            MessageBox.Show(texto);
        }

        public void OrdenarAlumnosAlfabéticamentePorNombre()
        {
            Alumno aux;

            for (int i = 0; i < alumnos.Count - 1; i++)
            {
                for (int j = i + 1; j < alumnos.Count; j++)
                {
                    if (string.Compare(alumnos[j].Nombre, alumnos[i].Nombre) < 0)
                    {
                        aux = alumnos[i];
                        alumnos[i] = alumnos[j];
                        alumnos[j] = aux;
                    }
                }
            }
        }

        // --------------------------- MÉTODOS DE LA LISTA DE PROFESORES -------------------------------------
        public void AnyadirProfesor(string nombre, string dni, string telefono, string email, string codigo, bool tutor)
        {
            Profesor profesor = new Profesor(nombre, dni, telefono, email, codigo, tutor);

            profesores.Add(profesor);
            personas.Add(profesor);
        }

        public void AnyadirAsignatura(int posicion, string asignatura)
        {
            profesores[posicion].AnyadirAsignatura(asignatura);
        }

        public int BuscarPosicionProfesor(string nombre)
        {
            int posicion = -1;

            for (int i = 0; i < profesores.Count; i++)
            {
                if (profesores[i].Nombre == nombre)
                    posicion = i;
            }

            return posicion;
        }

        public bool ComprobarProfesores()
        {
            bool contiene = false;

            if (profesores.Count > 0)
            {
                contiene = true;
            }

            return contiene;
        }

        public string DniProfesor(int posicion)
        {
            return profesores[posicion].Dni;
        }

        public void EliminarAsignaturas(int posicion)
        {
            profesores[posicion].EliminarAsignaturas();
        }

        public void EliminarProfesor(int posicion)
        {
            profesores.RemoveAt(posicion);
        }

        public void MostrarProfesores()
        {
            string texto = "Lista de profesores:\n\n";

            foreach (Profesor profesor in profesores)
            {
                texto += profesor.MostrarDatos() + "\n";
            }

            MessageBox.Show(texto);
        }

        public void MostrarProfesoresPorAsignatura(string asignatura)
        {
            string texto = "Lista de profesores que imparten la asignatura de " + asignatura + ":\n\n";
            int contador = 0;

            foreach (Profesor profesor in profesores)
            {
                if (profesor.ImparteAsignatura(asignatura))
                {
                    texto += profesor.MostrarDatos() + "\n";
                    contador++;
                }
            }

            if (contador == 0)
                texto += "No hay profesores asignados a esta asignatura.\n";

            MessageBox.Show(texto);
        }

        public void MostrarUnProfesor(int posicion)
        {
            string texto = "Datos del profesor:\n\n";

            texto += profesores[posicion].MostrarDatos() + "\n";

            MessageBox.Show(texto);
        }

        public void OrdenarProfesoresAlfabéticamentePorNombre()
        {
            Profesor aux;

            for (int i = 0; i < profesores.Count - 1; i++)
            {
                for (int j = i + 1; j < profesores.Count; j++)
                {
                    if (string.Compare(profesores[j].Nombre, profesores[i].Nombre) < 0)
                    {
                        aux = profesores[i];
                        profesores[i] = profesores[j];
                        profesores[j] = aux;
                    }
                }
            }
        }
    }
}
