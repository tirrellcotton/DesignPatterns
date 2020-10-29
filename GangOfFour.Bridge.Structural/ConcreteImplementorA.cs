﻿using System;

namespace DesignPatterns.GangOfFour.Bridge.Structural {
    /// <summary>
    /// The 'ConcreteImplementorA' class
    /// </summary>
    class ConcreteImplementorA : Implementor {
        public override void Operation() {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}
