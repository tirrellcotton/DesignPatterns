using System;

namespace DesignPatterns.GangOfFour.Proxy.Structural {
    /// <summary>
    /// MainApp startup class for Structural
    /// Proxy Design Pattern.
    /// </summary>
    class Program {
        static void Main(string[] args) {
            // Create proxy and request a service
            Proxy proxy = new Proxy();
            proxy.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
