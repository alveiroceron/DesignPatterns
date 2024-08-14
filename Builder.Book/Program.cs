using Builder.FluentAPI;

var director = new Director();
var builder = new ConcreteBuilder();

director.Builder = builder;

Console.WriteLine("Standard basic product:");
var mvp = director.BuildMinimalViableProduct();
Console.WriteLine(mvp.ListParts());

Console.WriteLine("Standard full featured product:");
var fullproduct = director.BuildFullFeaturedProduct();
Console.WriteLine(fullproduct.ListParts());

// Remember, the Builder pattern can be used without a Director
// class.
Console.WriteLine("Custom product:");

var other = builder.BuildPartA()
                    .BuildPartC()
                    .Build();


Console.Write(other.ListParts());