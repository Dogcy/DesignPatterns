using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryStrategy
{

    internal abstract class Strategy
    {
        public abstract void AlorithmInterFace();
    }
    internal class ConcreteStategyA : Strategy
    {
        public override void AlorithmInterFace()
        {
            Console.WriteLine("演算法A實現");
        }
    }
    class ConcreteStategyB : Strategy
    {
        public override void AlorithmInterFace()
        {
            Console.WriteLine("演算法B實現");
        }
    }
    class ConcreteStategyC : Strategy
    {
        public override void AlorithmInterFace()
        {
            Console.WriteLine("演算法c實現");
        }
    }
    /// <summary>
    /// 此處為策略模式
    /// </summary>
    internal class Context
    {
        Strategy strategy;
        public Context(Input input)
        {
            this.strategy = input switch
            {
                Input.A => new ConcreteStategyA(),
                Input.B => new ConcreteStategyB(),
                Input.C => new ConcreteStategyC()

            };
        }

        public void ContextInterface()
        {
            this.strategy.AlorithmInterFace();
        }
    }
    enum Input
    {
        A,
        B,
        C        
    }
}
