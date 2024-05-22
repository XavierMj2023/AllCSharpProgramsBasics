using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCSharpBasicsPractiseForIndecomm.BasicProgramForInterviews.BasicPrograms
{
    public class FibonacciSeries
    {
        public static void PrintFibonacciSeries(int n)
        {
            int first = 0, second = 1, next;

            if (n < 1)
                return;

            Console.Write(first + " ");

            for (int i = 1; i < n; i++)
            {
                Console.Write(second + " ");
                next = first + second;
                first = second;
                second = next;
            }
        }
        public static void FibonacciSeriesProgram()
        {
            int n = 10; // Number of terms in the Fibonacci series
            PrintFibonacciSeries(n);
        }
    }
}
