using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{ 
    internal class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("物件操作");
        }
    }
}
