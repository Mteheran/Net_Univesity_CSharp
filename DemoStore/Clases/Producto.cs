using System;
using DemoStore.Enumeraciones;

namespace DemoStore.Clases
{    
    public class Producto
    {
        public string Nombre {get; set;}

        private string _Descripcion;
        public string Descripcion 
        {
            set 
            {
                _Descripcion = value; 
            }
            get 
            {
                return _Descripcion;
            }
        }
        public Medida UnidadMedicion {get;set;}

        private double _Precio;
        private double Precio 
        {
            set 
            {
                _Precio = value;                 
            }
            get 
            {
                return Math.Round(_Precio, 2);
            }
        }

        private double Descuento {get;set;}   
        
        public void AsignarPrecio(double NuevoPrecio)
        {
            Precio = NuevoPrecio;
        }

        public void AsignarPrecio(double NuevoPrecio, double descuento)
        {
            Descuento = descuento;
            AsignarPrecio(NuevoPrecio);
        }

        public virtual double VerPrecio()
        {
            return (Precio - Descuento);
        }


    }


}