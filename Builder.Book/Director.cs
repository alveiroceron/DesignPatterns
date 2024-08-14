namespace Builder.FluentAPI
{
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public Product BuildMinimalViableProduct()
        {
            return _builder
                   .BuildPartA()
                   .Build();
        }

        public Product BuildFullFeaturedProduct()
        {
            return _builder
                .BuildPartA()
                .BuildPartB()
                .BuildPartC()
                .Build();
        }
    }
}
