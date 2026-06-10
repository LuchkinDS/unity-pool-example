using UnityEngine;
using UnityEngine.Pool;

namespace Game.Pool
{
    public abstract class BasePoolable<T, TContext>: MonoBehaviour, IObjectPoolable<T, TContext> where T : class
    {
        protected IObjectPool<T> Pool;
        
        public void SetPool(IObjectPool<T> pool)
        {
            Pool = pool;
        }

        public abstract void ReturnToPool();

        public abstract void Setup(TContext context);
    }
}