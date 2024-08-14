using static System.Console;

namespace Mediator.Console
{
    class Mediator
    {
        //Create a delegate to invoke the methods
        public delegate void Sender(string issuer, string message);
        Sender sendMessage;

        //
        public void Subscribe(Sender method)
        {
            sendMessage += method;
            System.Console.ForegroundColor = ConsoleColor.Green;
            WriteLine(" --- Subscribed ---");
        }

        public void Send(string issuer, string message)
        {
            // we can use the mediator to censure
            if (message.Contains("palabrota"))
                message = message.Replace("palabrota", "******");

            // send messages using the delegate
            sendMessage(issuer, message);
            System.Console.ForegroundColor = ConsoleColor.Green;
            WriteLine(" --- sent message---");
        }

        //Remove the method from the delegate
        public void Blocking(Sender method)
        {
            sendMessage -= method;
            System.Console.ForegroundColor = ConsoleColor.Green;
            WriteLine(" --- Block ---");
        }


    }
}
