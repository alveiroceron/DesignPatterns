using static System.Console;

namespace Decorator.Console
{
    // Representa el componente comcreto
    // Debe implementar a IComponent para llevar a cabo la decoracion
    public class Car : IComponent
    {
        private readonly string _model;
        private readonly string _characteristics;
        public readonly double _cost;

        public Car(string model, string characteristics, double cost)
        {
            _model = model;
            _characteristics = characteristics;
            _cost = cost;
        }


        public void Doors(bool state)
        {
            if (state)
                WriteLine("Closed doors");
            else
                WriteLine("Open doors");
        }

        public override string ToString()
        {
            return string.Format($"Model {_model}, {_characteristics} ");
        }

        // Icomponent methods
        public double Cost()
        {
            return _cost;
        }

        public string Work()
        {
            return "I turned on the engine";
        }
    }
}
