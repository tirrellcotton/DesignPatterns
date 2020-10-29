using System;

namespace DesignPatterns.GangOfFour.Facade.RealWorld {
    /// <summary>
    /// The 'Subsystem ClassC' class
    /// </summary>
    class Loan {
        public bool HasNoBadLoans(Customer c) {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}
