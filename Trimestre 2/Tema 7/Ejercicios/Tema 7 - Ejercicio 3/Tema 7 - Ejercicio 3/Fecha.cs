using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7___Ejercicio_3
{
    internal class Fecha
    {
        // Miembros
        private int dia;
        private int mes;
        private int anyo;

        // Propiedades
        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public int Anyo
        {
            get { return anyo; }
            set { anyo = value; }
        }

        // Constructor
        public Fecha()
        {
            dia = 0;
            mes = 0;
            anyo = 0;
        }

        // Métodos
        public string MostrarFecha()
        {
            string texto = "";

            texto += dia.ToString("0#") + "/" + mes.ToString("0#") + "/" + anyo + "\n";

            return texto;
        }
    }
}
