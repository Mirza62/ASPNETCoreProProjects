using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public static class ExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;

            foreach (Product product in products)
            {
                total += product?.Price ?? 0;
            }
            return total;
        }

        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> productEnum, decimal minimumPrice)
        {
            foreach (Product product in productEnum)
            {
                if ((product?.Price ?? 0) >= minimumPrice)
                {
                    yield return product;
                }
            }
        }

        public static IEnumerable<Product> FilterByName(this IEnumerable<Product> productEnum,char firstLetter)
        {
            foreach (Product product in productEnum)
            {
                if (product?.Name?[0] == firstLetter)
                {
                    yield return product;
                }
            }
        }
    }
}
