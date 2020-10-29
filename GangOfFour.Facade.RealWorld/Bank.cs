﻿using System;

namespace DesignPatterns.GangOfFour.Facade.RealWorld {
    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>
    class Bank {
        public bool HasSufficientSavings(Customer c, int amount) {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}
