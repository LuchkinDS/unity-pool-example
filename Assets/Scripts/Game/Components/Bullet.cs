using Game.Pool;
using UnityEngine;

namespace Game.Components
{
    public class Bullet: MonoBehaviour, IObjectPoolable<Bullet, BulletContext>
    {
        public void ReturnToPool()
        {
            throw new System.NotImplementedException();
        }

        public void Setup(BulletContext context)
        {
            throw new System.NotImplementedException();
        }
    }

    public struct BulletContext
    {
    }
}