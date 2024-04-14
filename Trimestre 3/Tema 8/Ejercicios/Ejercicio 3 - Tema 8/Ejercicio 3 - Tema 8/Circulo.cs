using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3___Tema_8
{
    public class Circulo : Figura
    {
        // Miembros
        private int radio;

        // Propiedades
        public int Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        // Constructor
        public Circulo(int x, int y, string color, int radio) : base(x, y, color)
        {
            this.radio = radio;
        }

        // Métodos
        public override string QuienSoy()
        {
            return "Soy un círculo.\n";
        }

        public override string ToString()
        {
            string texto = base.ToString();

            texto += "Radio: " + radio + ".\n";

            return texto;
        }

        public override double Area()
        {
            return Math.PI * radio * radio;
        }
    }
}
