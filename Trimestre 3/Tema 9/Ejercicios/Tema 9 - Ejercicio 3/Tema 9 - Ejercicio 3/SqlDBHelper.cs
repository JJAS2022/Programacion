using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_9___Ejercicio_3
{
    public class SqlDBHelper
    {
        // ------------------------------------- MIEMBROS ---------------------------------
        private DataSet ds;
        private SqlDataAdapter da;
        private int medicamentos;

        // ------------------------------------ PROPIEDADES -------------------------------
        public int Medicamentos
        {
            get { return medicamentos; }
        }

        // ------------------------------------ CONSTRUCTOR -------------------------------
        public SqlDBHelper()
        {
            MetodoPath();
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|\\AppData\\BaseDeDatos.mdf;Integrated Security=True";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            conexion.Open();

            string cadenaSQL = "SELECT * FROM Medicamentos";
            da = new SqlDataAdapter(cadenaSQL, conexion);

            ds = new DataSet();

            da.Fill(ds, "Medicamentos");

            medicamentos = ds.Tables["Medicamentos"].Rows.Count;

            conexion.Close();
        }

        // ----------------------------------- MÉTODOS ----------------------------------
        // --------------------------------- CONEXIÓN BD --------------------------------
        // Proporciona la ruta absoluta del path a la base de datos
        private void MetodoPath()
        {
            string relativa = @"..\..\";
            string absoluta = Path.GetFullPath(relativa);
            AppDomain.CurrentDomain.SetData("DataDirectory", absoluta);
        }

        // Permite comparar cadenas parecidas (mayúsculas, tildes) o incluidas en otra cadena
        private bool Comparar(string dato, string valor)
        {
            bool parecido = false;

            if (valor != "")
            {
                // Compara que ambas cadenas se parezcan aunque no coincidan mayúsuculas o tildes
                if (String.Compare(dato, valor, CultureInfo.CurrentCulture, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) == 0)
                    parecido = true;
                // Compara que una cadena incluya otra aunque no coincidan en las mayúsuculas
                else if (dato.IndexOf(valor, StringComparison.OrdinalIgnoreCase) >= 0)
                    parecido = true;
            }

            return parecido;
        }

        // ------------------------------------- CRUD ------------------------------------
        // Actualiza la base de datos en la posición recibida
        public void ActualizarMedicamento(Medicamento medicamento, int posicion)
        {
            DataRow fila = ds.Tables["Medicamentos"].Rows[posicion];

            fila[0] = medicamento.Codigo;
            fila[1] = medicamento.Nombre;
            fila[2] = medicamento.Principio;
            fila[3] = medicamento.Familia;
            fila[4] = medicamento.Forma;
            fila[5] = medicamento.Dosis;
            fila[6] = medicamento.Posologia;

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Medicamentos");
        }

        // Añade una fila a la base de datos
        public void AnyadirMedicamento(Medicamento medicamento)
        {
            DataRow fila = ds.Tables["Medicamentos"].NewRow();

            fila[0] = medicamento.Codigo;
            fila[1] = medicamento.Nombre;
            fila[2] = medicamento.Principio;
            fila[3] = medicamento.Familia;
            fila[4] = medicamento.Forma;
            fila[5] = medicamento.Dosis;
            fila[6] = medicamento.Posologia;

            ds.Tables["Medicamentos"].Rows.Add(fila);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Medicamentos");

            medicamentos++;
        }

        // Elimina una fila de la base de datos en la posición recibida
        public void EliminarMedicamento(int posicion)
        {
            ds.Tables["Medicamentos"].Rows[posicion].Delete();

            medicamentos--;

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Medicamentos");
        }

        // ------------------------------------ BÚSQUEDA -------------------------------------
        // Busca medicamentos según los valores introducidos
        public Medicamento BuscarMedicamentoPorValor(string valor, int posicion, int campo)
        {
            Medicamento medicamento = null;
            DataRow fila;

            fila = ds.Tables["Medicamentos"].Rows[posicion];
            string dato = fila[campo].ToString();

            if (fila[campo].ToString() == valor)
            {
                medicamento = new Medicamento(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), 
                    fila[3].ToString(), fila[4].ToString(), fila[5].ToString(), fila[6].ToString());
            }

            return medicamento;
        }

        // Busca medicamentos según los valores introducidos
        public Medicamento BuscarMedicamentoPorValorParecido(string valor, int posicion, int campo)
        {
            Medicamento medicamento = null;
            DataRow fila;

            fila = ds.Tables["Medicamentos"].Rows[posicion];
            string dato = fila[campo].ToString();
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (Comparar(dato, valor))
            {
                medicamento = new Medicamento(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(),
                    fila[3].ToString(), fila[4].ToString(), fila[5].ToString(), fila[6].ToString());
            }

            return medicamento;
        }

        // Busca un medicamento según la posición introducida
        public Medicamento BuscarMedicamentoPorPosicion(int posicion)
        {
            Medicamento medicamento = null;
            DataRow fila;

            if (posicion >= 0 && posicion < medicamentos)
            {
                fila = ds.Tables["Medicamentos"].Rows[posicion];
                medicamento = new Medicamento(fila[0].ToString(), fila[1].ToString(), fila[2].ToString(), 
                    fila[3].ToString(), fila[4].ToString(), fila[5].ToString(), fila[6].ToString());
            }

            return medicamento;
        }

        // Devuelve una posición del medicamento según el código que recibe
        public int BuscarPosicionPorCodigo(string codigo)
        {
            int posicion = -1;

            DataRow fila;

            for (int i = 0; i < medicamentos; i++)
            {
                fila = ds.Tables["Medicamentos"].Rows[i];
                if (fila[0].ToString() == codigo)
                {
                    posicion = i;
                }
            }

            return posicion;
        }

        // Devuelve el valor del campo y la posición que recibe por parámetro
        public string ValorActual(int posicion, int campo)
        {
            DataRow fila = ds.Tables["Medicamentos"].Rows[posicion];
            string valor = fila[campo].ToString();

            return valor;
        }      
    }
}
