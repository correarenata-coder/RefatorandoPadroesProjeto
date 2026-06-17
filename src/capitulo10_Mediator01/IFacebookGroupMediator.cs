using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace capitulo10_Mediator01
{
    public interface IFacebookGroupMediator
    {
        void SendMessage(string msg, User user);

        void RegisterUser(User user);
    }
}
