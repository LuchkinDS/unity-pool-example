using Game.Components;
using Game.Pool;
using UnityEngine;
using VContainer;

namespace Game
{
    public class Spawner: MonoBehaviour
    {
        [SerializeField] private float bulletSpeed = 10f;
        [SerializeField] private float fireRate = 10f;
        
        private readonly Vector3 _bulletDirection = Vector3.up;
        private PoolService<Bullet, BulletContext> _pool;
        private float _nextFireTime;

        [Inject]
        private void Construct(PoolService<Bullet, BulletContext> pool)
        {
            _pool = pool;
        }

        private void Awake()
        {
            _nextFireTime = Time.time;
        }

        private void Update()
        {
            if (Time.time < _nextFireTime) return;
            var go = _pool.Get();
            go.Setup(new BulletContext(direction: _bulletDirection, position: transform.position, speed: bulletSpeed));
            _nextFireTime = Time.time + 1f / fireRate;
        }
    }
}