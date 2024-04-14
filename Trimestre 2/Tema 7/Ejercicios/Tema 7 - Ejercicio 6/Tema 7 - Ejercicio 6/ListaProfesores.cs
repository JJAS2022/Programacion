using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_7___Ejercicio_6
{
    public class ListaProfesores
    {
        // Miembros
        private List<Profesor> lista;

        // Constructor
        public ListaProfesores()
        {
            lista = new List<Profesor>();
        }

        // Métodos 
        // Método que permite crear un objeto del tipo Profesor e introducirle los valores recibidos por parámetro
        public void AnyadirProfesor(string nombre, string dni, string telefono, bool tutor, string codigo)
        {
            Profesor profesor = new Profesor();

            profesor.Nombre = nombre;
            profesor.Dni = dni;
            profesor.Telefono = telefono;
            profesor.Tutor = tutor;
            profesor.CodigoCurso = codigo;

            lista.Add(profesor);
        }

        // Método que localiza un objeto de la lista en la posición recibida por parámetro y
        // llama al método correspondiente para añadir una asignatura a la lista propia del objeto
        public void AnyadirAsignatura(int posicion, string asignatura)
        {
            lista[posicion].AnyadirAsignatura(asignatura);
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

        // Método que llama al método de un objeto de la lista para limpiar su propia lista de notas 
        public void EliminarAsignaturas(int posicion)
        {
            lista[posicion].EliminarAsignaturas();
        }

        // Método que permite eliminar un objeto de la lista en la posición que recibe por parámetro
        public void EliminarProfesor(int posicion)
        {
            lista.RemoveAt(posicion);
        }

        // Método que itera la lista y, por cada elemento, llama al método correspondiente de la clase Profesor 
        // para mostrar los valores de sus miembros
        public void MostrarProfesores()
        {
            string texto = "Lista de profesores:\n\n";

            foreach (Profesor profesor in lista)
            {
                texto += profesor.MostrarProfesor() + "\n";
            }

            MessageBox.Show(texto);
        }

        // Método que itera la lista y, por cada elemento que coincida con la asignatura introducida,
        // llama al método correspondiente de la clase Profesor para mostrar los valores de sus miembros
        public void MostrarProfesoresPorAsignatura(string asignatura)
        {
            string texto = "Lista de profesores que imparten la asignatura de " + asignatura + ":\n\n";
            int contador = 0;

            foreach (Profesor profesor in lista)
            {
                if (profesor.ImparteAsignatura(asignatura))
                {
                    texto += profesor.MostrarProfesor() + "\n";
                    contador++;
                }
            }

            if (contador == 0)
                texto += "No hay profesores asignados a esta asignatura.\n";

            MessageBox.Show(texto);
        }

        // Método que muestra los valores de los miembros de un elemento de la lista que recibe por parámetro
        public void MostrarUnProfesor(int posicion)
        {
            string texto = "Datos del profesor:\n\n";

            texto += lista[posicion].MostrarProfesor() + "\n";

            MessageBox.Show(texto);
        }

        // Método para ordenar alfabéticamente por nombre los elementos de la lista
        public void OrdenarAlfabéticamentePorNombre()
        {
            Profesor aux;

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
