namespace DesignPattern.BehavioralDesignPattern.MediatorDesignPattern
{
    public class ConcreteTTTGroupMediator : ITTTGroup
    {
        private List<TTTUser> UsersList = new List<TTTUser>();
        public void RegisterUser(TTTUser user)
        {
            UsersList.Add(user);
            user.group = this;
        }
        public void SendMessage(string message, TTTUser user)
        {
            foreach (TTTUser u in UsersList)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
