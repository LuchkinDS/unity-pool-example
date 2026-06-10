using Game.Pool;
using UnityEngine;

namespace Game.Components
{
    public class Target: MonoBehaviour, IObjectPoolable<Target, TargetContext>
    {
        public void ReturnToPool()
        {
            throw new System.NotImplementedException();
        }

        public void Setup(TargetContext context)
        {
            throw new System.NotImplementedException();
        }
    }

    public struct TargetContext
    {
    }
}