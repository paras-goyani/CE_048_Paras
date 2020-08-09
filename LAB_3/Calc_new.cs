using System;
using System.Reflection;

[assembly: AssemblyVersion("1.0.0.0")]
namespace calc
{
    public class calc_class
    {
        public int addition(int x, int y)
        {
			Console.WriteLine("this is new version");
            return x + y;
        }
		
		public int multiplication(int x, int y)
        {
			Console.WriteLine("this is new version");
            return x*y;
        }
    }
	
	
	
	
}