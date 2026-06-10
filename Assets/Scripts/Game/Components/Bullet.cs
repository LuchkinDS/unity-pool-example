using Game.Pool;
using UnityEngine;

namespace Game.Components
{
    public class Bullet: BasePoolable<Bullet, BulletContext>
    {
        public override void ReturnToPool()
        {
            Pool.Release(this);
        }

        public override void Setup(BulletContext context)
        {
            transform.position = context.Position;
        }
    }

    public struct BulletContext
    {
        public Vector3 Position { get; }
        public BulletContext(Vector3 position)
        {
            Position = position;
        }
    }
}