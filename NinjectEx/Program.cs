using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Ninject;
using System.Text;
using System.Threading.Tasks;

namespace NinjectEx
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel _Kernel = new StandardKernel();
            _Kernel.Load(Assembly.GetExecutingAssembly());
            IProduct _objIpro = _Kernel.Get<IProduct>();
            BL objbl = new BL(_objIpro);
            objbl.Insert();
            Console.ReadLine();
        }
    }
}
