using Scripts.Input;
using System;
using UnityEngine;

namespace Scripts
{
    public class MovementHandler : IDisposable
    {
        private IInput _input;

        public MovementHandler(IInput input, IMovable movable)
        {
            _input = input;

            Debug.Log(_input.GetType());
            Debug.Log(movable.GetType());
            Debug.Log(movable.Speed);

            _input.ClickDown += OnClickDown;
            _input.ClickUp += OnClickUp;
            _input.Drag += OnDrag;
        }        

        public void Dispose()
        {
            Debug.Log("Unsubscribed");
            _input.ClickDown -= OnClickDown;
            _input.ClickUp -= OnClickUp;
            _input.Drag -= OnDrag;
        }

        private void OnClickDown(Vector3 position)
        {

        }

        private void OnClickUp(Vector3 position)
        {

        }

        private void OnDrag()
        {

        }
    }
}