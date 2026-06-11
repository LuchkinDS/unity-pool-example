using System;
using Game.Pool;
using UnityEngine;

namespace Game.Components
{
    public class Bullet: MonoBehaviour, IObjectPoolable<BulletContext>
    {
        private Action _action;
        private Vector3 _direction;
        private float _speed;
        
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
            _direction = context.Direction;
            _speed = context.Speed;
        }

        private void Update()
        {
            transform.position += _direction * (_speed * Time.deltaTime); 
        }
    }

    public struct BulletContext
    {
        public Vector3 Position { get; }
        public Vector3 Direction { get; }
        public float Speed { get; }
        
        public BulletContext(Vector3 direction, Vector3 position, float speed)
        {
            Position = position;
            Direction = direction;
            Speed = speed;
        }
    }
}