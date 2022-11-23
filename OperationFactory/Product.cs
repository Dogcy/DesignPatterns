using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationFactory
{
    internal class Product
    {

        public virtual string GetResult()
        {
            return "base Product";
        }
    }
    internal class ProductA : Product
    {
        public override string GetResult()
        {
            return "A Product";
        }
    }
    internal class ProductB : Product
    {
        public override string GetResult()
        {
            return "B Product";
        }
    }
    internal class ProductC : Product
    {
        public override string GetResult()
        {
            return "C Product";
        }
    }
}
