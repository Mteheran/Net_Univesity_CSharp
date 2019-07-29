using System;
using DemoStore.Clases;
using DemoStore.Enumeraciones;
using DemoStore.Utilidades;
using DemoStore.Interfaces;
using System.Net;

namespace DemoStore
{
    class Program
    {
        static void Main(string[] args)
        {  
            ITienda miTienda = Fabricas.FabricaTienda.ObtenerTienda(TipoTienda.Tienda);
            CarritoCompras MiCarrito = new CarritoCompras();

            Console.WriteLine($"Hola {Dns.GetHostName()} - {DateTime.Now}");
            Console.WriteLine($"Bienvenido a {miTienda.Nombre}");
            Console.WriteLine("Nuestros productos disponibles");
            TiendaLog.GuardarEnLog("Se abre la aplicación");
            while(true)
            {
                Console.WriteLine(ProcesadorProductos.ProcesarProductos<ProductoBase[]>(miTienda.ListaDeProductos));
                Console.WriteLine("Nuestros productos Importados disponibles");
                Console.WriteLine(ProcesadorProductos.ProcesarProductos<ProductoImportado[]>(miTienda.ListaDeProductosImportados));
                Console.WriteLine("Escoja producto o ingresa * para terminar");
                var productoEscogido = Console.ReadLine();

                if(productoEscogido == "*")
                {
                    Console.WriteLine("Su compra ha sido exitosa");
                    Console.WriteLine(MiCarrito.ProcesarCompra());
                    MiCarrito.ListaDeProductosSeleccionados.Clear();
                    TiendaLog.GuardarEnLog("Compra exitosa, carrito reiniciado");
                }
                else
                {
                    Console.WriteLine("Escriba la cantidad");
                    var cantidadEscogida = Console.ReadLine();

                    CarritoComprasArticulo articulo = new CarritoComprasArticulo();
                    articulo.Cantidad = int.Parse(cantidadEscogida.ToString());
                    articulo.ProductoSeleccionado = ProcesadorProductos.ObtenerProducto(productoEscogido.ToString(), miTienda.ListaDeProductos, miTienda.ListaDeProductosImportados);


                    MiCarrito.AgregarCarritoComprasArticulo(articulo);

                    TiendaLog.GuardarEnLog($"Se agrega producto al carrito: {articulo.ProductoSeleccionado.Codigo}");
                }

            }
        }
    }
}
