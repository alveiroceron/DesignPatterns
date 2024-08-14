using Adapter.Console;

int result = 0;

//usamos la interface que el cliente conoce con una clase que conoce
ITarget calcu = new OldCalculator();

result = calcu.Adition(2, 3);
Console.WriteLine("The result is {0}", result);
Console.WriteLine(" - - - - - - - - ");


// Usamos el adaptador
calcu = new Adapter.Console.Adapter();

// usamos el adaptador para hacer la adición
result = calcu.Adition(2, 5);
Console.WriteLine("The result is {0}", result);



