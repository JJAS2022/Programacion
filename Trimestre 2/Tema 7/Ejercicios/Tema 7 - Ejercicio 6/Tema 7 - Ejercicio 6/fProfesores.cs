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
    public partial class fProfesores : Form
    {
        public fProfesores()
        {
            InitializeComponent();
        }

        // Crea un objeto de la clase ListaProfesores que almacenará el objeto instanciado
        // en el formulario principal
        public ListaProfesores profesores;

        // Crea un objeto de la clase ListaCursos que almacenará el objeto instanciado
        // en el formulario principal
        public ListaCursos cursos;

        // ----------------------------------------------- BOTONES DE PROFESOR -----------------------------------------------------
        // Botón que llama a la clase auxiliar para introducir los datos de un profesor
        // y se los pasa al método correspondiente del objeto profesores para añadirlo a la lista
        private void bIntroducir_Click(object sender, EventArgs e)
        {
            if (cursos.ComprobarTamaño())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "profesor");
                string dni = Auxiliar.IntroducirValor("DNI", "profesor");
                string telefono = Auxiliar.IntroducirValor("teléfono", "profesor");

                // Comprueba si el profesor es tutor de un algún curso y, en caso afirmativo, 
                // pide el código del curso hasta que se introduce un curso válido
                string codigo = "";
                int posicion = -1;
                bool tutor = false;

                DialogResult resultado = MessageBox.Show("¿El profesor tutoriza algún curso?", "Tutor", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    tutor = true;
                    do
                    {
                        codigo = Auxiliar.IntroducirValor("código", "curso del que es tutor.");
                        posicion = cursos.BuscarPosicion(codigo);
                    } while (posicion < 0);
                }

                profesores.AnyadirProfesor(nombre, dni, telefono, tutor, codigo);
                Auxiliar.MensajeExito();
            }
            else
                Auxiliar.MensajeListaVacia("cursos");
        }

        // Botón que, previa comprobación de que hay elementos en la lista,
        // permite eliminar un profesor de la lista introduciendo el nombre por un método de la clase Auxiliar
        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (profesores.ComprobarTamaño())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "profesor");
                int posicion = cursos.BuscarPosicion(nombre);
                if (posicion >= 0)
                {
                    profesores.EliminarProfesor(posicion);
                    Auxiliar.MensajeExito();
                }
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("profesores");
        }

        // Botón que permite mostrar los datos de un profesor
        private void bMostrarUnProfesor_Click(object sender, EventArgs e)
        {
            if (profesores.ComprobarTamaño())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "profesor");
                int posicion = profesores.BuscarPosicion(nombre);
                if (posicion >= 0)
                    profesores.MostrarUnProfesor(posicion);
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("profesores");
        }

        // Botón que ordena alfabéticamente los objetos de la lista por el nombre
        // y muestra el resultado en pantalla
        private void bOrdenar_Click(object sender, EventArgs e)
        {
            if (profesores.ComprobarTamaño())
            {
                profesores.OrdenarAlfabéticamentePorNombre();
                profesores.MostrarProfesores();
            }
            else
                Auxiliar.MensajeListaVacia("profesores");
        }

        // Botón que llama al método que muestra todos los elementos de la lista
        private void bMostrarProfesores_Click(object sender, EventArgs e)
        {
            if (profesores.ComprobarTamaño())
                profesores.MostrarProfesores();
            else
                Auxiliar.MensajeListaVacia("profesores");
        }

        // ----------------------------------------------- BOTONES DE ASIGNATURA -----------------------------------------------------
        // Botón para añadir una asignatura a un profesor, previa comprobación de que el nombre del profesor existe,
        // y se la pasa por parámetro a la función correspondiente
        private void bAnyadirAsignatura_Click(object sender, EventArgs e)
        {
            if (profesores.ComprobarTamaño())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "profesor");
                int posicion = profesores.BuscarPosicion(nombre);
                if (posicion >= 0)
                {
                    string asignatura = Auxiliar.IntroducirValor("nombre", "módulo que imparte");
                    profesores.AnyadirAsignatura(posicion, asignatura);
                    profesores.MostrarUnProfesor(posicion);
                }
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("profesores");
        }

        private void bEliminarAsignatura_Click(object sender, EventArgs e)
        {
            if (profesores.ComprobarTamaño())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "profesor");
                int posicion = profesores.BuscarPosicion(nombre);
                if (posicion >= 0)
                {
                    profesores.EliminarAsignaturas(posicion);
                    Auxiliar.MensajeExito();
                }
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("profesores");
        }

        private void bMostrarProfesorPorAsignatura_Click(object sender, EventArgs e)
        {
            if (profesores.ComprobarTamaño())
            {
                string asignatura = Auxiliar.IntroducirValor("nombre", "módulo");
                profesores.MostrarProfesoresPorAsignatura(asignatura);
            }
            else
                Auxiliar.MensajeListaVacia("profesores");
        }
    }
}
