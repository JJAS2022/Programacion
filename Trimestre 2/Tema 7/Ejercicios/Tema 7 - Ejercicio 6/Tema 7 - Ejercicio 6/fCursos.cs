using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_7___Ejercicio_6
{
    public partial class fCursos : Form
    {
        public fCursos()
        {
            InitializeComponent();
        }

        // Crea un objeto de la clase ListaCursos que almacenará el objeto instanciado
        // en el formulario principal
        public ListaCursos cursos;

        // Crea un objeto de la clase ListaAlumnos que almacenará el objeto instanciado
        // en el formulario principal
        public ListaAlumnos alumnos;

        // Botón que llama a la clase auxiliar para introducir el nombre y el código del curso
        // y se los pasa al método correspondiente del objeto cursos para añadirlo a la lista
        private void bAnyadir_Click(object sender, EventArgs e)
        {
            string nombre = Auxiliar.IntroducirValor("nombre", "curso");
            string codigo = Auxiliar.IntroducirValor("código", "curso");
            cursos.AnyadirCurso(nombre, codigo);
            Auxiliar.MensajeExito();
        }

        // Botón que llama a la clase auxiliar para introducir el código del curso a borrar
        // y se los pasa al método correspondiente del objeto cursos
        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (cursos.ComprobarTamaño())
            {
                string codigo = Auxiliar.IntroducirValor("código", "curso");
                int posicion = cursos.BuscarPosicion(codigo);
                if (posicion >= 0)
                {
                    cursos.EliminarCurso(posicion);
                    Auxiliar.MensajeExito();
                }
                else
                    Auxiliar.MensajeValorNoExiste("código");

            }
            else
                Auxiliar.MensajeListaVacia("cursos");
        }

        // Botón que llama al método correspondiente de la lista para mostrar sus elementos
        private void bMostrarCursos_Click(object sender, EventArgs e)
        {
            if (cursos.ComprobarTamaño())
            {
                cursos.MostrarCursos();
            }
            else
                Auxiliar.MensajeListaVacia("cursos");
        }

        // Botón que permite introducir el código de un curso y 
        // llama al método correspondiente de la clase ListaAlumnos para 
        // mostrar los alumnos según el código introducido
        private void bMostrarAlumnos_Click(object sender, EventArgs e)
        {
            if (cursos.ComprobarTamaño())
            {
                if (alumnos.ComprobarTamaño())
                {
                    string codigo = Auxiliar.IntroducirValor("código", "curso");
                    int posicion = cursos.BuscarPosicion(codigo);
                    if (posicion >= 0)
                    {
                        alumnos.MostrarAlumnosPorCurso(codigo);
                    }
                    else
                        Auxiliar.MensajeValorNoExiste("código");
                }
                else
                    Auxiliar.MensajeListaVacia("alumnos");
            }
            else
                Auxiliar.MensajeListaVacia("cursos");
        }
    }
}
