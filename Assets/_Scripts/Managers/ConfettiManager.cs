using System.Collections;
using FallingBalls.Signals;
using UnityEngine;

namespace FallingBalls.Managers
{
    public class ConfettiManager : MonoBehaviour
    {
        [SerializeField] private ParticleSystem confetti;

        private void OnEnable()
        {
            UISignals.LevelSuccessfulSignal += Confetti;
        }

        private void OnDisable()
        {
            UISignals.LevelSuccessfulSignal -= Confetti;
        }

        private void Confetti()
        {
            StartCoroutine(PlayConfetti());
        }

        private IEnumerator PlayConfetti()
        {
            yield return new WaitForSeconds(1.5f);
            confetti.Play();
        }
    }
}
