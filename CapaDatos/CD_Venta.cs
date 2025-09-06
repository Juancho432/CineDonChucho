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
    public class CD_Venta
    {
        //Indicar la cadena de conexion
        private static readonly string cadena =
            ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        // Insertar Venta
        public void InsertarVenta(int funcionID, int cantidadBoletas, decimal valorUnitario)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_InsertarVenta", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@FuncionID", funcionID);
                comando.Parameters.AddWithValue("@CantidadBoletas", cantidadBoletas);
                comando.Parameters.AddWithValue("@ValorUnitario", valorUnitario);

                cn.Open();
                comando.ExecuteNonQuery();
            }
        }//metodo

        // Listar Ventas
        public DataTable ListarVentas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_ListarVentas", cn);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
            }
            return dt;
        }//metodo

    }//clase
}
