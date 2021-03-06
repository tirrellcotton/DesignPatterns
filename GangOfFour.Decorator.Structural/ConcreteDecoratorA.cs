﻿using System;

namespace DesignPatterns.GangOfFour.Decorator.Structural {
    /// <summary>
    /// The 'ConcreteDecoratorA' class
    /// </summary>
    class ConcreteDecoratorA : Decorator {
        public override void Operation() {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}
