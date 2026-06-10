using Game.Components;
using Game.Pool;
using VContainer.Unity;

namespace Game.Boot
{
    public class EntryPoint: IStartable
    {
        private readonly PoolService<Bullet> _bulletPool;
        private readonly PoolService<Target> _targetPool;

        public EntryPoint(PoolService<Bullet> bulletPool, PoolService<Target> targetPool)
        {
            _bulletPool = bulletPool;
            _targetPool = targetPool;
        }

        public void Start()
        {
            _bulletPool.Warmup();
            _targetPool.Warmup();
        }
    }
}