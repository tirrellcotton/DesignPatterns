using System;

namespace DesignPatterns.GangOfFour.Facade.RealWorld {
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Facade Design Pattern.
    /// </summary>
    class Program {
        static void Main(string[] args) {
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user
            Console.ReadKey();
        }
    }
}
