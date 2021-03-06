using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace D
{

    internal class Accesso
    {
        
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-CASA;DataBase= FrancoCasanova;user=sa;password=sistemas;");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

        private SqlCommand CrearComando(string nombre, List<SqlParameter> parametros = null)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion;
            comando.CommandText = nombre;
            comando.CommandType = CommandType.StoredProcedure;


            if (parametros != null && parametros.Count>0)
            {
                comando.Parameters.AddRange(parametros.ToArray());
            }
            return comando;

        }

        public DataTable Leer(string nombre, List<SqlParameter> parametros = null)
        {
            AbrirConexion();

            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = CrearComando(nombre, parametros);

            adaptador.Fill(tabla);

            adaptador = null;
            CerrarConexion();

            return tabla;
        }

        public int Escribir(string nombre, List<SqlParameter> parametros)
        {
            int filasAfectadas = 0;
            AbrirConexion();
            SqlCommand comando = CrearComando(nombre, parametros);

            try
            {
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch 
            {

                filasAfectadas = -1;
            }

            CerrarConexion();
            return filasAfectadas;
        }

        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.String;
            return parametro;
        }
        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.Int32;
            return parametro;
        }
    }
}
