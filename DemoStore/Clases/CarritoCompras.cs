using System.Collections.Generic;
using System.Text;

namespace DemoStore.Clases
{
    public class CarritoCompras
    {
        public List<CarritoComprasArticulo> ListaDeProductosSeleccionados {get;set;} = new List<CarritoComprasArticulo>();

        public void AgregarCarritoComprasArticulo(CarritoComprasArticulo nuevoArticulo)
        {
            ListaDeProductosSeleccionados.Add(nuevoArticulo);
        }

        public string ProcesarCompra()
        {
            double total = 0;
            StringBuilder sb = new StringBuilder();

            foreach(var item in ListaDeProductosSeleccionados)
            {
                    sb.AppendLine($"{item.ProductoSeleccionado.Nombre} - {item.Cantidad} - {item.ProductoSeleccionado.VerPrecio() * item.Cantidad}");
                    total+= (item.Cantidad * item.ProductoSeleccionado.VerPrecio()); 
            }

            sb.AppendLine($"Su total fue {total}");

            return sb.ToString();

        }

    }
}