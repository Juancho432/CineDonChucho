
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class CD_Pelicula
    {
        //Indicar la cadena de conexion
        private static readonly string cadena =
            ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        // Insertar Película
        public void InsertarPelicula(string nombre, int duracion, string genero)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_InsertarPelicula", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Duracion", duracion);
                comando.Parameters.AddWithValue("@Genero", genero);

                cn.Open();
                comando.ExecuteNonQuery();
            }
        } //metodo


        // Actualizar Película
        public void ActualizarPelicula(int codigo, string nombre, int duracion, string genero)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_ActualizarPelicula", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Codigo", codigo);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Duracion", duracion);
                comando.Parameters.AddWithValue("@Genero", genero);

                cn.Open();
                comando.ExecuteNonQuery();
            }
        }//metodo

        // Eliminar Película
        public void EliminarPelicula(int codigo)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_EliminarPelicula", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Codigo", codigo);

                cn.Open();
                comando.ExecuteNonQuery();
            }
        }//metodo


        // Buscar Película por Código
        public DataRow BuscarPelicula(int codigo)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_BuscarPelicula", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Codigo", codigo);

                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
            }

            return (dt.Rows.Count > 0) ? dt.Rows[0] : null;
        }//metodo

        // Listar Películas
        public DataTable ListarPeliculas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_ListarPeliculas", cn);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
            }
            return dt;
        }//metodo

    }//clase
}
