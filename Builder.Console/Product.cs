namespace Builder.Console
{
    class Product
    {
        private IEngine _engine;
        private IBody _body;
        private ITires _tires;

        public void MountEngine(IEngine engine)
        {
            _engine = engine;
            System.Console.WriteLine("The engine {0} has been mounted", _engine.Specifications());
        }

        public void MountBody(IBody body)
        {
            _body = body;
            System.Console.WriteLine("The body {0} has been mounted", _body.Characteristics());
        }

        public void Mounttires(ITires tires)
        {
            _tires = tires;
            System.Console.WriteLine("The tires {0} have been mounted", _tires.Information());
        }


        public void ShowCar()
        {
            System.Console.WriteLine("Your car has {0},{1},{2}",
                _engine.Specifications(), _tires.Information(), _body.Characteristics());
        }


    }
}
