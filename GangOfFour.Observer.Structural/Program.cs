using System;

namespace DesignPatterns.GangOfFour.Observer.Structural {
    /// <summary>
    /// MainApp startup class for Structural 
    /// Observer Design Pattern.
    /// </summary>
    class Program {
        static void Main(string[] args) {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();

            // Wait for user
            Console.ReadKey();
        }
    }
}
