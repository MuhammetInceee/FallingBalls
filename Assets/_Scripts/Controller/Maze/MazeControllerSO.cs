using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FallingBalls.Controllers
{
    [CreateAssetMenu(fileName = "MazeController", menuName = "FallingBalls/Maze/MazeController")]
    public class MazeControllerSO : ScriptableObject
    {
        [SerializeField] private float rotateSpeed;
        public float RotateSpeed => rotateSpeed;
    }
}
