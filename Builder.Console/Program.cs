// See https://aka.ms/new-console-template for more information

using Builder.Console;

Director director = new Director();

//build a normal car
NormalBuilder normalBuilder = new NormalBuilder();
director.Build(normalBuilder);

//get the built car
var car1 = normalBuilder.GetProduct();

car1.ShowCar();
Console.WriteLine("- - - - - - - - - - - - - - - - - ");

//build a sports car
SportsBuilder sportsBuilder = new SportsBuilder();
director.Build(sportsBuilder);

//get the built car
var car2 = sportsBuilder.GetProduct();

car2.ShowCar();
