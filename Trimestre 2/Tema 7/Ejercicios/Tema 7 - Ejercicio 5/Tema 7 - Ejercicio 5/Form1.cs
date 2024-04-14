using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_7___Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Instancia de la lista de empleados que se emplea en todo el ejericio
        Lista empresa = new Lista();

        //---------------------------------------FUNCIONES-------------------------------------
        // Función que permite introducir valores que va pidiendo por InputBox, los almacena en variables
        // y se los pasa por parámetros a la función correspondiente de la clase Lista para que 
        // añada el objeto empleado con los valores recibidos.
        void IntroducirDatos()
        {
            string nombre = Interaction.InputBox("Introduzca el nombre del empleado.");
            string apellido = Interaction.InputBox("Introduzca el apellido del empleado.");
            int edad = int.Parse(Interaction.InputBox("Introduzca la edad del empleado."));
            string telefono = Interaction.InputBox("Introduzca el teléfono del empleado.");

            string sexo;
            do
            {
                sexo = Interaction.InputBox("Introduzca el sexo del empleado (M/F).");
            } while (sexo != "M" && sexo != "F");

            bool casado;
            DialogResult estado = MessageBox.Show("¿Está casado?", "Estado civil", MessageBoxButtons.YesNo);
            if (estado == DialogResult.Yes)
                casado = true;
            else
                casado = false;

            empresa.AnyadirEmpleado(nombre, apellido, edad, telefono, sexo, casado);
        }

        // Función que devuelve el string introducido mediante InputBox
        string IntroducirNombre()
        {
            string nombre = Interaction.InputBox("Introduzca el nombre del empleado.");
            return nombre;
        }

        // Función que devuelve el double introducido mediante InputBox, previa comprobación del formato
        double IntroducirVenta()
        {
            double venta = 0;

            try
            {
                venta = double.Parse(Interaction.InputBox("Introduzca el importe de la venta."));
                
            }
            catch
            {
                MessageBox.Show("El valor introducido no es válido.");
            }

            return venta;
        }

        // Lanza un mensaje de feedback al usuario sobre el éxito de la operación
        void MensajeExito()
        {
            MessageBox.Show("Se ha completado la acción correctamente.");
        }

        // Lanza un mensaje de feedback al usuario sobre el fracaso de la operación
        // debido a que el sring introducido no se corresponde con ninguno de los nombres 
        // que constan en los objetos de la lista.
        void MensajeFracaso()
        {
            MessageBox.Show("No se ha encontrado ningún empleado con ese nombre.");
        }

        // Lanza un mensaje de feedback al usuario sobre el fracaso de la operación
        // debido a que la lista está vacía
        void MensajeListaVacía()
        {
            MessageBox.Show("La lista no contiene elementos que mostrar.");
        }

        //---------------------------------------BOTONES-------------------------------------
        // Botón que llama a la función para añadir un nuevo empleado y lanza un mensaje de éxito
        private void btnIntroducir_Click(object sender, EventArgs e)
        {
            IntroducirDatos();
            MensajeExito();
        }

        // Botón que, previa comprobación de que hay elementos en la lista,
        // permite buscar la posición de un objeto y eliminarlo de la lista
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (empresa.ComprobarTamaño())
            {
                string nombre = IntroducirNombre();
                int posicion = empresa.BuscarEmpleado(nombre);

                if (posicion >= 0)
                {
                    empresa.EliminarEmpleado(posicion);
                    MensajeExito();
                }
                else
                {
                    MensajeFracaso();
                }
            }
            else
            {
                MensajeListaVacía();
            }
        }

        // Botón que, previa comprobación de que hay elementos en la lista,
        // muestra la lista llamando al método correspondiente
        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            if (empresa.ComprobarTamaño())
            {
                empresa.MostrarLista();
            }
            else
            {
                MensajeListaVacía();
            }
        }

        // Botón que, previa comprobación de que hay elementos en la lista,
        // ordena la lista alfabéticamente por el miembro nombre del objeto
        private void btnOrdenarEmpleados_Click(object sender, EventArgs e)
        {
            if (empresa.ComprobarTamaño())
            {
                empresa.OrdenarListaAlfabeticamente();
                empresa.MostrarLista();
            }
            else
            {
                MensajeListaVacía();
            }
        }

        // Botón que, previa comprobación de que hay elementos en la lista,
        // permite buscar la posición de un objeto y llama al método para mostrar su información
        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (empresa.ComprobarTamaño())
            {
                string nombre = IntroducirNombre();
                int posicion = empresa.BuscarEmpleado(nombre);

                if (posicion >= 0)
                {
                    empresa.MostrarEmpleado(posicion);
                }
                else
                {
                    MensajeFracaso();
                }
            }
            else
            {
               MensajeListaVacía();
            }
        }

        // Botón que, previa comprobación de que hay elementos en la lista,
        // permite buscar la posición de un objeto y añadirle una venta a su propia lista de ventas
        private void btnAnyadirVenta_Click(object sender, EventArgs e)
        {
            if (empresa.ComprobarTamaño())
            {
                string nombre = IntroducirNombre();
                int posicion = empresa.BuscarEmpleado(nombre);

                if (posicion >= 0)
                {
                    double venta = IntroducirVenta();

                    if (venta > 0)
                    {
                        empresa.AnyadirVentaAEmpleado(posicion, venta);
                        MensajeExito();
                    }
                }
                else
                {
                    MensajeFracaso();
                }
            }
            else
            {
                MensajeListaVacía();
            }
        }

        // Botón que, previa comprobación de que hay elementos en la lista,
        // permite buscar la posición del objeto con el valor más alto de ventas
        // y llama a su método para mostrar la información que almacena
        private void btnMostrarEmpleadoMayoresVentas_Click(object sender, EventArgs e)
        {
            if (empresa.ComprobarTamaño())
            {
                int posicion = empresa.BuscarMayorVenta();
                empresa.MostrarEmpleado(posicion);
            }
            else
            {
                MensajeListaVacía();
            }
        }

        // Botón que, previa comprobación de que hay elementos en la lista,
        // permite buscar la posición de un objeto y limpiar su propia lista de ventas
        private void btnEliminarVentas_Click(object sender, EventArgs e)
        {
            if (empresa.ComprobarTamaño())
            {
                string nombre = IntroducirNombre();
                int posicion = empresa.BuscarEmpleado(nombre);

                if (posicion >= 0)
                {
                    empresa.EliminarVentasDeEmpleado(posicion);
                    MensajeExito();
                }
                else
                {
                    MensajeFracaso();
                }
            }
            else
            {
                MensajeListaVacía();
            }
        }

        // Botón que, previa comprobación de que hay elementos en la lista,
        // permite ordenar de forma descendente la lista por el valor de ventas total
        private void btnOrdenarEmpleadosVentas_Click(object sender, EventArgs e)
        {
            if (empresa.ComprobarTamaño())
            {
                empresa.OrdenarListaPorVentas();
                empresa.MostrarLista();
            }
            else
            {
                MensajeListaVacía();
            }
        }
    }
}
