using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___Tema_8
{
    public abstract class Figura
    {
        // Miembros
        private int posicionX;
        private int posicionY;
        private string color;

        // Propiedades
        public int PosicionX
        {
            get { return posicionX; }
            set { posicionX = value; }
        }

        public int PosicionY
        {
            get { return posicionY; }
            set { posicionY = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // Constructor
        public Figura(int x, int y, string color)
        {
            posicionX = x;
            posicionY = y;
            this.color = color;
        }

        // Métodos
        public virtual string QuienSoy()
        {
            return "Soy una figura";
        }

        public override string ToString()
        {
            string texto;

            texto = "Posicion X: " + PosicionX + ".\n" +
                    "Posicion Y: " + PosicionY + ".\n" +
                    "Color: " + color + ".\n";

            return texto;
        }

        public abstract double Area();

        public abstract double Perimetro();
    }
}
