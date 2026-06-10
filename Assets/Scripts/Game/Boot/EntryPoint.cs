using Game.Components;
using Game.Pool;
using VContainer.Unity;

namespace Game.Boot
{
    public class EntryPoint: IStartable
    {
        private readonly PoolService<Bullet, BulletContext> _bulletPool;
        private readonly PoolService<Target, TargetContext> _targetPool;

        public EntryPoint(
            PoolService<Bullet, BulletContext> bulletPool, 
            PoolService<Target, TargetContext> targetPool
        )
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