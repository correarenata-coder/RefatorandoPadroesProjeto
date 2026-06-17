using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo10_Mediator01
{
    public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {
        private List<User> userList = new List<User>();
        public void RegisterUser(User user)
        {
            userList.Add(user);
        }

        public void SendMessage(string msg, User user)
        {
            foreach (var item in userList)
            {
                if (item != user)
                {
                    item.Receive(msg);
                }
            }
        }
    }
}
