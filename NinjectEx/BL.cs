using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectEx
{
    class BL
    {
        IProduct objIpro;
        public BL (IProduct objIproduct)
        {
            objIpro = objIproduct;
        }
        public void Insert()
        {
            objIpro.InsertProduct();
        }
    }
}
