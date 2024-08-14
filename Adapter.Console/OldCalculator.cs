namespace Adapter.Console
{
    class OldCalculator : ITarget
    {
        public int Adition(int a, int b)
        {
            return a + b;
        }
    }
}
