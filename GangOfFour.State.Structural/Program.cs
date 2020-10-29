using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.State.Structural {
    /// <summary>
    /// MainApp startup class for Structural
    /// State Design Pattern.
    /// </summary>
    class Program {
        static void Main(string[] args) {
            // Setup context in a state
            Context c = new Context(new ConcreteStateA());

            // Issue requests, which toggles state
            c.Request();
            c.Request();
            c.Request();
            c.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
