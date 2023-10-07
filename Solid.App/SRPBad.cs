using System;
using System.Collections.Generic;
using System.Linq;

namespace Solid.App.SRP.Bad
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static List<Product> ProductList = new List<Product>();

        public List<Product> GetProductsList => ProductList;

        public Product()
        {
            ProductList = new List<Product>
            {
                new Product { Id = 1, Name = "Product1" },
                new Product { Id = 2, Name = "Product2" },
                new Product { Id = 3, Name = "Product3" },
                new Product { Id = 4, Name = "Product4" },
                new Product { Id = 5, Name = "Product5" }
            };
        }

        public void SaveOrUpdate(Product product)
        {
            var hasProduct = ProductList.Any(p => p.Id == product.Id);

            if (!hasProduct)
            {
                ProductList.Add(product);
            }
            else
            {
                var index = ProductList.FindIndex(p => p.Id == product.Id);

                ProductList[index] = product;
            }
        }

        public void Delete(int id)
        {
            var product = ProductList.Find(p => p.Id == id);

            if (product != null)
            {
                ProductList.Remove(product);
            }
        }

        public void WriteConsole()
        {
            ProductList.ForEach(x =>
            {
                Console.WriteLine($"Id: {x.Id} - Name : {x.Name}");
            });
        }
    }
}
