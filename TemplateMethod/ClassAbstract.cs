using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class ClassAbstract
    {
        internal abstract void PrimitiveOperation1();
        internal abstract void PrimitiveOperation2();
        internal void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("finish");

        }
    }
}
