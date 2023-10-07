using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.SRP.Good
{
    
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }

     public class ProductRepository
    {

        private static List<Product> ProductList = new List<Product>();

        public List<Product> GetProducts => ProductList;

        public ProductRepository()
        {
            ProductList = new()
            {
                new(){Id=1,Name="Product1"},
                    new(){Id=2,Name="Product2"},
                        new(){Id=3,Name="Product3"},
                            new(){Id=4,Name="Product4"},
                                new(){Id=5,Name="Product5"}
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

    }

    public class ProductPresenter
    {
        public void WriteConsole(List<Product> ProductList)
        {
            ProductList.ForEach(x => {
                Console.WriteLine($"Id: {x.Id} - Name : {x.Name}");
            });
        }

    }
}
