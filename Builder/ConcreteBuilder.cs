using System;
namespace Builder
{
	internal class ConcreteBuilder1: BuilderAbstract
	{
        private Product product = new Product();
        public override void BuilderPartA()
        {
            product.Add("零件a1");
        }
        public override void BuilderPartB()
        {
            product.Add("零件b1");
        }
        public override Product GetResult()
        {
            return product;
        }
    }

	public class ConcreteBuilder2:BuilderAbstract
	{
        private Product product = new Product();
        public override void BuilderPartA()
        {
            product.Add("零件b1");
        }
        public override void BuilderPartB()
        {
            product.Add("零件b2");
        }
        public override Product GetResult()
        {
            return product;
        }
    }
}

