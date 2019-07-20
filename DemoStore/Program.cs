using System;
using DemoStore.Clases;
using DemoStore.Enumeraciones;

namespace DemoStore
{
    class Program
    {
        static void Main(string[] args)
        {           
            void ImprimirProductos(Producto[] productos)
            {
                for(var i=0;i<productos.Length;i++)
                {
                    Console.WriteLine($"Producto:{productos[i].Nombre} - Precio {productos[i].VerPrecio()}");
                }
            }

            void ImprimirProductosImportados(ProductoImportado[] productos)
            {
                for(var i=0;i<productos.Length;i++)
                {
                    Console.WriteLine($"Producto:{productos[i].Nombre} - Precio {productos[i].VerPrecio()} - Pais de importación {productos[i].PaisDeImportacion}");
                }
            }

            Tienda miTienda = new Tienda();

            Console.WriteLine($"Bienvenido a {miTienda.Nombre}");
            Console.WriteLine("Nuestros productos disponibles");
            ImprimirProductos(miTienda.ListaDeProductos);
            Console.WriteLine("Nuestros productos Importados disponibles");
            ImprimirProductosImportados(miTienda.ListaDeProductosImportados);
        }
    }
}
