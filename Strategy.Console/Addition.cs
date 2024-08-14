namespace Strategy.Console
{
    internal class Addition : IOperation
    {
        public double operation(double a, double b)
        {
            return a + b;
        }
    }
}
