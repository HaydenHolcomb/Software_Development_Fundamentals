using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Decision_Demo
{
    class Progam
    {
        static void Main(string[] args)
        {
            int condition1;
            int condition2;
            int switchCondition;

            // if sample
            condition1 = 1;
            if (condition1 == 1)
            {
                Console.WriteLine("comparison evaluated to true.");
            }

            Console.WriteLine("This executes after the if, regardless of condition.");

            // if-else sample
            condition1 = 3;
            if (condition1 == 1)
            {
                Console.WriteLine("comparison evaluated to true.");
            }
            else
            {
                Console.WriteLine("comparison evaluated to false.");
            }

            // if-else-if sample
            condition1 = 1;
            condition2 = 2;
            if (condition1 == 1)
            {
                Console.WriteLine("condition1 is true.");
            }
            else if (condition2 == 2)
            {
                Console.WriteLine("condition2 is true.");
            }
            else
            {
                Console.WriteLine("neither condition is true.");
            }

            // switch sample
            switchCondition = 3;

            switch (switchCondition)
            {
                case 1:
                    Console.WriteLine("Value is 1");
                    break;
                
                case 2:
                    Console.WriteLine("Value is 2");
                    break;

                case 3:
                    Console.WriteLine("Value is 3");
                    break;
                
                default:
                    Console.WriteLine("Value is " + switchCondition);
                    break;
            }
        }
    }
}