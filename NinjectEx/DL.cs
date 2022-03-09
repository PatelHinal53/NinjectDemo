using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectEx
{
    class DL : IProduct
    {
        public string InsertProduct()
        {
            string value = "Dependency injection using Ninject";
            Console.WriteLine(value);
            return value;
        }
    }
}
