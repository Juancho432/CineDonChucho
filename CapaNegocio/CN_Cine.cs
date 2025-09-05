
using System;

namespace CapaNegocio
{
    public class CN_Cine
    {
        public void BuscarPelicula()
        {

        }

        public void RegistrarPelicula(Pelicula pelicula)
        {
            // Error al guardar en la BBDD
            if (false)
            {
                throw new CN_Excepciones.RegistroFallido();
            }
        }
    }

    public struct Pelicula
    {
        public string Codigo;
        public string Nombre;
        public uint Duracion;
        public string Genero;
        public double Precio;
        public DateTime Funcion;
    }
}
