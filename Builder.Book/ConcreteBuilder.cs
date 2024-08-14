namespace Builder.FluentAPI
{
    // The Concrete Builder classes follow the Builder interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builders, implemented differently.
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }

        public IBuilder BuildPartA()
        {
            _product.Add("PartA1");
            return this;
        }

        public IBuilder BuildPartB()
        {
            _product.Add("PartB1");
            return this;
        }

        public IBuilder BuildPartC()
        {
            _product.Add("PartC1");
            return this;
        }

        public Product Build()
        {
            Product result = _product;
            Reset();
            return result;
        }
    }
}
