using UnityEngine;
using UnityEngine.Pool;

namespace Game.Pool
{
    public class PoolService<T> where T : Component
    {
        private readonly IFactory<T> _factory;
        public ObjectPool<T> Pool { get; private set; }

        public PoolService(IFactory<T> factory)
        {
            _factory = factory;
            Pool = new ObjectPool<T>(
                createFunc: Create,
                actionOnGet: item => item.gameObject.SetActive(true),
                actionOnRelease: item => item.gameObject.SetActive(false),
                actionOnDestroy: Object.Destroy
            );
        }

        private T Create()
        {
            return _factory.Create();
        }

        public void Warmup(int count = 10)
        {
            for (var i = 0; i < count; i++)
            {
                Pool.Release(Create());
            }
        }
    }
}