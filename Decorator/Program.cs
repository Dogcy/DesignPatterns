
using Decorator;
// 裝飾模式 Decorator
// 目的 可依照次序進行
/* 概念: 利用父類別達到此效果base.Operation();
 * 利用SetComponent對物件進行包裝 無須關心如何被填加至物件鍊中*/
ConcreteComponent c1 = new ConcreteComponent();
ConcreteDecoratorA  a1 = new ConcreteDecoratorA();
ConcreteDecoratorB b1 = new ConcreteDecoratorB();
// run b1 > run a1 > run c1
a1.SetComponent(c1);
b1.SetComponent(a1);
b1.Operation();
Console.Read();

classs3 c = new classs3();
c.Show();