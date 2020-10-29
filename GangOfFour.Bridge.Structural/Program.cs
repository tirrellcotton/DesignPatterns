using System;

namespace DesignPatterns.GangOfFour.Bridge.Structural {
    /// <summary>
    /// MainApp startup class for Structural
    /// Bridge Design Pattern.
    /// </summary>
    class Program {
        static void Main(string[] args) {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            // Wait for user
            Console.ReadKey();
        }
    }
}
