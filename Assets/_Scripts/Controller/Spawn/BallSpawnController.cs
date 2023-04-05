using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class BallSpawnController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ballPrefab;
    async void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(ballPrefab,transform);
            await Task.Delay(50);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
