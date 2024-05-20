using System.Collections;
namespace LanguageFeatures.Models
{
    public class ShoppingCart : IEnumerable<Product?>
    {
        public IEnumerable<Product?>? products { get; set; }

        public IEnumerator<Product?> GetEnumerator() => products?.GetEnumerator() ?? Enumerable.Empty<Product?>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
