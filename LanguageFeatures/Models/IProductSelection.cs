namespace LanguageFeatures.Models
{
    public class IProductSelection
    {
       public IEnumerable<Product>? Products { get; }

       public IEnumerable<string>? Names => Products?.Select(p => p.Name);

    }
}
