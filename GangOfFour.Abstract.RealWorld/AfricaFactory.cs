﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Abstract.RealWorld {
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    class AfricaFactory : ContinentFactory {
        public override Herbivore CreateHerbivore() {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore() {
            return new Lion();
        }
    }
}
