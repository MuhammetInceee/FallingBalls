using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FallingBalls.Signals
{
    public static class UISignals
    {
        public static Action LevelSuccessfulSignal;
        public static Action<float> RefreshScoreText;
    }
}
