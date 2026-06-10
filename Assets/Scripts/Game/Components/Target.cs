using System;
using Game.Pool;
using UnityEngine;

namespace Game.Components
{
    public class Target: MonoBehaviour, IObjectPoolable<Target, TargetContext>
    {
        private Action _action;

        public void SetReturnAction(Action action)
        {
            _action = action;
        }

        public void ReturnToPool()
        {
            _action?.Invoke();
        }

        public void Setup(TargetContext context)
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