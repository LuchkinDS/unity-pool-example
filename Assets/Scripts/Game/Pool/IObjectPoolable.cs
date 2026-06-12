using System;

namespace Game.Pool
{
    public interface IObjectPoolable<TContext>: IReleasable
    {
        public void SetReturnAction(Action action);
        public void Setup(TContext context);
    }

    public interface IReleasable
    {
        public void ReturnToPool();

    }
}