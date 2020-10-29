using System;

namespace DesignPatterns.GangOfFour.Strategy.Structural {
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class ConcreteStrategyB : Strategy {
        public override void AlgorithmInterface() {
            Console.WriteLine(
                "Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
}
