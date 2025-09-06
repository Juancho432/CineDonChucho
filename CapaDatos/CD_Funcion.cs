using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class CD_Funcion
    {
        //Indicar la cadena de conexion
        private static readonly string cadena =
            ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        // Insertar Función
        public void InsertarFuncion(int codigoPelicula, TimeSpan hora)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_InsertarFuncion", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodigoPelicula", codigoPelicula);
                comando.Parameters.AddWithValue("@HoraFuncion", hora);

                cn.Open();
                comando.ExecuteNonQuery();
            }
        }//metodo

        // Listar Funciones con su Película
        public DataTable ListarFunciones()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_ListarFunciones", cn);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
            }
            return dt;
        }//metodo

    }//clase
}
