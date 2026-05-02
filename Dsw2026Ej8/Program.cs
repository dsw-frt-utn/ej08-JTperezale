namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var helper = new ProductHelper();

            Console.WriteLine(helper.ObtenerEtiquetaProducto(1001, "Coca Cola 500ml", 1250.99m));
            Console.WriteLine(helper.ObtenerEtiquetaProducto(1, "Agua mineral", 500m));
            Console.WriteLine(helper.ObtenerEtiquetaProducto(7, "Auriculares", 12999.99m));
        }
    }
}