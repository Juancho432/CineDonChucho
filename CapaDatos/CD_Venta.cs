
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Venta
    {
        private static readonly string cadena =
            ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        // Insertar Venta
        public void InsertarVenta(int codigoPelicula, int cantidadBoletas, decimal valorUnitario, DateTime? horaFuncion = null)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_InsertarVenta", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodigoPelicula", codigoPelicula);
                comando.Parameters.AddWithValue("@CantidadBoletas", cantidadBoletas);
                comando.Parameters.AddWithValue("@ValorUnitario", valorUnitario);

                if (horaFuncion.HasValue)
                    comando.Parameters.AddWithValue("@HoraFuncion", horaFuncion.Value);
                else
                    comando.Parameters.AddWithValue("@HoraFuncion", DBNull.Value);

                cn.Open();
                comando.ExecuteNonQuery();
            }
        }

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
        }
    }//clase
}
