using System;

namespace Assignment8ex2
{
    public class MathSolutions
    {
        public double GetSum(double x, double y)
        {
            return x + y;
        }

        public double GetProduct(double a, double b)
        {
            return a * b;
        }

        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
    }

    // Custom delegate
    public delegate double MathDelegate(double a, double b);

    class Program
    {
        static void Main(string[] args)
        {
            // Create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);

            // Action delegate for GetSmaller method
            Action<double, double> smallerAction = answer.GetSmaller;
            smallerAction(num1, num2);

            // Func delegate for GetSum method
            Func<double, double, double> sumFunc = answer.GetSum;
            double sumResult = sumFunc(num1, num2);
            Console.WriteLine($" {num1} + {num2} = {sumResult}");

            // Custom delegate for GetProduct method
            MathDelegate productDelegate = answer.GetProduct;
            double productResult = productDelegate(num1, num2);
            Console.WriteLine($" {num1} * {num2} = {productResult}");
        }
    }
}
