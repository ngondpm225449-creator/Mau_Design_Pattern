using System.Collections.Generic;

namespace DPM225449_TranDinhNgon_MyReal17_Mediator
{
    public class SupportCenter : AbstractSupportCenter
    {
        private Dictionary<string, User> users = new();

        public override void Register(User user)
        {
            if (!users.ContainsKey(user.Name))
                users[user.Name] = user;
            user.SupportCenter = this;
        }

        public override void Send(string from, string to, string message)
        {
            if (users.TryGetValue(to, out var user))
                user.Receive(from, message);
        }
    }
}