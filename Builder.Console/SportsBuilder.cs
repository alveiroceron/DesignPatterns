namespace Builder.Console
{
    internal class SportsBuilder : IBuilder
    {
        private readonly Product car = new();
        public void BuildBody()
        {
            car.MountBody(new SpecialBody());
        }

        public void BuildEngine()
        {
            car.MountEngine(new BigEngine());
        }

        public void BuildTires()
        {
            car.Mounttires(new SpecialTires());
        }

        public Product GetProduct()
        {
            return car;
        }

    }
}
