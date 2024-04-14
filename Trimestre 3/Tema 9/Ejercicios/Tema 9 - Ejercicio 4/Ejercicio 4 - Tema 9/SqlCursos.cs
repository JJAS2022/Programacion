using Microsoft.Win32;
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
    public class SqlCursos
    {
        // Miembros
        private DataSet ds;
        private SqlDataAdapter da;
        private int cursos;

        // Propiedades
        public int Cursos
        {
            get { return cursos; }
        }

        // Constructor
        public SqlCursos()
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
            cadenaSQL = "SELECT * FROM Cursos";
            da = new SqlDataAdapter(cadenaSQL, conexion);
            ds = new DataSet();
            da.Fill(ds, "Cursos");
            cursos = ds.Tables["Cursos"].Rows.Count;

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
        public void ActualizarCurso(Curso curso, int posicion)
        {
            DataRow fila = ds.Tables["Cursos"].Rows[posicion];

            fila["Nombre"] = curso.Nombre;
            fila["Codigo"] = curso.Codigo;

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Cursos");
        }
        
        // Añade una fila a la base de datos
        public void AnyadirCurso(Curso curso)
        {
            DataRow fila = ds.Tables["Cursos"].NewRow();

            fila["Nombre"] = curso.Nombre;
            fila["Codigo"] = curso.Codigo;

            ds.Tables["Cursos"].Rows.Add(fila);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Cursos");

            cursos++;
        }

        // Elimina una fila de la base de datos en la posición recibida
        public void EliminarCurso(int posicion)
        {
            ds.Tables["Cursos"].Rows[posicion].Delete();

            cursos--;

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Cursos");
        }

        // ----------------------- BÚSQUEDA ----------------------
        // Busca un curso según el código introducido
        public int BuscarCursoPorCodigo(string codigo)
        {
            int posicion = -1;
            DataRow fila;

            for (int i = 0; i < cursos; i++)
            {
                fila = ds.Tables["Cursos"].Rows[i];
                if (fila["Codigo"].ToString() == codigo)
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        // Busca un curso según el nombre introducido
        public int BuscarCursoPorNombre(string nombre)
        {
            int posicion = -1;
            DataRow fila;

            for (int i = 0; i < cursos; i++)
            {
                fila = ds.Tables["Cursos"].Rows[i];
                if (fila["Nombre"].ToString() == nombre)
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        // Busca un curso según la posición introducida
        public Curso BuscarCursoPorPosicion(int posicion)
        {
            Curso curso = null;

            if (posicion >= 0 && posicion < cursos)
            {
                DataRow fila = ds.Tables["Cursos"].Rows[posicion];
                curso = new Curso(fila["Nombre"].ToString(), fila["Codigo"].ToString());
            }

            return curso;
        }

        // ----------------------- OTROS ----------------------
        // Devuelve el codigo del curso en la posicion actual
        public string CodigoActual(int posicion)
        {
            DataRow fila = ds.Tables["Cursos"].Rows[posicion];
            string codigo = fila["Codigo"].ToString();

            return codigo;
        }

        // Devuelve el nombre del curso en la posicion actual
        public string NombreActual(int posicion)
        {
            DataRow fila = ds.Tables["Cursos"].Rows[posicion];
            string nombre = fila["Nombre"].ToString();

            return nombre;
        }
    }
}
