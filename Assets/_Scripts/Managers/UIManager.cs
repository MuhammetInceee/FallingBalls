using System.Collections;
using FallingBalls.Signals;
using UnityEngine;
using UnityEngine.Serialization;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject finishEndPanel;
    [SerializeField] private GameObject inGameEndPanel;
    
    private void OnEnable()
    {
        SubscribeEvent();
    }

    private void OnDisable()
    {
        UnSubscribeEvent();
    }

    #region SubscribeEvents

    private void SubscribeEvent()
    {
        UISignals.LevelSuccessfulSignal += LevelEnd;
    }

    private void UnSubscribeEvent()
    {
        UISignals.LevelSuccessfulSignal -= LevelEnd;
    }
    
    #endregion

    private void LevelEnd()
    {
        StartCoroutine(LevelEndVisualizer());
    }

    private IEnumerator LevelEndVisualizer()
    {
        yield return new WaitForSeconds(1.5f);
        inGameEndPanel.SetActive(false);
        finishEndPanel.SetActive(true);
    }
}
