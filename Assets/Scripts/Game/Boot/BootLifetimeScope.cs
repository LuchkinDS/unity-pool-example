using Game.Components;
using Game.Pool;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Game.Boot
{
    public class BootLifetimeScope : LifetimeScope
    {
        [SerializeField] private Bullet bulletPrefab;
        [SerializeField] private Target targetPrefab;
        
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(bulletPrefab);
            builder.RegisterInstance(targetPrefab);
            
            builder.Register<PoolService<Bullet>>(Lifetime.Singleton);
            builder.Register<PoolService<Target>>(Lifetime.Singleton);
            
            builder.Register<PrefabFactory<Bullet>>(Lifetime.Singleton).As<IFactory<Bullet>>();
            builder.Register<PrefabFactory<Target>>(Lifetime.Singleton).As<IFactory<Target>>();

            builder.RegisterEntryPoint<EntryPoint>();
        }
    }
}
