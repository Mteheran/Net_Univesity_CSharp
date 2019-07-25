using DemoStore.Enumeraciones;
using DemoStore.Interfaces;
using DemoStore.Clases;

namespace DemoStore.Fabricas
{
    public static class FabricaTienda
    {
        public static ITienda ObtenerTienda(TipoTienda tipoTienda)
        {
            switch(tipoTienda)
            {
                case TipoTienda.Tienda:
                return new Tienda();
                case TipoTienda.TiendaCentro:
                return new TiendaCentro();
            }

            return null;
        }

    }
}