
namespace Decorator.Solution
{
    public abstract class CarDecoratorBase : ICar
    {
        protected ICar car;

        public abstract string GetDescription();
    }
}
