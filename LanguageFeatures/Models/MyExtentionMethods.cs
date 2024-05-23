namespace LanguageFeatures.Models
{
    public static class MyExtentionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product?> products)
        {
            decimal total = 0;
            foreach (Product? prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }

        // Filtering Extention Methods
        public static IEnumerable<Product?> FilterByPrice(this IEnumerable<Product?> productEnum, decimal minimumPrice) 
        {
            //Iterate through each product provided in the collection
            foreach (Product? prod in productEnum)
            {
                // check if the product is not null and the price is greater or equal to the minimum price
                if ((prod?.Price ?? 0) >= minimumPrice)
                {
                    //if the price meets the condition, then yield
                    yield return prod;  
                }
            }
        } 

        // Filter the name

        public static IEnumerable<Product?> FilterByName(this IEnumerable<Product?> productEnum, char firstLetter)
        {
            foreach (Product? prod in productEnum)
            {
                if (prod?.Name?[0] == firstLetter)
                {
                    yield return prod;
                }
            }
        }

    }
}
