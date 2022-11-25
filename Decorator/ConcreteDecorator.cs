using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class ConcreteDecoratorA : DecoratorAbstract
    {
        private string addedState; // 這個類別獨有的功能 分別於ConcreteDecoratorA
        public override void Operation()
        {
            base.Operation();
            this.addedState = "New State";
            Console.WriteLine("具體裝飾物件A的操作");

        }

    }
    internal class ConcreteDecoratorB : DecoratorAbstract
    {


        // 開始執行邏輯
        public override void Operation()
        {
            base.Operation(); // 執行DecoratorAbstract層的 Operation來達成目的
            AddBehavior();
            Console.WriteLine("具體物件操作B");


        }
        private void AddBehavior()
        {


        }
    }
}
