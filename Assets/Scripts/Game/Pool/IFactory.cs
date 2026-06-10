using UnityEngine;

namespace Game.Pool
{
    public interface IFactory<T> where T: Component
    {
        public T Create();
    }
}