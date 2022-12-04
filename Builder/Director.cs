using System;
namespace Builder
{
	/// <summary>
	/// 
	/// </summary>
	public class Director
	{
		public void Construct(BuilderAbstract builder)
		{
			builder.BuilderPartA();
			builder.BuilderPartB();
		}
	}
}

