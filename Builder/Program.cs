// Builder (建造者模式)
using Builder;

var x = 1%3;
Console.WriteLine(x);

Console.Read();
Director director = new Director();
 BuilderAbstract b1 = new ConcreteBuilder1();
BuilderAbstract b2 = new ConcreteBuilder2();
director.Construct(b1);
Product p1 = b1.GetResult();
p1.Show();

director.Construct(b2);
Product p2 = b2.GetResult();
p2.Show();