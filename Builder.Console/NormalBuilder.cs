namespace Builder.Console
{
    internal class NormalBuilder : IBuilder
    {
        private Product car = new Product();
        public void BuildBody()
        {
            car.MountBody(new BasicBody());
        }

        public void BuildEngine()
        {
            car.MountEngine(new BasicEngine());
        }

        public void BuildTires()
        {
            car.Mounttires(new BasicTires());
        }

        public Product GetProduct()
        {
            return car;
        }

    }
}
