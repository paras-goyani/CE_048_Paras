using System;
using calc;

namespace driver_prog
{
	public class my_driver_class
	{
		static void Main(string[] args)
		{
			calc_class a = new calc_class();
			int ans = a.addition(2, 3);
			Console.WriteLine("sum =" +ans);
			
			
			ans = a.multiplication(2, 3);
			Console.WriteLine("multiplication = "+ans);
			
		}
	}
}