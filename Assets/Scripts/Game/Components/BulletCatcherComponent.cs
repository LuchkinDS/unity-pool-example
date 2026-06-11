using Game.Pool;
using UnityEngine;

namespace Game.Components
{
    public class BulletCatcherComponent : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<IReleasable>(out var go))
            {
                go.ReturnToPool();
            }
        }
    }
}
