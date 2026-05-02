using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public static class Extensions
    {
        public static string ToProductCode(this string codigo)
        {
            if (codigo == null)
                return "SIN-CODIGO";

            return codigo
                .Trim()
                .ToUpper()
                .Replace(" ", "-");
        }
    }
}