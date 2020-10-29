using System;

namespace DesignPatterns.GangOfFour.Adapter.Structural {
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    class Adaptee {
        public void SpecificRequest() {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
