using System;

namespace DesignPatterns.GangOfFour.Proxy.Structural {
    /// <summary>
    /// The 'RealSubject' class
    /// </summary>
    class RealSubject : Subject {
        public override void Request() {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
}
