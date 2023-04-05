using System;
using FallingBalls.Systems;
using UnityEngine;

namespace FallingBalls.Controllers
{
    [RequireComponent(typeof(Rigidbody), typeof(SwerveInputSystem))]
    public class MazeController : MonoBehaviour
    {
        private Quaternion _deltaRotation;
        private MazeControllerSO _mazeController;
        private Rigidbody _rb;
        private SwerveInputSystem _swerveInputSystem;

        private void Awake()
        {
            InitVariables();
            GetReferences();
        }

        private void InitVariables()
        {
            _mazeController = Resources.Load<MazeControllerSO>("Maze/MazeController");
        }

        private void GetReferences()
        {
            _rb = GetComponent<Rigidbody>();
            _swerveInputSystem = GetComponent<SwerveInputSystem>();
        }

        private void Update()
        {
            _deltaRotation = Quaternion.Euler(Vector3.forward * (_mazeController.RotateSpeed * Mathf.Clamp(_swerveInputSystem.MoveFactorX, -9f,9f)));

            _rb.MoveRotation(_rb.rotation * _deltaRotation);
        }
    }
}
