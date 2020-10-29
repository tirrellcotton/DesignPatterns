﻿using System;

namespace DesignPatterns.GangOfFour.Bridge.Structural {
    /// <summary>
    /// The 'ConcreteImplementorB' class
    /// </summary>
    class ConcreteImplementorB : Implementor {
        public override void Operation() {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}
