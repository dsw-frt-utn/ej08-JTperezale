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

            // Problema 3
            var p3 = new Problema3();
            var producto = new Product("Descripcion original");
            Console.WriteLine(p3.CompararCopias(5, producto));

            // Problema 4
            var p4 = new Problema4();
            Console.WriteLine(p4.CalcularPromedio(8, 6, 10));       // promedio de 3 notas: 8
            Console.WriteLine(p4.CalcularPromedio(8, null, 10));    // promedio de 2 notas: 9
            Console.WriteLine(p4.CalcularPromedio(null, null, null)); // todas null: 0
            Console.WriteLine(p4.CalcularPromedio(8, -1, 10));      // -1 se ignora: promedio 9
            Console.WriteLine(p4.CalcularPromedio(8, 11, 10));      // 11 se ignora: promedio 9

            // Problema 5
            var p5 = new Problema5();
            var ventaMinorista = new RetailSale(1000m);
            var ventaMayorista = new WholesaleSale(1000m);

            Console.WriteLine(p5.ObtenerImporteFinal(ventaMinorista));  // 1000
            Console.WriteLine(p5.ObtenerImporteFinal(ventaMayorista));  // 900
        }
    }
}