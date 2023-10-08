using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.ISPGoodAndBad
{
      public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public interface IReadRepository
    {
        List<Product> GetAll();

        Product GetById(int id);
    }


    public interface IWriteRepository
    {
        Product Create(Product p);
        Product Update(Product p);
        Product Delete(Product p);
    }

}
