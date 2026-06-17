using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo10_Mediator01
{
    // Colleague
    public abstract class User
    {
        protected IFacebookGroupMediator mediator;
        protected string name;

        public User(IFacebookGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public abstract void Send(string message);

        public abstract void Receive(string message);
    }
}
