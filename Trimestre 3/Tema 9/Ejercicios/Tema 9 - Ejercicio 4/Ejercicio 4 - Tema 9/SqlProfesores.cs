using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_4___Tema_9
{
    public class SqlProfesores
    {
        // Miembros
        private DataSet ds;
        private SqlDataAdapter da;
        private int profesores;

        // Propiedades
        public int Profesores
        {
            get { return profesores; }
        }

        // Constructor
        public SqlProfesores()
        {
            // Llamada al método para obtener la ruta absoluta a la base de datos
            MetodoPath();

            // Realizando la conexión con la base de datos
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\AppData\\Instituto.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            // Variable para introducir consultas SQL
            string cadenaSQL;

            // Inicialización del DataSet y del DataAdapter
            cadenaSQL = "SELECT * FROM Profesores";
            da = new SqlDataAdapter(cadenaSQL, conexion);
            ds = new DataSet();
            da.Fill(ds, "Profesores");
            profesores = ds.Tables["Profesores"].Rows.Count;

            // Cierre de la conexión
            conexion.Close();
        }

        // Métodos
        // ---------------------- CONEXIÓN BD --------------------
        // Proporciona la ruta absoluta del path a la base de datos
        private void MetodoPath()
        {
            string relativa = @"..\..\";
            string absoluta = Path.GetFullPath(relativa);
            AppDomain.CurrentDomain.SetData("DataDirectory", absoluta);
        }

        // ------------------------- CRUD ------------------------
        // Actualiza la base de datos en la posición recibida
        public void ActualizarProfesor(Profesor profesor, int posicion)
        {
            DataRow fila = ds.Tables["Profesores"].Rows[posicion];

            fila["DNI"] = profesor.Dni;
            fila["Nombre"] = profesor.Nombre;
            fila["Apellido"] = profesor.Apellido;
            fila["Tlf"] = profesor.Telefono;
            fila["EMail"] = profesor.Email;

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Profesores");
        }

        // Añade una fila a la base de datos
        public void AnyadirProfesor(Profesor profesor)
        {
            DataRow fila = ds.Tables["Profesores"].NewRow();

            fila["DNI"] = profesor.Dni;
            fila["Nombre"] = profesor.Nombre;
            fila["Apellido"] = profesor.Apellido;
            fila["Tlf"] = profesor.Telefono;
            fila["EMail"] = profesor.Email;

            ds.Tables["Profesores"].Rows.Add(fila);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Profesores");

            profesores++;
        }

        // Elimina una fila de la base de datos en la posición recibida
        public void EliminarProfesor(int posicion)
        {
            ds.Tables["Profesores"].Rows[posicion].Delete();

            profesores--;

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Profesores");
        }

        // ----------------------- BÚSQUEDA ----------------------
        // Busca un profesor según el apellido introducido
        public int BuscarProfesorPorApellido(string apellido)
        {
            int posicion = -1;
            DataRow fila;

            for (int i = 0; i < profesores; i++)
            {
                fila = ds.Tables["Profesores"].Rows[i];
                if (fila["Apellido"].ToString() == apellido)
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        // Busca un profesor según el DNI introducido
        public int BuscarProfesorPorDni(string dni)
        {
            int posicion = -1;
            DataRow fila;

            for (int i = 0; i < profesores; i++)
            {
                fila = ds.Tables["Profesores"].Rows[i];
                if (fila["DNI"].ToString() == dni)
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        // Busca un profesor según el email introducido
        public int BuscarProfesorPorEmail(string email)
        {
            int posicion = -1;
            DataRow fila;

            for (int i = 0; i < profesores; i++)
            {
                fila = ds.Tables["Profesores"].Rows[i];
                if (fila["EMail"].ToString() == email)
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        // Busca un profesor según la posición introducida
        public Profesor BuscarProfesorPorPosicion(int posicion)
        {
            Profesor profesor = null;

            if (posicion >= 0 && posicion < profesores)
            {
                DataRow fila = ds.Tables["Profesores"].Rows[posicion];
                profesor = new Profesor(fila["DNI"].ToString(), fila["Nombre"].ToString(), fila["Apellido"].ToString(), fila["Tlf"].ToString(), fila["EMail"].ToString());
            }

            return profesor;
        }

        // Busca un profesor según el teléfono introducido
        public int BuscarProfesorPorTelefono(string telefono)
        {
            int posicion = -1;
            DataRow fila;

            for (int i = 0; i < profesores; i++)
            {
                fila = ds.Tables["Profesores"].Rows[i];
                if (fila["Tlf"].ToString() == telefono)
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        // ----------------------- OTROS ----------------------
        // Devuelve el DNI del profesor en la posicion actual
        public string DniActual(int posicion)
        {
            DataRow fila = ds.Tables["Profesores"].Rows[posicion];
            string dni = fila["DNI"].ToString();

            return dni;
        }

        // Devuelve el email del profesor en la posicion actual
        public string EmailActual(int posicion)
        {
            DataRow fila = ds.Tables["Profesores"].Rows[posicion];
            string dni = fila["EMail"].ToString();

            return dni;
        }

        // Devuelve el email del profesor en la posicion actual
        public string TelefonoActual(int posicion)
        {
            DataRow fila = ds.Tables["Profesores"].Rows[posicion];
            string telefono = fila["Tlf"].ToString();

            return telefono;
        }
    }
}
