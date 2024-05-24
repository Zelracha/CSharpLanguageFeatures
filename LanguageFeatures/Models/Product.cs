﻿namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public decimal? Price { get; set; }

        public bool NameBeginsWithB => Name?[0] == 'B';

        public static Product?[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Price = 275M
            };
            Product lifeJacket = new Product
            {
                Name = "Life Jacket",
                Price = 300M
            };

            return new Product?[] {kayak, lifeJacket, null};
        }
    }
}
