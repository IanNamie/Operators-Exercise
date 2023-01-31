using System.Data;
using System.Diagnostics;

namespace OperatorExercise
{
    public class Program
    {
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Add(int c, int d) 
        {
            return c + d;
        }
        public static int Multiply(int e, int f)
        {
            return e * f;
        }
        public static int Divide(int g, int h)
        {
            return g / h;
        }
        public static int Modulous(int i, int j)
        {
            return i % j;
        }
        public static double AreaOfCircle(double radius, double x)
        {
        return Math.PI * Math.Pow(radius,x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"");
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            double x = 2;

            Console.WriteLine($"{a}/{b} is {b} remainder {remainder}");
            Console.WriteLine("what is the radius of your circle?");
            double Radius = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"The Area of a circle with a radius of {Radius} is {AreaOfCircle(Radius, x)}");

        }
    }
}
