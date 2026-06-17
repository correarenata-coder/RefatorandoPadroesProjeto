using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo10_Mediator01
{
    //ConcreteCollege
    public class ConcreteUser : User
    {
        public ConcreteUser(IFacebookGroupMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{name} : recebida <= { message} ");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{name} : recebida <= {message}\n ");
            mediator.SendMessage(message, this);
        }
    }
}
