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
    public partial class FormProfesores : Form
    {
        public FormProfesores()
        {
            InitializeComponent();
        }

        // Punteros de la clase ListaCursos y ListaPersonas
        public ListaCursos cursos;
        public ListaPersonas personas;

        // ----------------------------------------------- BOTONES DE PROFESOR -----------------------------------------------------
        private void bIntroducir_Click(object sender, EventArgs e)
        {
            if (cursos.ComprobarTamaño())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "profesor");

                string dni = "";
                bool dniUnico;
                do
                {
                    dni = Auxiliar.IntroducirValor("DNI", "profesor");
                    dniUnico = personas.ComprobarDni(dni);
                    if (dniUnico == false)
                        MessageBox.Show("El DNI introducido ya ha sido asignado.");
                } while (dniUnico == false);

                string telefono = Auxiliar.IntroducirValor("teléfono", "profesor");
                string email = Auxiliar.IntroducirValor("email", "profesor");

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

                personas.AnyadirProfesor(nombre, dni, telefono, email, codigo, tutor);
                Auxiliar.MensajeExito();
            }
            else
                Auxiliar.MensajeListaVacia("cursos");
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarProfesores())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "profesor");
                int posicion = cursos.BuscarPosicion(nombre);
                if (posicion >= 0)
                {
                    string dni = personas.DniProfesor(posicion);
                    personas.EliminarProfesor(posicion);
                    personas.EliminarPersona(dni);
                    Auxiliar.MensajeExito();
                }
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("profesores");
        }

        private void bMostrarUnProfesor_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarProfesores())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "profesor");
                int posicion = personas.BuscarPosicionProfesor(nombre);
                if (posicion >= 0)
                    personas.MostrarUnProfesor(posicion);
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("profesores");
        }

        private void bOrdenar_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarProfesores())
            {
                personas.OrdenarProfesoresAlfabéticamentePorNombre();
                personas.MostrarProfesores();
            }
            else
                Auxiliar.MensajeListaVacia("profesores");
        }

        private void bMostrarProfesores_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarProfesores())
                personas.MostrarProfesores();
            else
                Auxiliar.MensajeListaVacia("profesores");
        }

        // ----------------------------------------------- BOTONES DE ASIGNATURA -----------------------------------------------------
        private void bAnyadirAsignatura_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarProfesores())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "profesor");
                int posicion = personas.BuscarPosicionProfesor(nombre);
                if (posicion >= 0)
                {
                    string asignatura = Auxiliar.IntroducirValor("nombre", "módulo que imparte");
                    personas.AnyadirAsignatura(posicion, asignatura);
                    personas.MostrarUnProfesor(posicion);
                }
                else
                    Auxiliar.MensajeValorNoExiste("nombre");
            }
            else
                Auxiliar.MensajeListaVacia("profesores");
        }

        private void bEliminarAsignatura_Click(object sender, EventArgs e)
        {
            if (personas.ComprobarProfesores())
            {
                string nombre = Auxiliar.IntroducirValor("nombre", "profesor");
                int posicion = personas.BuscarPosicionProfesor(nombre);
                if (posicion >= 0)
                {
                    personas.EliminarAsignaturas(posicion);
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
            if (personas.ComprobarProfesores())
            {
                string asignatura = Auxiliar.IntroducirValor("nombre", "módulo");
                personas.MostrarProfesoresPorAsignatura(asignatura);
            }
            else
                Auxiliar.MensajeListaVacia("profesores");
        }
    }
}
