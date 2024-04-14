using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5___Tema_8
{
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
        }

        // Punteros de la clase ListaCursos y ListaPersonas
        public ListaCursos cursos;
        public ListaPersonas personas;

        // ---------------------------------------- BOTONES DE ALUMNO ---------------------------------------
        private void bIntroducir_Click(object sender, EventArgs e)
        {
            if (cursos.ComprobarTamaño())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "alumno");

                string dni = "";
                bool dniUnico;
                do
                {
                    dni = Auxiliar.IntroducirValor("DNI", "alumno");
                    dniUnico = personas.ComprobarDni(dni);
                    if (dniUnico == false)
                        MessageBox.Show("El DNI introducido ya ha sido asignado.");
                } while (dniUnico == false);

                string telefono = Auxiliar.IntroducirValor("teléfono", "alumno");

                string codigo = "";
                int posicion = -1;
                do
                {
                    codigo = Auxiliar.IntroducirValor("código", "curso al que pertenece el alumno");
                    posicion = cursos.BuscarPosicion(codigo);
                } while (posicion < 0);

                personas.AnyadirAlumno(nombre, dni, telefono, codigo);
                Auxiliar.MensajeExito();
            }
            else
                Auxiliar.MensajeListaVacia("cursos");
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarAlumnos())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "alumno");
                int posicion = personas.BuscarPosicionAlumno(nombre);
                if (posicion >= 0)
                {
                    string dni = personas.DniAlumno(posicion);
                    personas.EliminarAlumno(posicion);
                    personas.EliminarPersona(dni);
                    Auxiliar.MensajeExito();
                }
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        private void bMostrarUnAlumno_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarAlumnos())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "alumno");
                int posicion = personas.BuscarPosicionAlumno(nombre);
                if (posicion >= 0)
                    personas.MostrarUnAlumno(posicion);
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        private void bOrdenarAlfabeticamente_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarAlumnos())
            {
                personas.OrdenarAlumnosAlfabéticamentePorNombre();
                personas.MostrarAlumnos();
            }
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        private void bMostrarAlumnosCurso_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarAlumnos())
            {
                string codigo = Auxiliar.IntroducirValor("código", "curso");
                personas.MostrarAlumnosPorCurso(codigo);
            }
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        private void bMostrarAlumnos_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarAlumnos())
                personas.MostrarAlumnos();
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        // ---------------------------------------- BOTONES DE NOTAS ---------------------------------------
        private void bAñadirNotas_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarAlumnos())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "alumno");
                int posicion = personas.BuscarPosicionAlumno(nombre);
                if (posicion >= 0)
                {
                    double nota = Auxiliar.IntroducirNota();
                    personas.AnyadirNota(posicion, nota);
                    personas.MostrarUnAlumno(posicion);
                }
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        private void bEliminarNotas_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarAlumnos())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "alumno");
                int posicion = personas.BuscarPosicionAlumno(nombre);
                if (posicion >= 0)
                {
                    personas.EliminarNotas(posicion);
                    Auxiliar.MensajeExito();
                }
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        private void bMostrarAprobados_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarAlumnos())
                personas.MostrarAlumnosAprobados();
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }

        private void bMostrarSuspensos_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarAlumnos())
                personas.MostrarAlumnosSuspensos();
            else
                Auxiliar.MensajeListaVacia("alumnos");
        }
    }
}
