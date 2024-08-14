using static System.Console;

namespace Decorator.Console
{
    public class Nitrogen : IComponent
    {
        // Variable de referencia hacia quien vamos a decorar 
        // el auto u otro objeto de tipo decorador
        private IComponent _decorateTo;

        // aca se envia en el parametro a quien se va a decorar
        public Nitrogen(IComponent component)
        {
            _decorateTo = component;
        }

        public override string ToString()
        {
            return $"Nitrogen system {_decorateTo} \r\n";
        }

        // Interface methods
        public double Cost()
        {
            // Calculamos costo
            // El costo de lo que decoro mas mi costo como componente
            return _decorateTo.Cost() + 45000;
        }

        public string Work()
        {
            return _decorateTo.Work() + "Nitrogen ready";
        }

        public void UseNitro()
        {
            WriteLine("Nitrogen in use");
        }
    }
}
