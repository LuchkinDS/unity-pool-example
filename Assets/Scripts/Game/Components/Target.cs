using Game.Pool;
using UnityEngine;

namespace Game.Components
{
    public class Target: BasePoolable<Target, TargetContext>
    {
        public override void ReturnToPool()
        {
            Pool.Release(this);
        }

        public override void Setup(TargetContext context)
        {
            transform.position = context.Position;
        }
    }

    public struct TargetContext
    {
        public Vector3 Position { get; }

        public TargetContext(Vector3 position)
        {
            Position = position;
        }
    }
}