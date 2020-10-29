using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Command.Structural {
    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    class Receiver {
        public void Action() {
            Console.WriteLine("Called Receiver.Action()");
        }
    }
}
