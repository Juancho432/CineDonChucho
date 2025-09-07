
using System;
using System.Data;
using CapaDatos;


namespace CapaNegocio
{
    public class CN_Cine
    {

        private readonly CD_Pelicula objCDPelicula = new CD_Pelicula();

        public Pelicula BuscarPelicula(string codigo)
        {
            DataRow result = objCDPelicula.BuscarPelicula(int.Parse(codigo));
            return new Pelicula
            {
                Codigo = result["codigo"].ToString(),
                Nombre = result["nombre"].ToString(),
                Duracion = uint.Parse(result["duracion"].ToString()),
                Genero = result["genero"].ToString()
            };
        }

        public void RegistrarPelicula(Pelicula pelicula)
        {
            objCDPelicula.InsertarPelicula(pelicula.Nombre, (int)pelicula.Duracion, pelicula.Genero);
        }
    
        public DataTable ListarPeliculas()
        {
            return objCDPelicula.ListarPeliculas();
        }
    
        public void ActualizarPelicula(string codigo, string nombre, string duracion, string genero)
        {
            objCDPelicula.ActualizarPelicula(int.Parse(codigo), nombre, 
                                             int.Parse(duracion), genero);
        }
    }

    public struct Pelicula
    {
        public string Codigo;
        public string Nombre;
        public uint Duracion;
        public string Genero;
    }
}
