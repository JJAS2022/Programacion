using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_7___Ejercicio_5
{
    internal class Lista
    {
        // Miembros de la clase
        private List<Empleado> lista;

        // Constructor
        public Lista()
        {
            lista = new List<Empleado>();
        }

        // Métodos
        // Método para instanciar un objeto de la clase empleado, acceder a sus miembros mediante las propiedades indicadas
        // y, finalmente, añadirlo a la lista.
        public void AnyadirEmpleado(string nombre, string apellido, int edad, string telefono, string sexo, bool casado)
        {
            Empleado empleado = new Empleado();

            empleado.Nombre = nombre;
            empleado.Apellido = apellido;
            empleado.Edad = edad;
            empleado.Telefono = telefono;
            empleado.Sexo = sexo;
            empleado.Casado = casado;

            lista.Add(empleado);
        }

        // Método para añadir una venta al empleado. Recibe por parámetro su posición en la lista y el importe de la venta
        public void AnyadirVentaAEmpleado(int posicion, double venta)
        {
            lista[posicion].AnyadirVentas(venta);
        }

        // Método para localizar la posición del empleado por el nombre que recibe por parámetro
        public int BuscarEmpleado(string nombre)
        {
            int posicion = -1;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Nombre == nombre)
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        // Método para conocer qué empleado tiene el mayor importe de ventas, que devuelve su posición en la lista
        public int BuscarMayorVenta()
        {
            int posicion = 0;
            int contador = 0;
            double ventas = 0;

            while (contador < lista.Count)
            {
                if (lista[contador].TotalVentas() > ventas)
                {
                    ventas = lista[contador].TotalVentas();
                    posicion = contador;
                }
                contador++;
            }
            
            return posicion;
        }

        // Método para saber si la lista contiene algún elemento
        public bool ComprobarTamaño()
        {
            bool datos = false;

            if (lista.Count > 0)
                datos = true;

            return datos;
        }

        // Método para eliminar de la lista el objeto en la posición recibida por parámetro
        public void EliminarEmpleado(int posicion)
        {
            lista.RemoveAt(posicion);
        }

        // Método para limpiar las ventas del empleado correspondiente a la posición de la lista recibida por parámetro
        public void EliminarVentasDeEmpleado(int posicion)
        {
            lista[posicion].EliminarVentas();
        }
    
        // Método para mostrar datos del empleado correspondiente a la posición de la lista recibida por parámetro
        public void MostrarEmpleado(int posicion)
        {
            string texto = lista[posicion].MostrarDatos();
            MessageBox.Show(texto);
        }

        // Método para mostrar la lista de empleados llamando al método propio de la clase Empleado
        public void MostrarLista()
        {
            string texto = "Los datos de los empleados son:\n\n";
            int contador = 1;

            foreach (Empleado empleado in lista)
            {
                texto += "Empleado " + contador + ":\n";
                texto += empleado.MostrarDatos() + "\n";
                contador++;
            }

            MessageBox.Show(texto); 
        }

        // Método para ordenar alfabéticamente por nombre los objetos de la lista
        public void OrdenarListaAlfabeticamente()
        {
            Empleado aux;

            for (int i = 0; i < (lista.Count - 1); i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (string.Compare(lista[j].Nombre, lista[i].Nombre) < 0)
                    {
                        aux = lista[i];
                        lista[i] = lista[j];
                        lista[j] = aux;
                    }
                }
            }
        }

        // Método para ordenar de forma descendente por el importe total de ventas los objetos de la lista
        public void OrdenarListaPorVentas()
        {
            Empleado aux;

            for (int i = 0; i < (lista.Count - 1); i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[j].TotalVentas() > lista[i].TotalVentas())
                    {
                        aux = lista[i];
                        lista[i] = lista[j];
                        lista[j] = aux;
                    }
                }
            }
        }
    }
}
