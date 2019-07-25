using DemoStore.Clases;
namespace DemoStore.Interfaces
{
    public interface ITienda
    {
        string Nombre {get; set;}
        string Direccion {get;set;}
        Producto[] ListaDeProductos {get; set;}
        ProductoImportado[] ListaDeProductosImportados {get; set;}

    }
}