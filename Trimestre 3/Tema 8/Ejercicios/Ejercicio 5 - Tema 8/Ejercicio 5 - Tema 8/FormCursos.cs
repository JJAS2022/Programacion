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
    public partial class FormCursos : Form
    {
        public FormCursos()
        {
            InitializeComponent();
        }

        // Punteros de la clase ListaCursos y ListaPersonas
        public ListaCursos cursos;
        public ListaPersonas personas;

        private void bAnyadir_Click(object sender, EventArgs e)
        {
            string nombre = Auxiliar.IntroducirValor("nombre", "curso");
            string codigo = Auxiliar.IntroducirValor("código", "curso");

            if (!cursos.ComprobarValor(codigo))
            {
                cursos.AnyadirCurso(nombre, codigo);
                Auxiliar.MensajeExito();
            }
            else
                Auxiliar.MensajeValorRepetido("curso");    
        }

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

        private void bMostrarCursos_Click(object sender, EventArgs e)
        {
            if (cursos.ComprobarTamaño())
            {
                cursos.MostrarCursos();
            }
            else
                Auxiliar.MensajeListaVacia("cursos");
        }

        private void bMostrarAlumnos_Click(object sender, EventArgs e)
        {
            if (cursos.ComprobarTamaño())
            {
                if (personas.ComprobarAlumnos())
                {
                    string codigo = Auxiliar.IntroducirValor("código", "curso");
                    int posicion = cursos.BuscarPosicion(codigo);
                    if (posicion >= 0)
                    {
                        personas.MostrarAlumnosPorCurso(codigo);
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
