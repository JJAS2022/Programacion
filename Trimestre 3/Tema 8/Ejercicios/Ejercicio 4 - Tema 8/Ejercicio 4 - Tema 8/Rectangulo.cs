using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___Tema_8
{
    public class Rectangulo : Figura
    {
        // Miembros
        private int largo;
        private int ancho;


        // Propiedades
        public int Largo
        {
            get { return largo; }
            set { largo = value; }
        }
        public int Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }

        // Constructor
        public Rectangulo(int x, int y, string color, int largo, int ancho) : base(x, y, color)
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        // Métodos
        public override string QuienSoy()
        {
            return "Soy un rectángulo.\n";
        }

        public override string ToString()
        {
            string texto = base.ToString();

            texto += "Largo: " + largo + ".\n";
            texto += "Ancho: " + ancho + ".\n";

            return texto;
        }

        public override double Area()
        {
            return largo * ancho;
        }

        public override double Perimetro()
        {
            return  2 * largo + 2 * ancho;
        }
    }
}
