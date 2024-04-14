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
    public partial class fAlumnos : Form
    {
        public fAlumnos()
        {
            InitializeComponent();
        }

        // Crea un objeto de la clase ListaAlumnos que almacenará el objeto instanciado
        // en el formulario principal
        public ListaAlumnos alumnos;

        // Crea un objeto de la clase ListaCursos que almacenará el objeto instanciado
        // en el formulario principal
        public ListaCursos cursos;

        // ---------------------------------------- BOTONES DE ALUMNO ---------------------------------------
        
        // Botón que llama a la clase auxiliar para introducir los datos de un alumno
        // y se los pasa al método correspondiente del objeto alumnos para añadirlo a la lista
        private void bIntroducir_Click(object sender, EventArgs e)
        {
            if (cursos.ComprobarTamaño())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "alumno");
                string dni = Auxiliar.IntroducirValor("DNI", "alumno");
                string telefono = Auxiliar.IntroducirValor("teléfono", "alumno");

                // Bucle que no permite introducir valores de cursos que no estén en la lista de cursos
                // Solamente se sale al introducir un código de curso válido
                string codigo = "";
                int posicion = -1;
                do
                {
                    codigo = Auxiliar.IntroducirValor("código", "curso al que pertenece el alumno");
                    posicion = cursos.BuscarPosicion(codigo);
                } while (posicion < 0);

                alumnos.AnyadirAlumno(nombre, dni, telefono, codigo);
                Auxiliar.MensajeExito();
            }
            else
                Auxiliar.MensajeListaVacia("cursos");
        }

        // Botón que, previa comprobación de que hay elementos en la lista,
        // permite eliminar un alumno de la lista introduciendo el nombre por un método de la clase Auxiliar
        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (alumnos.ComprobarTamaño())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "alumno");
                int posicion = cursos.BuscarPosicion(nombre);
                if (posicion >= 0)
                {
                    alumnos.EliminarAlumno(posicion);
                    Auxiliar.MensajeExito();
                }
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        // Botón que permite mostrar los datos de un alumno
        private void bMostrarUnAlumno_Click(object sender, EventArgs e)
        {
            if (alumnos.ComprobarTamaño())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "alumno");
                int posicion = alumnos.BuscarPosicion(nombre);
                if (posicion >= 0)
                    alumnos.MostrarUnAlumno(posicion);
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        // Botón que ordena alfabéticamente los objetos de la lista por el nombre
        // y muestra el resultado en pantalla
        private void bOrdenarAlfabeticamente_Click(object sender, EventArgs e)
        {
            if (alumnos.ComprobarTamaño())
            {
                alumnos.OrdenarAlfabéticamentePorNombre();
                alumnos.MostrarAlumnos();
            }
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        // Botón que muestra todos los alumnos de un curso llamando a un método específico que recibe
        // el código del curso por parámetro, y lo comprueba en cada uno de los elementos de su lista
        private void bMostrarAlumnosCurso_Click(object sender, EventArgs e)
        {
            if (alumnos.ComprobarTamaño())
            {
                string codigo = Auxiliar.IntroducirValor("código", "curso");
                alumnos.MostrarAlumnosPorCurso(codigo);
            }
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        // Botón que llama al método que muestra todos los elementos de la lista
        private void bMostrarAlumnos_Click(object sender, EventArgs e)
        {
            if (alumnos.ComprobarTamaño())
                alumnos.MostrarAlumnos();
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        // ---------------------------------------- BOTONES DE NOTAS ---------------------------------------
        // Botón para añadir una nota a un alumno, previa comprobación de que la nota está en un
        // rango adecuado, y se la pasa por parámetro a la función correspondiente
        private void bAñadirNotas_Click(object sender, EventArgs e)
        {
            if (alumnos.ComprobarTamaño())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "alumno");               
                int posicion = alumnos.BuscarPosicion(nombre);
                if (posicion >= 0)
                {
                    double nota = Auxiliar.IntroducirNota();
                    alumnos.AnyadirNota(posicion, nota);
                    alumnos.MostrarUnAlumno(posicion);
                }
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        // Botón que llama al método para limpiar la lista de notas de un objeto de la lista alumnos
        // que recibe por parámetro
        private void bEliminarNotas_Click(object sender, EventArgs e)
        {
            if (alumnos.ComprobarTamaño())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "alumno");
                int posicion = alumnos.BuscarPosicion(nombre);
                if (posicion >= 0)
                {
                    alumnos.EliminarNotas(posicion);
                    Auxiliar.MensajeExito();
                }
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        // Botón que llama a la función de la clase ListaAlumnos par mostrar aquellos alumnos cuya nota media es 
        // igual o superior a 5 puntos
        private void bMostrarAprobados_Click(object sender, EventArgs e)
        {
            if (alumnos.ComprobarTamaño())  
                alumnos.MostrarAlumnosAprobados();           
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        // Botón que llama a la función de la clase ListaAlumnos par mostrar aquellos alumnos cuya nota media es 
        // inferior a 5 puntos
        private void bMostrarSuspensos_Click(object sender, EventArgs e)
        {
            if (alumnos.ComprobarTamaño())
                alumnos.MostrarAlumnosSuspensos();
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }
    }
}
