using System;
using DemoStore.Clases;
using DemoStore.Enumeraciones;
using DemoStore.Utilidades;
using DemoStore.Interfaces;

namespace DemoStore
{
    class Program
    {
        static void Main(string[] args)
        {  
            ITienda miTienda = Fabricas.FabricaTienda.ObtenerTienda(TipoTienda.TiendaCentro);
                       
            Console.WriteLine($"Bienvenido a {miTienda.Nombre}");
            Console.WriteLine("Nuestros productos disponibles");
            Console.WriteLine(ProcesadorProductos.ProcesarProductos<ProductoBase[]>(miTienda.ListaDeProductos));
            Console.WriteLine("Nuestros productos Importados disponibles");
            Console.WriteLine(ProcesadorProductos.ProcesarProductos<ProductoImportado[]>(miTienda.ListaDeProductosImportados));
        }
    }
}
