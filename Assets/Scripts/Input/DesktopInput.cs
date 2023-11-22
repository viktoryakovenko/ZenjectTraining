﻿using System;
using UnityEngine;

namespace Scripts.Input
{
    public class DesktopInput : IInput
    {
        public event Action<Vector3> ClickDown;
        public event Action<Vector3> ClickUp;
        public event Action Drag;
    }
}