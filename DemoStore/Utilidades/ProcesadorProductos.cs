using System.Text;
using DemoStore.Clases;

namespace DemoStore.Utilidades
{
    public static class ProcesadorProductos
    {
        public static string ProcesarProductos(Producto[] productos)
        {
            StringBuilder sb = new StringBuilder(); 
            
            for(var i=0;i<productos.Length;i++)
            {
                sb.AppendLine($"Producto:{productos[i].Nombre} - Precio {productos[i].VerPrecio()}");
            }

            return sb.ToString();
        }

        public static string ProcesarProductosImportados(ProductoImportado[] productos)
        {
            StringBuilder sb = new StringBuilder();
            for(var i=0;i<productos.Length;i++)
            {
                sb.AppendLine($"Producto:{productos[i].Nombre} - Precio {productos[i].VerPrecio()} - Pais de importación {productos[i].PaisDeImportacion}");
            }

            return sb.ToString();
        }

    }
}