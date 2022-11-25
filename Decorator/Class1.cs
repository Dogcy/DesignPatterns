using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract internal class Class1
    {
        public abstract void Show();
    }

    abstract internal class Class2 : Class1
    {
        public override void Show()
        {
            Console.WriteLine("show class2");
        }
    }

    internal class classs3 : Class2
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("show class3");
        }
    }
}
