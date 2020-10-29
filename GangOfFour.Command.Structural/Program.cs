using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Command.Structural {
    /// <summary>
    /// MainApp startup class for Structural 
    /// Command Design Pattern.
    /// </summary>
    class Program {
        static void Main(string[] args) {
            // Create receiver, command, and invoker
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            // Wait for user
            Console.ReadKey();
        }
    }
}
