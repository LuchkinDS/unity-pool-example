using System;
using Game.Pool;
using UnityEngine;
using UnityEngine.Pool;

namespace Game.Components
{
    public class Bullet: MonoBehaviour, IObjectPoolable<Bullet, BulletContext>
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

        public void Setup(BulletContext context)
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