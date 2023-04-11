using System;
using System.Collections;
using System.Collections.Generic;
using FallingBalls.Controllers;
using FallingBalls.Signals;
using UnityEngine;

namespace FallingBalls.Physics
{
    public class MazeExit : MonoBehaviour
    {
        private MazeControllerSO _mazeController;
        private int _tempBallCount;

        private void Start()
        {
            ReadDataResource();
            InitVariables();
        }


        private void ReadDataResource()
        {
            _mazeController = Resources.Load<MazeControllerSO>("Maze/MazeController");
        }

        private void InitVariables()
        {
            _tempBallCount = _mazeController.ActiveBalls;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out BallManager ballManager))
            {
                _tempBallCount--;
                
                if (_tempBallCount == 1)
                {
                    _mazeController.canPlay = false;
                    UISignals.LevelSuccessfulSignal.Invoke();
                }
            }
        }
    }
}
