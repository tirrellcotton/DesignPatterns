using System;

namespace DesignPatterns.GangOfFour.Adapter.Structural {
    /// <summary>
    /// The 'Target' class
    /// </summary>
    class Target {
        public virtual void Request() {
            Console.WriteLine("Called Target Request()");
        }
    }
}
