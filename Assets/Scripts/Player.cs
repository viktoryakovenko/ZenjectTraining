using UnityEngine;
using Zenject;

namespace Scripts
{
    public class Player : MonoBehaviour, IMovable
    {
        public float Speed { get; private set; }
        public Transform Transform => transform;

        [Inject]
        private void Construct(PlayerConfig config)
        {
            Speed = config.Speed;
        }
    }
}