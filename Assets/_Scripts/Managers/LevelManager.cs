using FallingBalls.Signals;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FallingBalls.Managers
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField] private GameObject[] levelsPrefabs;
        [SerializeField] private TextMeshProUGUI levelText;
        
        private int _activeLevelIndex = -1;

        void Start()
        {
            _activeLevelIndex = PlayerPrefs.GetInt("ActiveLevelIndex", 0);
            levelText.text = $"Lv {_activeLevelIndex + 1}";
            
            for (int i = 0; i < levelsPrefabs.Length; i++)
            {
                if (i == _activeLevelIndex)
                {
                    Instantiate(levelsPrefabs[i], Vector3.zero, Quaternion.identity);
                }
            }
        }

        public void LoadNextLevel()
        {
            _activeLevelIndex++;

            if (_activeLevelIndex >= levelsPrefabs.Length)
            {
                _activeLevelIndex = 0;
            }

            PlayerPrefs.SetInt("ActiveLevelIndex", _activeLevelIndex);

            Destroy(GameObject.FindGameObjectWithTag("Level"));

            Instantiate(levelsPrefabs[_activeLevelIndex], Vector3.zero, Quaternion.identity);

            levelText.text = $"Lv {_activeLevelIndex + 1}";
            UISignals.RefreshScoreText.Invoke(-1);
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
