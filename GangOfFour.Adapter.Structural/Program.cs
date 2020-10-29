using System;

namespace DesignPatterns.GangOfFour.Adapter.Structural {
    /// <summary>
    /// MainApp startup class for Structural
    /// Adapter Design Pattern.
    /// </summary>
    class Program {
        static void Main(string[] args) {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
