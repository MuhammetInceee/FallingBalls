
using System;
using System.Threading.Tasks;
using FallingBalls.Controllers;
using TMPro;
using UnityEngine;

namespace FallingBalls.Controllers
{
    public class BallSpawnController : MonoBehaviour
    {
        private MazeControllerSO _mazeController;

        [SerializeField] private GameObject ballPrefab;


        void Start()
        {
            ResourceDataRead();
            BallPawn();
        }

        private void ResourceDataRead()
        {
            _mazeController = Resources.Load<MazeControllerSO>("Maze/MazeController");
        }

        public async void BallPawn()
        {
            for (int i = 0; i < _mazeController.ActiveBalls; i++)
            {
                GameObject ball = Instantiate(ballPrefab, transform);
                await Task.Delay(50);
            }
        }
    }
}
