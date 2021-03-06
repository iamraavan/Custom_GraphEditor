﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Raavanan.GraphEditor
{
    public abstract class DrawNode : ScriptableObject
    {
        public abstract void DrawWindow(BaseNode pBaseNode);

        public abstract void DrawCurve(BaseNode pBaseNode);
    }
}