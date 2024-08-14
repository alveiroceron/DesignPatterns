using Strategy.Book;

// The client code picks a concrete strategy and passes it to the
// context. The client should be aware of the differences between
// strategies in order to make the right choice.


Console.WriteLine("Client: Strategy is set to normal sorting.");
var context = new Context(new ConcreteStrategyA());
context.Sort();

Console.WriteLine();

Console.WriteLine("Client: Strategy is set to reverse sorting.");
context.SetStrategy(new ConcreteStrategyB());
context.Sort();


