namespace TimeItTook.Core.Util
{
    public class AbstractFactory<T> : IAbstractFactory<T>
    {
        private readonly Func<T> factoryFunc;
        public AbstractFactory(Func<T> factory)
        {
            factoryFunc = factory;
        }

        public T Create()
        {
            return factoryFunc();
        }
    }
}
