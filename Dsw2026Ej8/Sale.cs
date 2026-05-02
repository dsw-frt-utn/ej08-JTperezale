using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal Monto { get; set; }

        public Sale(decimal monto)
        {
            Monto = monto;
        }

        public virtual decimal CalculateTotal()
        {
            return Monto;
        }
    }

    public class RetailSale : Sale
    {
        public RetailSale(decimal monto) : base(monto) { }

        public override decimal CalculateTotal()
        {
            return Monto; // sin descuento
        }
    }

    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal monto) : base(monto) { }

        public override decimal CalculateTotal()
        {
            return Monto * 0.90m; // 10% de descuento
        }
    }
}
