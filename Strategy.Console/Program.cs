//se forma de una familia de algoritmos
//se encapsulan y se hacen intercambiables
//generalmente se usa para proveer una funcionalidad que tiene varias formas de llevarse a cabo
// se implementa via herencia o interfaz

//partes: 1. contexto 2. Interfaz estrategia 3. Estrategia n


using Strategy.Console;

string input = "";
double x = 0;
double y = 0;
double r = 0;
string option = "";


IOperation myOperation = new Addition();

while (option != "5")
{
    Console.WriteLine("1. Addition, 2. Subtraction, 3. Multiplication, 4. Division, 5. Exit");
    option = Console.ReadLine();
    if (option == "5")
        break;

    Console.WriteLine("provide the value of a.");
    input = Console.ReadLine();
    x = Convert.ToDouble(input);

    Console.WriteLine("provide the value of b.");
    input = Console.ReadLine();
    y = Convert.ToDouble(input);

    if (option == "1")
        myOperation = new Addition();
    if (option == "2")
        myOperation = new Subtraction();
    if (option == "3")
        myOperation = new Multiplication();
    if (option == "4")
        myOperation = new Division();

    r =  myOperation.operation(y, x);

    Console.WriteLine("The result is: " + r);


}