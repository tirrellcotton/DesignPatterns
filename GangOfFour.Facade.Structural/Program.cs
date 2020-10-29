using System;

namespace DesignPatterns.GangOfFour.Facade.Structural {
    /// <summary>
    /// MainApp startup class for Structural
    /// Facade Design Pattern.
    /// </summary>
    class Program {
        static void Main(string[] args) {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            // Wait for user
            Console.ReadKey();
        }
    }
}
