using DemoStore.Enumeraciones;

namespace DemoStore.Clases
{    
    public class Producto
    {
        public string Nombre;
        public string Descripcion;
        public Medida UnidadMedicion;
        private double Precio;    
        public void AsignarPrecio(double NuevoPrecio)
        {
            Precio = NuevoPrecio;
        }
        public double VerPrecio()
        {
            return Precio;
        }


    }


}