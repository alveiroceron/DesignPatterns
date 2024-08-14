using Decorator.Console;


// Creamos el componente central con tipo Icomponent
// para permitir decoracion
IComponent myCar = new Car("2024", "4 Doors", 2000000);

Console.WriteLine(myCar);

//Si se requiere usar metodos propios de la clase Car
//Se necesita usar un type cast  
((Car)myCar).Doors(true);

Console.WriteLine(" - - - - - ");

// decoramos el auto con sistema de sonido
myCar = new SoundSystem(myCar);

// Comprobamos la adicion de caracteristicas
Console.WriteLine(myCar.Cost());
Console.WriteLine(myCar.Work());
Console.WriteLine(myCar);

Console.WriteLine(" - - - - - ");


// decoramos el auto con nitrogeno
// auto tiene una referencia a una instancia de nitrogeno el cual en su interior tiene 
// aquello de mi auto y mi auto tiene una instancia de sistema de sonido que tiene una
// instancia de mi auto
myCar = new Nitrogen(myCar);

// Comprobamos la adicion de caracteristicas
Console.WriteLine(myCar.Cost());
Console.WriteLine(myCar.Work());
Console.WriteLine(myCar);

Console.WriteLine(" - - - - - ");


// para usar algo propio de nitrogeno usamos un type cast

((Nitrogen)myCar).UseNitro();

Console.WriteLine(" - - - - - ");

myCar = new Suspension(myCar);

// Comprobamos la adicion de caracteristicas
Console.WriteLine(myCar.Cost());
Console.WriteLine(myCar.Work());
Console.WriteLine(myCar);


