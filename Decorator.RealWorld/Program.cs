//Participants
//The classes and objects participating in this pattern include:

//1 Component (LibraryItem): defines the interface for objects that can have responsibilities added to them dynamically.

//2 ConcreteComponent(Book, Video):  defines an object to which additional responsibilities can be attached.

//3 Decorator (Decorator): maintains a reference to a Component object and defines an interface that conforms to Component's interface.

//4 ConcreteDecorator (Borrowable): adds responsibilities to the component.

using static System.Console;
using Decorator.RealWorld;

/// <summary>
/// Decorator Design Pattern
/// </summary>

// Create book
var book = new Book("Alveiro", "Architect net", 10);
book.Display();

// Create video
var video = new Video("Spielberg", "Jaws", 23, 92);
video.Display();

// Make video borrowable, then borrow and display
WriteLine("\nMaking video borrowable:");

var borrow = new Borrowable<Video>(video);
borrow.BorrowItem("Customer #1");
borrow.BorrowItem("Customer #2");
borrow.Display();


var borrowBook = new Borrowable<Book>(book);
borrowBook.BorrowItem("Customer #3");
borrowBook.BorrowItem("Customer #12");
borrowBook.Display();


