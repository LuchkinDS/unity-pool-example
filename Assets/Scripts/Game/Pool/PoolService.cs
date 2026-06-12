using UnityEngine;
using UnityEngine.Pool;

namespace Game.Pool
{
    public class PoolService<T, TContext> where T : Component, IObjectPoolable<TContext>
    {
        private readonly IFactory<T> _factory;
        private readonly ObjectPool<T> _pool;

        public PoolService(IFactory<T> factory)
        {
            _factory = factory;
            _pool = new ObjectPool<T>(
                createFunc: Create,
                actionOnGet: item => item.gameObject.SetActive(true),
                actionOnRelease: item => item.gameObject.SetActive(false),
                actionOnDestroy: Object.Destroy
            );
        }

        public T Get() => _pool.Get();

        private T Create() {
            var go = _factory.Create();
            go.SetReturnAction(() =>
            {
                if (!go.gameObject.activeSelf) return;
                _pool.Release(go);
            });
            return go;
        }

        public void Warmup(int count = 10)
        {
            for (var i = 0; i < count; i++)
            {
                _pool.Release(Create());
            }
        }
    }
}