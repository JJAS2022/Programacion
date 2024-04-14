using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_9___Ejercicio_3
{
    public class Medicamento
    {
        // ------------------------------------- MIEMBROS --------------------------------
        private string codigo;
        private string nombre;
        private string principio;
        private string familia;
        private string forma;
        private string dosis;
        private string posologia;

        // ----------------------------------- PROPIEDADES ------------------------------
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Principio
        {
            get { return principio; }
            set { principio = value; }
        }

        public string Familia
        {
            get { return familia; }
            set { familia = value; }
        }

        public string Forma
        {
            get { return forma; }
            set { forma = value; }
        }

        public string Dosis
        {
            get { return dosis; }
            set { dosis = value; }
        }

        public string Posologia
        {
            get { return posologia; }
            set { posologia = value; }
        }

        // ----------------------------------- CONSTRUCTOR ------------------------------
        public Medicamento(string codigo, string nombre, string principio, string familia, 
            string forma, string dosis, string posologia)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.principio = principio;
            this.familia = familia;
            this.forma = forma;
            this.dosis = dosis;
            this.posologia = posologia;
        }
    }
}
