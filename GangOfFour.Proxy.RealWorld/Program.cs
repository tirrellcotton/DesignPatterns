using System;

namespace DesignPatterns.GangOfFour.Proxy.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Proxy Design Pattern.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create math proxy
            MathProxy proxy = new MathProxy();

            // Do the math
            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

            // Wait for user
            Console.ReadKey();
        }
    }
}
