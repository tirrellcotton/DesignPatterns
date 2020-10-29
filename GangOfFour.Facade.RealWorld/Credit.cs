﻿using System;

namespace DesignPatterns.GangOfFour.Facade.RealWorld {
    /// <summary>
    /// The 'Subsystem ClassB' class
    /// </summary>
    class Credit {
        public bool HasGoodCredit(Customer c) {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}
