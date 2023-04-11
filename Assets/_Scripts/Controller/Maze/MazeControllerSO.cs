using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FallingBalls.Controllers
{
    [CreateAssetMenu(fileName = "MazeController", menuName = "FallingBalls/Maze/MazeController")]
    public class MazeControllerSO : ScriptableObject
    {
        public float rotateSpeed;
        public float RotateSpeed => rotateSpeed;

        [SerializeField] private int activeBalls;
        public int ActiveBalls => activeBalls;

        public bool canPlay;
    }
}
