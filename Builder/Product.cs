using System;
namespace Builder
{
	public class Product
	{
		IList<string> parts = new List<string>();
		public  void Add (string part)
		{
			this.parts.Add(part);
		}
		public void Show()
		{
			Console.WriteLine("\n 產品 建立-----");
			foreach(string part in this.parts)
			{
				Console.WriteLine(part);
			}
		}
	}
}
