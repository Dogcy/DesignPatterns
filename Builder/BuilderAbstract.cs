using System;
namespace Builder
{
	public abstract class BuilderAbstract
	{
		public abstract void BuilderPartA();
		public abstract void BuilderPartB();
		public abstract  Product GetResult();
	}
}

