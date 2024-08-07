
namespace DesignPattern.BehavioralDesignPattern.MediatorDesignPattern
{
    public interface ITTTGroup
    {
        void SendMessage(string msg, TTTUser user);
        void RegisterUser(TTTUser user);
    }
}
