using System.Collections.Generic;
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
                    sb.AppendLine($"Código: {misProductos[i].Codigo} - Producto:{misProductos[i].Nombre} - Precio {misProductos[i].VerPrecio()} - Pais de importación { ((ProductoImportado)misProductos[i]).PaisDeImportacion}");
                }
                else
                { 
                    sb.AppendLine($"Código: {misProductos[i].Codigo} - Producto:{misProductos[i].Nombre} - Precio {misProductos[i].VerPrecio()}");

                }
               
            }

            return sb.ToString();
        }

        public static ProductoBase ObtenerProducto(string codigoProducto, Producto[] productos, ProductoImportado[] productoImportados)
        {
            List<ProductoBase> listaProducto = new List<ProductoBase>();
            listaProducto.AddRange(productos);
            listaProducto.AddRange(productoImportados);

            foreach(var item in listaProducto)
            {
                if(item.Codigo == codigoProducto)
                {
                    return item;
                }
            }

            return null;
        }

    }
}