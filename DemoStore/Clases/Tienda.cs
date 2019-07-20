using DemoStore.Enumeraciones;

namespace DemoStore.Clases
{
    public class Tienda
    {
        public string Nombre {get; set;} = "La tienda de NetUniversity";
        public Producto[] ListaDeProductos {get; set;}
        public ProductoImportado[] ListaDeProductosImportados {get;set;}

        public Tienda()
        {             
            ListaDeProductos = ObtenerProductos(); 
            ListaDeProductosImportados = ObtenerProductosImportados();     
        }

        private Producto[] ObtenerProductos()
        {
            Producto[] ListaProducto = new Producto[2];

            Producto objetoProducto = new Producto();
            objetoProducto.Nombre = "Arroz";
            objetoProducto.Descripcion = "Arroz";
            objetoProducto.UnidadMedicion = Medida.Kilo;
            objetoProducto.AsignarPrecio(1000.586);

            var objetoProducto2 = new Producto();
            objetoProducto2.Nombre = "Aceite";
            objetoProducto2.Descripcion = "Aceite de oliva";
            objetoProducto2.UnidadMedicion = Medida.Unidad;
            objetoProducto2.AsignarPrecio(8500, 800);

            ListaProducto[0] = objetoProducto;
            ListaProducto[1] = objetoProducto2;

            return ListaProducto;
        }

        private ProductoImportado[] ObtenerProductosImportados()
        {
            ProductoImportado[] listaImportados = new ProductoImportado[2];

            ProductoImportado productoImportado = new ProductoImportado();
            productoImportado.Nombre = "Uvas";
            productoImportado.UnidadMedicion = Medida.Kilo;
            productoImportado.AsignarPrecio(1500);
            productoImportado.PaisDeImportacion = "Argentina";

            listaImportados[0] = productoImportado;

            ProductoImportado productoImportado2 = new ProductoImportado();
            productoImportado2.Nombre = "Manzana";
            productoImportado2.UnidadMedicion = Medida.Kilo;
            productoImportado2.AsignarPrecio(3250);
            productoImportado2.PaisDeImportacion = "Uruguay";

            listaImportados[1] = productoImportado2;

            return listaImportados;

        }

    }
}