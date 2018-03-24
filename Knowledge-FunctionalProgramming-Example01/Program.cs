using System;
using System.Linq;


namespace FunctionalProgramming.Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            reportProjectName(); 

            int result = sumOfSquaresOf10FirstIntegers();
            reportResult("Sum of squares of the first ten integer numbers", result);

            waitForKeyPress();
        }


        private static int square(int n)
        {
            return n * n;
        }


        private static int sumOfSquaresOf10FirstIntegers()
        {
            // .Range:  Creates a list of first ten integer numbers (1, 2, ..., 10); 
            // .Select: Gets a list comprised of the corresponding squares of those numbers; 
            // .Sum:    Computes the sum of those squares.
            return Enumerable.Range(1, 10)
                             .Select(square)
                             .Sum();
        }


        private static void reportProjectName()
        {
            Console.WriteLine("Knowledge-FunctionalProgramming-Example01\n");
        }

        private static void reportResult(string message, int result)
        {
            Console.WriteLine(String.Format("{0} = {1}", message, result));
        }

        private static void waitForKeyPress()
        {
            Console.WriteLine("\nPress any key to quit this program...");
            Console.ReadKey();
        }
    }
}
