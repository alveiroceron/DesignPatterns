using static System.Console;
namespace Decorator.RealWorld
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class Video : LibraryItem<Video>
    {
        private readonly string director;
        private readonly string title;
        private readonly int playTime;

        public Video(string director, string title, int numCopies, int playTime)
        {
            this.director = director;
            this.title = title;
            NumCopies = numCopies;
            this.playTime = playTime;
        }

        public override void Display()
        {
            WriteLine("\nVideo ----- ");
            WriteLine($" Director: {director}");
            WriteLine($" Title: {title}");
            WriteLine($" # Copies: {NumCopies}");
            WriteLine($" Playtime: {playTime}\n");
        }
    }
}
