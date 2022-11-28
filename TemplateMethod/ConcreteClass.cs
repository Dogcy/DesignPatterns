using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class ConcreteClassA : ClassAbstract
    {
        internal override void PrimitiveOperation1()
        {
            Console.WriteLine("具體類別A 方法1實現");

        }
        internal override void PrimitiveOperation2()
        {
            Console.WriteLine("具體類別A 方法2實現" + Answer());

        }
        protected virtual string Answer()
        {
            return "hi";
        }
    }
    internal class ConcreteClassB : ClassAbstract
    {
        internal override void PrimitiveOperation1()
        {
            Console.WriteLine("具體類別B 方法1實現");

        }
        internal override void PrimitiveOperation2()
        {
            Console.WriteLine("具體類別B 方法2實現");

        }
    }
    internal class ConcreteClassc : ConcreteClassA
    {
        protected override string Answer()
        {
            return "ff";
        }
    }
}
