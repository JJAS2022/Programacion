using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_7___Ejercicio_4
{
    internal class Lista
    {
        // Miembros
        private List<Empleado> lista;

        // Constructor
        public Lista() 
        {
            lista = new List<Empleado>();
        }  

        // Métodos
        public void AnyadirEmpleado(string nombre, string apellido, int edad, string telefono, string sexo, bool casado)
        {
            Empleado empleado = new Empleado();

            empleado.Nombre = nombre;
            empleado.Apellido = apellido;
            empleado.Edad = edad;
            empleado.Telefono = telefono;
            empleado.Sexo = sexo;
            empleado.Casado= casado;
         
            lista.Add(empleado);
        }

        public int ComprobarTamaño()
        {
            return lista.Count;
        }
        
        public int BuscarEmpleado(string nombre)
        {
            int posicion = -1;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Nombre == nombre)
                {
                    posicion = i;
                    break;
                }
            }

            return posicion;
        }

        public void AnyadirCumpleaños(int posicion)
        {
            Empleado empleado = lista[posicion];
            empleado.Cumpleanyos();                      
        }

        public void MostrarLista()
        {
            if (lista.Count > 0)
            {
                string texto = "Los datos de los empleados son los siguientes:\n\n";
                int contador = 1;
                foreach (Empleado empleado in lista)
                {
                    texto += "Empleado " + contador + ":\n";
                    texto += empleado.MostrarDatos();
                    contador++;
                }
                MessageBox.Show(texto);
            }
            else
            {
                MessageBox.Show("Introduzca datos de empleados para mostrar la lista.");
            }
        }

        public void AnyadirVenta(int posicion, double venta)
        {
            Empleado empleado = lista[posicion];
            empleado.Venta(venta);
        }
    }
}
