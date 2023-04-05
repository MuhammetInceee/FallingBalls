using UnityEngine;

namespace FallingBalls.Systems
{
    public class SwerveInputSystem : MonoBehaviour
    {
        private float _lastFrameFingerPosX;
        private float _moveFactorX;

        public float MoveFactorX => _moveFactorX;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _lastFrameFingerPosX = Input.mousePosition.x;
            }

            else if (Input.GetMouseButton(0))
            {
                Vector3 currentMousePos = Input.mousePosition;
                
                _moveFactorX = currentMousePos.x - _lastFrameFingerPosX;
                _lastFrameFingerPosX = currentMousePos.x;
            }

            else if (Input.GetMouseButtonUp(0))
            {
                _moveFactorX = 0;
            }
        }
    }
}