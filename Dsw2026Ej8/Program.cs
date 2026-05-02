namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problema 1
            var helper = new ProductHelper();
            Console.WriteLine(helper.ObtenerEtiquetaProducto(1001, "Coca Cola 500ml", 1250.99m));
            Console.WriteLine(helper.ObtenerEtiquetaProducto(1, "Agua mineral", 500m));
            Console.WriteLine(helper.ObtenerEtiquetaProducto(7, "Auriculares", 12999.99m));

            Console.WriteLine("---");

            // Problema 2
            var p2 = new Problema2();
            Console.WriteLine(p2.CrearResumenVenta(1001, "Coca Cola", 5, 1250.99m));
            Console.WriteLine(p2.CrearResumenVenta(2002, "Agua mineral", -1, 500m));
            Console.WriteLine(p2.CrearResumenVenta(3003, "Auriculares", 2, 12999.99m));
        }
    }
}