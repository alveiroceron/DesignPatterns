namespace Adapter.Console
{
    // Esta es la clase que queremos adaptar, el cliente no la puede usar directamente
    // pues su interfaz es diferente
    class NewCalculator
    {
        public double Add(int[] numbers)
        {
            double r = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                r += numbers[i];
            }
            return r;
        }

    }
}
