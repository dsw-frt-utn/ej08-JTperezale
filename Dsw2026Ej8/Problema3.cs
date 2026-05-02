using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            // 1. Copiar originalValue en una variable local
            int copia = originalValue;

            // 2. Incrementar solo la copia
            copia++;

            // 3. Copiar la referencia de product en otra variable local
            Product productoCopia = product;

            // 4. Modificar la descripción del producto copiado
            productoCopia.SetDescription("Descripcion modificada");

            // 5. Retornar la cadena con el formato
            return $"{originalValue}-{copia}-{product.Description}";
        }
    }
}
