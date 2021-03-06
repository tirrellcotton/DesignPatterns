﻿using System;

namespace DesignPatterns.GangOfFour.State.Structural {
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class Context {
        private State _state;

        // Constructor
        public Context(State state) {
            this.State = state;
        }

        // Gets or sets the state
        public State State {
            get { return _state; }
            set {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }

        public void Request() {
            _state.Handle(this);
        }
    }
}
