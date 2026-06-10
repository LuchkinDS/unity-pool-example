using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Game.Pool
{
    public class PrefabFactory<T>: IFactory<T> where T : Component
    {
        private readonly IObjectResolver _resolver;
        private readonly T _prefab;

        public PrefabFactory(IObjectResolver resolver, T prefab)
        {
            _resolver = resolver;
            _prefab = prefab;
        }

        public T Create()
        {
            var go = _resolver.Instantiate(_prefab);
            go.gameObject.SetActive(false);
            return go;
        }
    }
}