namespace Decorator.Console
{
    public class SoundSystem : IComponent
    {
        // Variable de referencia hacia quien vamos a decorar 
        // el auto u otro objeto de tipo decorador
        private readonly IComponent _decorateTo;

        // pasamos partametro al objeto que va a ser decorado
        public SoundSystem(IComponent component)
        {
            _decorateTo = component;
        }

        public override string ToString()
        {
            return $"RadioZXC {_decorateTo}";
        }

        // Metodos de interface
        public double Cost()
        {
            // Calculamos costo
            // El costo de lo que decoro mas mi costo como componente
            return _decorateTo.Cost() + 3500;
        }

        public string Work()
        {
            return _decorateTo.Work() + ", Radio on";
        }
    }
}
