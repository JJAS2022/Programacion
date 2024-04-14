using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___Tema_8
{
    public class Triangulo : Figura
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
        public Triangulo(int x, int y, string color, int lado) : base(x, y, color)
        {
            this.lado = lado;
        }

        // Métodos
        public override string QuienSoy()
        {
            return "Soy un triángulo equilátero.\n";
        }

        public override string ToString()
        {
            string texto = base.ToString();

            texto += "Lado: " + lado + ".\n";

            return texto;
        }

        public override double Area()
        {
            double altura = lado * Math.Sqrt(3) / 2;
            return lado * altura / 2;
        }

        public override double Perimetro()
        {
            return 3 * lado;
        }
    }
}
