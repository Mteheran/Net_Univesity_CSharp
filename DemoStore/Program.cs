using System;
using DemoStore.Clases;
using DemoStore.Enumeraciones;
using DemoStore.Utilidades;

namespace DemoStore
{
    class Program
    {
        static void Main(string[] args)
        {  
            Tienda miTienda = new Tienda();
            
            Console.WriteLine($"Bienvenido a {miTienda.Nombre}");
            Console.WriteLine("Nuestros productos disponibles");
            Console.WriteLine(ProcesadorProductos.ProcesarProductos(miTienda.ListaDeProductos));
            Console.WriteLine("Nuestros productos Importados disponibles");
            Console.WriteLine(ProcesadorProductos.ProcesarProductosImportados(miTienda.ListaDeProductosImportados));
        }
    }
}
