using System;
using lab1_addition;
namespace driver_prog
{
	public class my_driver_class
	{
		static void Main(string[] args)
		{
			lab1_addition_class c = new lab1_addition_class();
			int ans = c.addition(2, 3);
			Console.WriteLine(ans);
			Console.ReadKey();
		}
	}
}