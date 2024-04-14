using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___Tema_8
{
    public class Hexagono : Figura
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
        public Hexagono(int x, int y, string color, int lado) : base(x, y, color)
        {
            this.lado = lado;
        }

        // Métodos
        public override string QuienSoy()
        {
            return "Soy un hexágono regular.\n";
        }

        public override string ToString()
        {
            string texto = base.ToString();

            texto += "Lado: " + lado + ".\n";

            return texto;
        }

        public override double Area()
        {
            double perimetro = Perimetro();
            double catetoA = lado;
            double catetoB = lado/2;
            double apotema = Math.Sqrt((catetoA * catetoA) - (catetoB * catetoB));
            return (perimetro * apotema) / 2;
        }

        public override double Perimetro()
        {
            return 6 *  lado;
        }
    }
}
