namespace TestFramework.Factories
{
    public abstract class BaseFactory<T> where T : class, new()
    {
        protected T entity;

        public BaseFactory()
        {
            entity = new T();
        }

        public T Create()
        {
            return entity;
        }
    }
}
