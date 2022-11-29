using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("子系統方法一");
        }
    }
    internal class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("子系統方法二");
        }
    }
    internal class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("子系統方法三");
        }
    }
    internal class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("子系統方法四");
        }
    }
}
