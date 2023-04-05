
using System;
using System.Threading.Tasks;
using FallingBalls.Controllers;
using TMPro;
using UnityEngine;

public class BallSpawnController : MonoBehaviour
{
    public GameObject ballPrefab;
    

    async void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject ball = Instantiate(ballPrefab, transform);
            await Task.Delay(50);
        }
    }
}
