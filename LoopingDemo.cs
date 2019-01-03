using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Looping_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int whileCounter = 0;
            int doCounter = 0;

            // for loop sample
            Console.WriteLine("for loop");
            Console.WriteLine();

            for (int forCounter = 0; forCounter < 10; forCounter++)
            {
                Console.WriteLine("forCounter is at " + forCounter);
            }

            // while loop sample
            Console.WriteLine();
            Console.WriteLine("while loop");
            Console.WriteLine();

            while(whileCounter < 5)
            {
                Console.WriteLine("whileCounter is at " + whileCounter);
                whileCounter++;
            }

            // do-while sample
            Console.WriteLine();
            Console.WriteLine("do-while loop");
            Console.WriteLine();

            do
            {
                Console.WriteLine("doCounter is at " + doCounter);
                doCounter++;
            } while (doCounter < 5);

            // recursion sample
            Console.WriteLine();
            Console.WriteLine("recursion");
            Console.WriteLine();

            long value = Factorial(10);
            Console.WriteLine(value);
        }

        static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}