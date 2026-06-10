using UnityEngine.Pool;
using Component = UnityEngine.Component;

namespace Game.Pool
{
    public interface IObjectPoolable<T, TContext> where T : class
    {
        public void SetPool(IObjectPool<T> pool);
        public void ReturnToPool();
        public void Setup(TContext context);
    }
}