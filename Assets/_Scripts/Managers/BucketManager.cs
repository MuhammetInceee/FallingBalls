using FallingBalls.Signals;
using UnityEngine;

namespace FallingBalls.Managers
{
    public class BucketManager : MonoBehaviour
    {
        [SerializeField] private GameObject scoreTextPrefab;
        [SerializeField] private float scoreTextSpeed = 5f;
        [SerializeField] private float scoreTextDuration = 2f;

        private Transform _scoreTextSpawnPoint;

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out BallManager ball))
            {
                _scoreTextSpawnPoint = ball.transform;

                GameObject scoreTextInstance =
                    Instantiate(scoreTextPrefab, _scoreTextSpawnPoint.position + Vector3.up, Quaternion.identity);

                Vector3 direction = scoreTextInstance.transform.position - Camera.main!.transform.position;
                scoreTextInstance.transform.rotation = Quaternion.LookRotation(direction);


                Rigidbody scoreTextRigidbody = scoreTextInstance.GetComponent<Rigidbody>();
                scoreTextRigidbody.velocity = new Vector3(0f, scoreTextSpeed, 0f);
                Destroy(scoreTextInstance, scoreTextDuration);
                Destroy(ball, scoreTextDuration);
                
                UISignals.RefreshScoreText.Invoke(5);
            }
        }
    }
}
