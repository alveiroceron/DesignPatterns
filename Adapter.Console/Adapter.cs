namespace Adapter.Console
{
    // este es el adaptador, usa Itarger la cual la conoce el cliente
    // el adaptador comunica el cliente con la clase adaptada

    public class Adapter : ITarget
    {
        NewCalculator adapted = new();

        // Hacemos la adaptacion de una operacion
        public int Adition(int a, int b)
        {
            // creamos el array que necesita el adapted
            // adaptamos los datos que se envian
            int[] numbers = { a, b };

            //ejecutamos operacion en el adaptado
            double r = adapted.Add(numbers);

            // adaptamos resultado
            return (int)r;
        }
    }
}
