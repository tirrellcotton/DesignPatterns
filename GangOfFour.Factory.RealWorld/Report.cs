﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Factory.RealWorld {
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Report : Document {
        // Factory Method implementation
        public override void CreatePages() {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
