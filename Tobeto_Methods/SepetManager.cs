using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto_Methods
{
    public class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name+" adlı ürün sepete eklendi.");
        }
        public void Add2(string name,string description,double price,int stock)
        {
            Console.WriteLine(name+" adlı ürün sepete eklendi.");
        }
    }
}
