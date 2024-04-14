using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5___Tema_8
{
    internal class Alumno : Persona
    {
        // Miembros
        private string codigoCurso;
        private List<double> notas;

        // Propiedades   
        public string CodigoCurso
        {
            get { return codigoCurso; }
            set { codigoCurso = value; }
        }

        // Constructor
        public Alumno(string nombre, string dni, string telefono, string codigoCurso) : base (nombre, dni, telefono)
        {
            this.codigoCurso = codigoCurso;
            notas = new List<double>();
        }

        // Métodos
        public void AnyadirNota(double nota)
        {
            notas.Add(nota);
        }

        public double CalcularMedia()
        {
            double total = 0;
            int evaluaciones = 0;

            foreach (double nota in notas)
            {
                total += nota;
                evaluaciones++;
            }

            double media = total / evaluaciones;

            return media;
        }

        public void EliminarNotas()
        {
            notas.Clear();
        }

        public override string MostrarDatos()
        {
            string texto = "";

            texto += base.MostrarDatos();
            texto += "Código del curso al que pertenece: " + codigoCurso + ".\n";
            texto += MostrarNotas();

            return texto;
        }

        private string MostrarNotas()
        {
            string texto = "Notas:\n";

            foreach (double nota in notas)
            {
                texto += "      " + nota.ToString() + " puntos.\n";
            }

            if (notas.Count > 0)
                texto += "Media: " + CalcularMedia().ToString("0.##") + " puntos.\n";
            else
                texto += "No hay notas que mostrar.\n";

            return texto;
        }
    }
}
