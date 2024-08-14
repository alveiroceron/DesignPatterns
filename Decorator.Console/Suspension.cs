namespace Decorator.Console
{
    public class Suspension : IComponent
    {
        // Variable de referencia hacia quien vamos a decorar 
        // el auto u otro objeto de tipo decorador
        private IComponent _decorateTo;

        // aca se envia en el parametro a quien se va a decorar
        public Suspension(IComponent component)
        {
            _decorateTo = component;
        }

        public override string ToString()
        {
            return $"High performance suspension {_decorateTo}";
        }

        // Interface methods
        public double Cost()
        {
            // Calculamos costo
            // El costo de lo que decoro mas mi costo como componente
            return _decorateTo.Cost() + 63850;
        }

        public string Work()
        {
            return _decorateTo.Work() + "Raising suspension";
        }

    }
}
