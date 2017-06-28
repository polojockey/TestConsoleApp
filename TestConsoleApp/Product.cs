using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class Product:IProduct
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public void CheckPrice()
        {
            throw new NotImplementedException();
        }
    }
}
