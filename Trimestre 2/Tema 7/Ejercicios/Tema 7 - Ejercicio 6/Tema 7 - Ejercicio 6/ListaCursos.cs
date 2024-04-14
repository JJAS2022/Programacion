using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_7___Ejercicio_6
{
    public class ListaCursos
    {
        // Miembros
        private List<Curso> lista;

        // Constructor
        public ListaCursos()
        {
            lista = new List<Curso>();
        }

        // Métodos 
        // Método que permite crear un objeto del tipo Curso e introducirle los valores recibidos por parámetro
        public void AnyadirCurso(string nombre, string codigo)
        {
            Curso curso = new Curso();

            curso.Nombre = nombre;
            curso.Codigo = codigo;

            lista.Add(curso);
        }

        // Método que busca en la lista la posición de un código que recibe por parámetro y lo devuelve, 
        // si no lo encuentra, devuelve -1
        public int BuscarPosicion(string codigo)
        {
            int posicion = -1;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Codigo == codigo)
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
        public void EliminarCurso(int posicion)
        {
            lista.RemoveAt(posicion);
        }

        // Método que itera la lista y, por cada elemento, llama al método correspondiente de la clase Curso 
        // para mostrar los valores de sus miembros
        public void MostrarCursos()
        {
            string texto = "Lista de cursos:\n\n";

            foreach (Curso curso in lista)
            {
                texto += curso.MostrarCurso() + "\n"; 
            }

            MessageBox.Show(texto);
        }
    }
}
