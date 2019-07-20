namespace DemoStore.Clases
{
    public class ProductoImportado : Producto
    {
        public string PaisDeImportacion {get;set;}

        public override double VerPrecio()
        {
            var precioFinal = base.VerPrecio();
            precioFinal += (precioFinal*0.05);

            return precioFinal;
        }
    }
}