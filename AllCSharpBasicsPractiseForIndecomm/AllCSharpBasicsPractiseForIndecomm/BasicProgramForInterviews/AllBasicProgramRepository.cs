using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllCSharpBasicsPractiseForIndecomm.BasicProgramForInterviews.BasicPrograms;

namespace AllCSharpBasicsPractiseForIndecomm.BasicProgramForInterviews
{
    public class AllBasicProgramRepository
	{
		public static void SendMessage()
		{
			int n;

			Console.WriteLine("1. Fibonacci Series");

			Console.WriteLine("Enter The Number for Operation:");
			n = int.Parse(Console.ReadLine());

			switch (n)
			{
				case 1: FibonacciSeries.FibonacciSeriesProgram(); break;

			}
		}
	}
}
