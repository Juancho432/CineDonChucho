
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Venta
    {
        //Indicar la cadena de conexion
        private static readonly string cadena =
            ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        // Insertar Venta
        public void InsertarVenta(int codigoPelicula, int cantidadBoletas, decimal? valorUnitario = null, TimeSpan? horaFuncion = null)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoPelicula", codigoPelicula);
                cmd.Parameters.AddWithValue("@CantidadBoletas", cantidadBoletas);

                if (valorUnitario.HasValue)
                    cmd.Parameters.AddWithValue("@ValorUnitario", valorUnitario.Value);
                else
                    cmd.Parameters.AddWithValue("@ValorUnitario", DBNull.Value);

                if (horaFuncion.HasValue)
                    cmd.Parameters.AddWithValue("@HoraFuncion", horaFuncion.Value);
                else
                    cmd.Parameters.AddWithValue("@HoraFuncion", DBNull.Value);

                cn.Open();
                cmd.ExecuteNonQuery();
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
