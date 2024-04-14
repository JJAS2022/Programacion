using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___Tema_8
{
    public class Cuadrado : Figura
    {
        // Miembros
        private int lado;

        // Propiedades
        public int Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        // Constructor
        public Cuadrado(int x, int y, string color, int lado) : base(x, y, color)
        {
            this.lado = lado;
        }

        // Métodos
        public override string QuienSoy()
        {
            return "Soy un cuadrado.\n";
        }

        public override string ToString()
        {
            string texto = base.ToString();

            texto += "Lado: " + lado + ".\n";

            return texto;
        }

        public override double Area()
        {
            return lado * lado;
        }

        public override double Perimetro()
        {
            return 4 * lado;
        }
    }
}
