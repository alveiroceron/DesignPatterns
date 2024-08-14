namespace Builder.FluentAPI
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    public interface IBuilder
    {
        IBuilder BuildPartA();
        IBuilder BuildPartB();
        IBuilder BuildPartC();
        Product Build();
    }
}
