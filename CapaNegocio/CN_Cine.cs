
using System;
using System.Data;
using CapaDatos;


namespace CapaNegocio
{
    public class CN_Cine
    {

        private readonly CD_Pelicula objCDPelicula = new CD_Pelicula();
        private readonly CD_Venta objCDVenta = new CD_Venta();

        public Pelicula BuscarPelicula(string codigo)
        {
            DataRow result = objCDPelicula.BuscarPelicula(int.Parse(codigo));
            return new Pelicula
            {
                Codigo = result["Codigo"].ToString(),
                Nombre = result["Nombre"].ToString(),
                Duracion = uint.Parse(result["Duracion"].ToString()),
                Genero = result["Genero"].ToString(),
                Precio = decimal.Parse(result["PrecioBoleta"].ToString()),
                Fecha = DateTime.Parse(result["FechaHoraFuncion"].ToString())
            };
        }

        public void RegistrarPelicula(Pelicula pelicula)
        {
            objCDPelicula.InsertarPelicula(pelicula.Nombre, (int)pelicula.Duracion, 
                pelicula.Genero, pelicula.Precio, pelicula.Fecha);
        }
    
        public DataTable ListarPeliculas()
        {
            return objCDPelicula.ListarPeliculas();
        }
    
        public void ActualizarPelicula(int codigo, string nombre, int duracion, 
            string genero, decimal precio, DateTime fecha)
        {
            objCDPelicula.ActualizarPelicula(codigo, nombre,
                duracion, genero, precio, fecha);
        }

        public void VenderBoletas(Pelicula pelicula, int cantidad)
        {
            objCDVenta.InsertarVenta(int.Parse(pelicula.Codigo), cantidad, pelicula.Precio, pelicula.Fecha);
        }
    }

    public struct Pelicula
    {
        public string Codigo;
        public string Nombre;
        public uint Duracion;
        public string Genero;
        public decimal Precio;
        public DateTime Fecha;
    }
}
