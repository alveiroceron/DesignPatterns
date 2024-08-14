using static System.Console;
namespace Mediator.Console
{
    class ColleagueB : IColleague
    {
        private Mediator _mediator;
        private string _name;
        private int _count;

        public ColleagueB(Mediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;

            // subscribe
            _mediator.Subscribe(Receive);

        }

        public void Receive(string issuer, string message)
        {
            _count++;
            ForegroundColor = ConsoleColor.Red;
            WriteLine("<-[{0},{1}]({2}): {3}", _name, issuer, _count, message);
        }

        public void Send(string message)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("->[{0}] :{1}", _name, message);
            _mediator.Send(_name, message);
        }
    }
}
