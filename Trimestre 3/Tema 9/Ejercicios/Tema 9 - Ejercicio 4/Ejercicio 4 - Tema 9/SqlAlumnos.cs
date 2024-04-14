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
    public class SqlAlumnos
    {
        // Miembros
        private DataSet ds;
        private SqlDataAdapter da;
        private int alumnos;

        // Propiedades
        public int Alumnos
        {
            get { return alumnos; }
        }

        // Constructor
        public SqlAlumnos()
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
            cadenaSQL = "SELECT * FROM Alumnos";
            da = new SqlDataAdapter(cadenaSQL, conexion);
            ds = new DataSet();
            da.Fill(ds, "Alumnos");
            alumnos = ds.Tables["Alumnos"].Rows.Count;

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
        public void ActualizarAlumno(Alumno alumno, int posicion)
        {
            DataRow fila = ds.Tables["Alumnos"].Rows[posicion];

            fila["DNI"] = alumno.Dni;
            fila["Nombre"] = alumno.Nombre;
            fila["Apellido"] = alumno.Apellido;
            fila["Tlf"] = alumno.Telefono;
            fila["EMail"] = alumno.Email;
            fila["Direccion"] = alumno.Direccion;

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Alumnos");
        }

        // Añade una fila a la base de datos
        public void AnyadirAlumno(Alumno alumno)
        {
            DataRow fila = ds.Tables["Alumnos"].NewRow();

            fila["DNI"] = alumno.Dni;
            fila["Nombre"] = alumno.Nombre;
            fila["Apellido"] = alumno.Apellido;
            fila["Tlf"] = alumno.Telefono;
            fila["EMail"] = alumno.Email;
            fila["Direccion"] = alumno.Direccion;

            ds.Tables["Alumnos"].Rows.Add(fila);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Alumnos");

            alumnos++;
        }

        // Elimina una fila de la base de datos en la posición recibida
        public void EliminarAlumno(int posicion)
        {
            ds.Tables["Alumnos"].Rows[posicion].Delete();

            alumnos--;

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Alumnos");
        }

        // ----------------------- BÚSQUEDA ----------------------
        // Busca un alumno según el apellido introducido
        public int BuscarAlumnoPorApellido(string apellido)
        {
            int posicion = -1;
            DataRow fila;

            for (int i = 0; i < alumnos; i++)
            {
                fila = ds.Tables["Alumnos"].Rows[i];
                if (fila["Apellido"].ToString() == apellido)
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        // Busca un alumno según el DNI introducido
        public int BuscarAlumnoPorDni(string dni)
        {
            int posicion = -1;
            DataRow fila;

            for (int i = 0; i < alumnos; i++)
            {
                fila = ds.Tables["Alumnos"].Rows[i];
                if (fila["DNI"].ToString() == dni)
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        // Busca un alumno según el email introducido
        public int BuscarAlumnoPorEmail(string email)
        {
            int posicion = -1;
            DataRow fila;

            for (int i = 0; i < alumnos; i++)
            {
                fila = ds.Tables["Alumnos"].Rows[i];
                if (fila["EMail"].ToString() == email)
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        // Busca un alumno según la posición introducida
        public Alumno BuscarAlumnoPorPosicion(int posicion)
        {
            Alumno alumno = null;

            if (posicion >= 0 && posicion < alumnos)
            {
                DataRow fila = ds.Tables["Alumnos"].Rows[posicion];
                alumno = new Alumno(fila["DNI"].ToString(), fila["Nombre"].ToString(), fila["Apellido"].ToString(), fila["Tlf"].ToString(), fila["EMail"].ToString(), fila["Direccion"].ToString());
            }

            return alumno;
        }

        // Busca un alumno según el teléfono introducido
        public int BuscarAlumnoPorTelefono(string telefono)
        {
            int posicion = -1;
            DataRow fila;

            for (int i = 0; i < alumnos; i++)
            {
                fila = ds.Tables["Alumnos"].Rows[i];
                if (fila["Tlf"].ToString() == telefono)
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        // ----------------------- OTROS ----------------------
        // Devuelve el DNI del alumno en la posicion actual
        public string DniActual(int posicion)
        {
            DataRow fila = ds.Tables["Alumnos"].Rows[posicion];
            string dni = fila["DNI"].ToString();

            return dni;
        }

        // Devuelve el email del alumno en la posicion actual
        public string EmailActual(int posicion)
        {
            DataRow fila = ds.Tables["Alumnos"].Rows[posicion];
            string dni = fila["EMail"].ToString();

            return dni;
        }

        // Devuelve el email del alumno en la posicion actual
        public string TelefonoActual(int posicion)
        {
            DataRow fila = ds.Tables["Alumnos"].Rows[posicion];
            string telefono = fila["Tlf"].ToString();

            return telefono;
        }
    }
}
