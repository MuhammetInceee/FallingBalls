using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketManager : MonoBehaviour
{
    public GameObject scoreTextPrefab;
    public float scoreTextSpeed = 5f; 
    public float scoreTextDuration = 2f; 

    private Transform scoreTextSpawnPoint;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out BallManager ball))
        {
            scoreTextSpawnPoint = ball.transform;
            
            GameObject scoreTextInstance =
                Instantiate(scoreTextPrefab, scoreTextSpawnPoint.position + (Vector3.up * 2), Quaternion.identity);
            
            Vector3 direction = scoreTextInstance.transform.position - Camera.main.transform.position;
            scoreTextInstance.transform.rotation = Quaternion.LookRotation(direction);


            Rigidbody scoreTextRigidbody = scoreTextInstance.GetComponent<Rigidbody>();
            scoreTextRigidbody.velocity = new Vector3(0f, scoreTextSpeed, 0f);
            Destroy(scoreTextInstance, scoreTextDuration);
            Destroy(ball, scoreTextDuration);
        }
    }
}
