using System.Text;
using DemoStore.Clases;

namespace DemoStore.Utilidades
{
    public static class ProcesadorProductos
    {
        public static string ProcesarProductos(ProductoBase[] productos)
        {
            StringBuilder sb = new StringBuilder(); 
            
            for(var i=0;i<productos.Length;i++)
            {
                if(productos[i] is ProductoImportado)
                {
                    sb.AppendLine($"Producto:{productos[i].Nombre} - Precio {productos[i].VerPrecio()} - Pais de importación { ((ProductoImportado)productos[i]).PaisDeImportacion}");
                }
                else
                { 
                    sb.AppendLine($"Producto:{productos[i].Nombre} - Precio {productos[i].VerPrecio()}");

                }
               
            }

            return sb.ToString();
        }

    }
}