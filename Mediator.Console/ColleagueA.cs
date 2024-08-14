using static System.Console;
namespace Mediator.Console
{
    class ColleagueA : IColleague
    {
        private Mediator _mediator;
        private string _name;

        public ColleagueA(Mediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;

            _mediator.Subscribe(Receive);

        }

        public void Receive(string issuer, string message)
        {
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLine("I'm {0}, and received from {1}: {2}", _name, issuer, message);
        }

        public void Send(string message)
        {
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLine("I'm {0}, and i'm sending {1}", _name, message);
            _mediator.Send(_name, message);
        }
    }
}
