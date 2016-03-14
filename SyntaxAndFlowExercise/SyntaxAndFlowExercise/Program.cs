using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxAndFlowExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Average(100);
            //Harmonic(50000);
            ComputePI(20);

            Console.ReadLine();
        }


        static void Average(int number)
        {
            double sum = 0;
            double average = 0;

            for (int i = 1; i <= number; i++)
            {
                sum = i + sum;
                average = sum / i;
            }
            Console.WriteLine("sum {0} : average {1}", sum, average);
        }

        static void Harmonic(int number)
        {
            decimal harmonic = 0;

            for (decimal i = 1; i <= number; i++)
            {
                harmonic = harmonic + (1/i);
            }
            Console.WriteLine(harmonic);
        }

        static void ComputePI(double max)
        {
            for (int i = 1; i < max; i+=2)
            {
                if (i % 4 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
