using System;
using DemoStore.Clases;

namespace DemoStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto objetoProducto = new Producto();
            objetoProducto.Nombre = "Arroz";

            var objetoProducto2 = new Producto();
            objetoProducto2.Nombre = "Aceite";

            Console.WriteLine(objetoProducto.Nombre);
            Console.WriteLine(objetoProducto2.Nombre);
        }
    }
}
