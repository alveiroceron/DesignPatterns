namespace Decorator.RealWorld
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    public abstract class LibraryItem<T>
    {
        // Each T has its own NumCopies
        public static int NumCopies { get; set; }

        public abstract void Display();

    }
}
