using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id ="602d2149e73f2a39290b47f5",
                    Name ="Iphone x",
                    Summary ="This phone is the companys biggest change to its flagship smartphone in years",
                    Description = "Lorem ipsum dolor sit amet",
                    ImageFile = "product-1.png",
                    Price = 950.00M,
                    Category ="Smart Phone"
                },

                new Product()
               {
                 Id = "602d2149e73f2a39690b47f6",
                 Name = "Samsung Galaxy S21",
                Summary = "The Galaxy S21 offers a sleek design with advanced camera features.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                ImageFile = "product-2.png",
                Price = 799.99M,
                Category = "Smart Phone"
              },

                new Product()
            {
               Id = "602d2149e753f2a3990b47f7",
               Name = "MacBook Pro 16\"",
               Summary = "The MacBook Pro 16\" delivers power and performance for professionals.",
               Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
               ImageFile = "product-3.png",
               Price = 2399.00M,
              Category = "Laptop"
            },

              new Product()
            {
              Id = "602d21494e73f2a3990b47f8",
              Name = "Sony WH-1000XM4",
              Summary = "Sony's flagship noise-canceling headphones with premium sound.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis consectetur sem.",
              ImageFile = "product-4.png",
              Price = 349.99M,
              Category = "Headphones"
            },

             new Product()
             {
               Id = "602d2149e73f2a39190b47f9",
               Name = "Dell XPS 13",
               Summary = "The Dell XPS 13 is known for its sleek design, excellent display, and powerful performance.",
               Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce sit amet ante ut nulla vehicula laoreet.",
               ImageFile = "product-5.png",
               Price = 1299.99M,
               Category = "Laptop"
             }
            };

        }
    }
}
