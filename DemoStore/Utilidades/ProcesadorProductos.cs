using System.Text;
using DemoStore.Clases;

namespace DemoStore.Utilidades
{
    public static class ProcesadorProductos
    {
        public static string ProcesarProductos<T>(T productos)
        {
            StringBuilder sb = new StringBuilder(); 

            var misProductos = productos as ProductoBase[];
            
            for(var i=0;i<misProductos.Length;i++)
            {
                if(misProductos[i] is ProductoImportado)
                {
                    sb.AppendLine($"Producto:{misProductos[i].Nombre} - Precio {misProductos[i].VerPrecio()} - Pais de importación { ((ProductoImportado)misProductos[i]).PaisDeImportacion}");
                }
                else
                { 
                    sb.AppendLine($"Producto:{misProductos[i].Nombre} - Precio {misProductos[i].VerPrecio()}");

                }
               
            }

            return sb.ToString();
        }

    }
}