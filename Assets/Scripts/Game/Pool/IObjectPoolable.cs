namespace Game.Pool
{
    public interface IObjectPoolable<T, TContext>
    {
        public void ReturnToPool();
        public void Setup(TContext context);
    }
}