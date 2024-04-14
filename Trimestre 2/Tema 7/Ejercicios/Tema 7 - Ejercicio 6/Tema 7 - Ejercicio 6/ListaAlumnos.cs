using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_7___Ejercicio_6
{
    public class ListaAlumnos
    {
        // Miembros
        private List<Alumno> lista;

        // Constructor
        public ListaAlumnos()
        {
            lista = new List<Alumno>();
        }

        // Métodos 
        // Método que permite crear un objeto del tipo Alumno e introducirle los valores recibidos por parámetro
        public void AnyadirAlumno(string nombre, string dni, string telefono, string codigo)
        {
            Alumno alumno = new Alumno();

            alumno.Nombre = nombre;
            alumno.Dni = dni;
            alumno.Telefono = telefono;
            alumno.CodigoCurso = codigo;

            lista.Add(alumno);
        }

        // Método que localiza un objeto de la lista en la posición recibida por parámetro y
        // llama al método correspondiente para añadir una nota a la lista propia del objeto
        public void AnyadirNota(int posicion, double nota)
        {
            lista[posicion].AnyadirNota(nota);
        }

        // Método que busca en la lista la posición de un nombre que recibe por parámetro y lo devuelve, 
        // si no lo encuentra, devuelve -1
        public int BuscarPosicion(string nombre)
        {
            int posicion = -1;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Nombre == nombre)
                    posicion = i;
            }

            return posicion;
        }

        // Método que devuelve true si la lista contiene al menos un elemento y false si está vacía
        public bool ComprobarTamaño()
        {
            bool contiene = false;

            if (lista.Count > 0)
            {
                contiene = true;
            }

            return contiene;
        }

        // Método que permite eliminar un objeto de la lista en la posición que recibe por parámetro
        public void EliminarAlumno(int posicion)
        {
            lista.RemoveAt(posicion);
        }

        // Método que llama al método de un objeto de la lista para limpiar su propia lista de notas 
        public void EliminarNotas(int posicion)
        {
            lista[posicion].EliminarNotas();
        }

        // Método que itera la lista y, por cada elemento, llama al método correspondiente de la clase Alumno 
        // para mostrar los valores de sus miembros
        public void MostrarAlumnos()
        {
            string texto = "Lista de alumnos:\n\n";

            foreach (Alumno alumno in lista)
            {
                texto += alumno.MostrarAlumno() + "\n";
            }

            MessageBox.Show(texto);
        }

        // Método que itera la lista y, por cada elemento que tenga una nota media igual o superior a 5,
        // llama al método correspondiente de la clase Alumno para mostrar los valores de sus miembros
        public void MostrarAlumnosAprobados()
        {
            string texto = "Lista de alumnos aprobados:\n\n";
            int contador = 0;

            foreach (Alumno alumno in lista)
            {
                if (alumno.CalcularMedia() >= 5)
                {
                    texto += alumno.MostrarAlumno() + "\n";
                    contador++;
                }
            }

            if (contador == 0)
                texto += "No hay alumnos aprobados.\n";

            MessageBox.Show(texto);
        }

        // Método que itera la lista y, por cada elemento que contenga el código recibido por parámetro,
        // llama al método correspondiente de la clase Alumno para mostrar los valores de sus miembros
        public void MostrarAlumnosPorCurso(string codigo)
        {
            string texto = "Lista de alumnos del curso con código " + codigo + ":\n\n";
            int contador = 0;

            foreach (Alumno alumno in lista)
            {
                if(alumno.CodigoCurso == codigo)
                {
                    texto += alumno.MostrarAlumno() + "\n"; 
                    contador++;
                }                   
            }

            if (contador == 0)
                texto += "No hay alumnos adscritos a este curso.\n";

            MessageBox.Show(texto);
        }

        // Método que itera la lista y, por cada elemento que tenga una nota media inferior a 5,
        // llama al método correspondiente de la clase Alumno para mostrar los valores de sus miembros
        public void MostrarAlumnosSuspensos()
        {
            string texto = "Lista de alumnos suspensos:\n\n";
            int contador = 0;

            foreach (Alumno alumno in lista)
            {
                if (alumno.CalcularMedia() < 5)
                {
                    texto += alumno.MostrarAlumno() + "\n";
                    contador++;
                }
            }

            if (contador == 0)
                texto += "No hay alumnos suspensos.\n";

            MessageBox.Show(texto);
        }

        // Método que muestra los valores de los miembros de un elemento de la lista que recibe por parámetro
        public void MostrarUnAlumno(int posicion)
        {
            string texto = "Datos del alumno:\n\n";

            texto += lista[posicion].MostrarAlumno() + "\n";

            MessageBox.Show(texto);
        }

        // Método para ordenar alfabéticamente por nombre los elementos de la lista
        public void OrdenarAlfabéticamentePorNombre()
        {
            Alumno aux;

            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (string.Compare(lista[j].Nombre, lista[i].Nombre) < 0)
                    {
                        aux = lista[i];
                        lista[i] = lista[j];
                        lista[j] = aux;
                    }
                }
            }
        }
    }
}
