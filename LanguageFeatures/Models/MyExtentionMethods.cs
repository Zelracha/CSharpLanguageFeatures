namespace LanguageFeatures.Models
{
    public static class MyExtentionMethods
    {
        public static decimal TotalPrices(this )
        {
            decimal total = 0;
            if (cartParam.products != null ) 
            {
                foreach(Product? prod in cartParam.products )
                {
                    total += prod?.Price ?? 0;
                }
            }
            return total;
        }
    }
}
