using Mediator.Book;

Component1 component1 = new Component1();
Component2 component2 = new Component2();

ConcreteMediator concreteMediator = new ConcreteMediator(component1, component2);

Console.WriteLine("Client triggers operation A.");
component1.DoA();

Console.WriteLine();

Console.WriteLine("Client triggers operation D.");
component2.DoD();
