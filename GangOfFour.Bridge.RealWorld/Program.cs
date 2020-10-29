using System;

namespace DesignPatterns.GangOfFour.Bridge.RealWorld {
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Bridge Design Pattern.
    /// </summary>
    class Program {
        static void Main(string[] args) {
            // Create RefinedAbstraction
            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor
            customers.Data = new CustomersData();

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            // Wait for user
            Console.ReadKey();
        }
    }
}
