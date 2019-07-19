using System;
using DemoStore.Clases;
using DemoStore.Enumeraciones;

namespace DemoStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto objetoProducto = new Producto();
            objetoProducto.Nombre = "Arroz";
            objetoProducto.Descripcion = "Arroz";
            objetoProducto.UnidadMedicion = Medida.Kilo;
            objetoProducto.AsignarPrecio(1000);

            var objetoProducto2 = new Producto();
            objetoProducto2.Nombre = "Aceite";
            objetoProducto2.Descripcion = "Aceite de oliva";
            objetoProducto2.UnidadMedicion = Medida.Unidad;
            objetoProducto2.AsignarPrecio(8500);

            Console.WriteLine(objetoProducto.VerPrecio());
            objetoProducto.AsignarPrecio(1200);
            Console.WriteLine(objetoProducto.VerPrecio());
        }
    }
}
