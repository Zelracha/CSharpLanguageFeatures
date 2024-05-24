using System.Collections;
namespace LanguageFeatures.Models
{
    public class ShoppingCart : IProductSelection
    {
        // Implement an interface 
        private List<Product> product = new();

        public  ShoppingCart(params Product[] prods) 
        {
            product.AddRange(prods);
        }

        public new IEnumerable<Product>? Products { get => product; }

        public IEnumerable<Product?>? products { get; set; }

        public IEnumerator<Product?> GetEnumerator() => products?.GetEnumerator() ?? Enumerable.Empty<Product?>().GetEnumerator();

        

    }
}
