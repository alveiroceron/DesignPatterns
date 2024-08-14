namespace Mediator.Console
{
    interface IColleague
    {
        // issuer: emisor
        void Receive(string issuer, string message);
        void Send(string message);
    }
}
