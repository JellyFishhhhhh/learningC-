using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace learningC_
{
	public class FibonacciSeries
	{
		public int getFib(int i)
		{
			if (i == 0)
			{
				return 0;
			}
			else if(i == 1)
			{
				return 1;
			}
			return getFib(i-1) + getFib(i-2);
			
		}

	//	static void Main(string[] args)
	//	{
	//		FibonacciSeries f = new FibonacciSeries();
	//		int number, result;
	//		Console.Write("Enter i-th number of the element: ");
	//		number = int.Parse(Console.ReadLine());
	//		result = f.getFib(number-1);
 //           Console.Write(result);
 //       }
	}
}

