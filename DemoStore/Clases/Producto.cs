using System;
using DemoStore.Enumeraciones;

namespace DemoStore.Clases
{    
    public class Producto : ProductoBase
    {
        public override double VerPrecio()
        {
            return (Precio - Descuento);
        }

    }


}