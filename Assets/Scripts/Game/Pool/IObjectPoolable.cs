using System;
using UnityEngine.Pool;
using Component = UnityEngine.Component;

namespace Game.Pool
{
    public interface IObjectPoolable<T, TContext>
    {
        public void SetReturnAction(Action action);
        public void ReturnToPool();
        public void Setup(TContext context);
    }
}