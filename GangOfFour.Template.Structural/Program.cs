using System;

namespace DesignPatterns.GangOfFour.Template.Structural {
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Template Design Pattern.
    /// </summary>
    class Program {
        static void Main(string[] args) {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();

            // Wait for user
            Console.ReadKey();
        }
    }
}
