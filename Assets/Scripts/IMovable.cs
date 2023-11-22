using UnityEngine;

namespace Scripts
{
    public interface IMovable
    {
        public float Speed { get; }
        public Transform Transform { get; }
    }
}
