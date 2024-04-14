using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5___Tema_8
{
    public class ListaCursos
    {
        // Miembro
        private List<Curso> lista;

        // Constructor
        public ListaCursos()
        {
            lista = new List<Curso>();
        }

        // Métodos 
        public void AnyadirCurso(string nombre, string codigo)
        {
            Curso curso = new Curso();

            curso.Nombre = nombre;
            curso.Codigo = codigo;

            lista.Add(curso);
        }

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

        public bool ComprobarValor(string codigo)
        {
            bool existe = false;

            foreach (Curso curso in lista)
            {
                if (curso.Codigo == codigo)
                    existe = true;
            }

            return existe; 
        }

        public bool ComprobarTamaño()
        {
            bool contiene = false;

            if (lista.Count > 0)
            {
                contiene = true;
            }

            return contiene;
        }

        public void EliminarCurso(int posicion)
        {
            lista.RemoveAt(posicion);
        }

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
