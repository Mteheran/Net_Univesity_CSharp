namespace DemoStore.Clases
{
    public class ProductoImportado : ProductoBase
    {
        public string PaisDeImportacion {get;set;}

        public override double VerPrecio()
        {
            var precioFinal = Precio;
            precioFinal += (precioFinal*0.05);

            return precioFinal;
        }
    }
}