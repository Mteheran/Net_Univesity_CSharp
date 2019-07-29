using System.Collections.Generic;
using DemoStore.Enumeraciones;
using DemoStore.Interfaces;

namespace DemoStore.Clases
{
    public class Tienda : ITienda
    {
        public string Nombre {get; set;} = "La tienda de NetUniversity";
        public string Direccion {get;set;} = "Calle 123 #50-60";
        public Producto[] ListaDeProductos {get; set;}
        public ProductoImportado[] ListaDeProductosImportados {get;set;}

        public Tienda()
        {             
            ListaDeProductos = ObtenerProductos().ToArray(); 
            ListaDeProductosImportados = ObtenerProductosImportados().ToArray();     
        }

        private List<Producto> ObtenerProductos()
        {
            List<Producto> ListaProducto = new List<Producto>();

            Producto objetoProducto = new Producto();
            objetoProducto.Codigo = "P01";
            objetoProducto.Nombre = "Arroz";
            objetoProducto.Descripcion = "Arroz";
            objetoProducto.UnidadMedicion = Medida.Kilo;
            objetoProducto.AsignarPrecio(1000.586);

            ListaProducto.Add(objetoProducto);

            var objetoProducto2 = new Producto();
            objetoProducto2.Codigo = "P02";
            objetoProducto2.Nombre = "Aceite";
            objetoProducto2.Descripcion = "Aceite de oliva";
            objetoProducto2.UnidadMedicion = Medida.Unidad;
            objetoProducto2.AsignarPrecio(8500, 800);

            ListaProducto.Add(objetoProducto2);

            return ListaProducto;
        }

        private List<ProductoImportado> ObtenerProductosImportados()
        {
            List<ProductoImportado> listaImportados = new List<ProductoImportado>();

            ProductoImportado productoImportado = new ProductoImportado();
            productoImportado.Codigo = "PI01";
            productoImportado.Nombre = "Uvas";
            productoImportado.UnidadMedicion = Medida.Kilo;
            productoImportado.AsignarPrecio(1500);
            productoImportado.PaisDeImportacion = "Argentina";

            listaImportados.Add(productoImportado);

            ProductoImportado productoImportado2 = new ProductoImportado();
            productoImportado2.Codigo = "PI02";
            productoImportado2.Nombre = "Manzana";
            productoImportado2.UnidadMedicion = Medida.Kilo;
            productoImportado2.AsignarPrecio(3250);
            productoImportado2.PaisDeImportacion = "Uruguay";

            listaImportados.Add(productoImportado2);

            return listaImportados;

        }

    }
}