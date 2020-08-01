using System;
namespace driver_prog
{
	public class my_driver_class
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter number1 = ");
			double number1=double.Parse(Console.ReadLine());
			
			Console.WriteLine("\nEnter number2 = ");
			double number2=double.Parse(Console.ReadLine());
			double sum=number1+number2;
			
			Console.WriteLine("sum = "+sum);
			//Console.ReadKey();
		}
	}
}