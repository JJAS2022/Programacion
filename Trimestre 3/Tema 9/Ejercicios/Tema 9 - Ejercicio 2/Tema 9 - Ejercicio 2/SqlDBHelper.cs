using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_9___Ejercicio_2
{
    internal class SqlDBHelper
    {
        // Miembros 
        private DataSet dsProfesores;
        private SqlDataAdapter daProfesores;
        private int numProfesores;

        // Propiedades
        public int NumProfesores
        {
            get { return numProfesores; }
        }

        // Constructor
        public SqlDBHelper()
        {
            MetodoPath();
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\AppData\\Instituto.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            conexion.Open();

            string cadenaSQL = "SELECT * FROM Profesores";
            daProfesores = new SqlDataAdapter(cadenaSQL, conexion);

            dsProfesores = new DataSet();

            daProfesores.Fill(dsProfesores, "Profesores");

            numProfesores = dsProfesores.Tables["Profesores"].Rows.Count;

            conexion.Close();
        }

        // Metodos
        public int BuscarProfesorPorApellido(string apellido)
        {
            int posicion = -1;
            DataRow fila;
            string apell;

            for (int i = 0; i < numProfesores; i++)
            {
                fila = dsProfesores.Tables["Profesores"].Rows[i];
                apell = fila["Apellido"].ToString();
                if (apell == apellido)
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        public Profesor BuscarProfesorPorPosicion(int posicion)
        {
            Profesor profesor = null;

            if (posicion >= 0 && posicion < numProfesores)
            {
                DataRow fila = dsProfesores.Tables["Profesores"].Rows[posicion];
                profesor = new Profesor(fila["DNI"].ToString(), fila["Nombre"].ToString(), fila["Apellido"].ToString(), fila["Tlf"].ToString(), fila["EMail"].ToString());
            }

            return profesor;
        }

        public string DniActual(int posicion)
        {
            DataRow fila = dsProfesores.Tables["Profesores"].Rows[posicion];
            string dni = fila["DNI"].ToString();

            return dni;
        }

        public bool DniUsado(string dni)
        {
            bool usado = false;
            DataRow fila;
            string id;

            for (int i = 0; i < numProfesores; i++)
            {
                fila = dsProfesores.Tables["Profesores"].Rows[i];
                id = fila["DNI"].ToString();
                if (id == dni)
                {
                    usado = true;
                }
            }

            return usado;
        }

        public bool HayDatos()
        {
            bool hay = false;

            if (numProfesores > 0)
            {
                hay = true;
            }

            return hay;
        }

        private void MetodoPath()
        {
            string relative = @"..\..\";
            string absolute = Path.GetFullPath(relative);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);
        }

        public void MostrarTodos()
        {
            string texto = "Lista de profesores:\n\n";
            DataRow fila;

            for (int i = 0; i < numProfesores; i++)
            {
                fila = dsProfesores.Tables["Profesores"].Rows[i];

                texto += "DNI: " + fila["DNI"].ToString() + ".\n";
                texto += "Nombre: " + fila["Nombre"].ToString() + ".\n";
                texto += "Apellido: " + fila["Apellido"].ToString() + ".\n";
                texto += "Teléfono: " + fila["Tlf"].ToString() + ".\n";
                texto += "Email: " + fila["EMail"].ToString() + ".\n";
                texto += "\n";
            }

            MessageBox.Show(texto);
        }

        // Métodos CRUD
        public void AnyadirProfesor(Profesor profesor)
        {
            DataRow fila = dsProfesores.Tables["Profesores"].NewRow();

            fila["DNI"] = profesor.Dni;
            fila["Nombre"] = profesor.Nombre;
            fila["Apellido"] = profesor.Apellido;
            fila["Tlf"] = profesor.Telefono;
            fila["EMail"] = profesor.Email;

            dsProfesores.Tables["Profesores"].Rows.Add(fila);

            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dsProfesores, "Profesores");

            numProfesores++;
        }

        public void ActualizarProfesor(Profesor profesor, int posicion)
        {
            DataRow fila = dsProfesores.Tables["Profesores"].Rows[posicion];

            fila["DNI"] = profesor.Dni;
            fila["Nombre"] = profesor.Nombre;
            fila["Apellido"] = profesor.Apellido;
            fila["Tlf"] = profesor.Telefono;
            fila["EMail"] = profesor.Email;

            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dsProfesores, "Profesores");
        }

        public void EliminarProfesor(int posicion)
        {
            dsProfesores.Tables["Profesores"].Rows[posicion].Delete();

            numProfesores--;

            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dsProfesores, "Profesores");
        }
    }
}
