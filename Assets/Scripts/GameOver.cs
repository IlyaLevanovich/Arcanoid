using UnityEngine;
using UnityEngine.UI;
using System.IO;

namespace Assets.Scripts
{
    public class GameOver : MonoBehaviour
    {
        [SerializeField] private GameObject _gameOverPanel, _nextLevelButton;
        [SerializeField] private Text _gameOverText, _scoreText;
        private int _scoreAmount;

        private void Start()
        {
            Time.timeScale = 1;
        }

        public void FinishGame(bool isWin)
        {
            _gameOverText.text = isWin ? "You win" : "You lose";
            _nextLevelButton.SetActive(isWin);
            _scoreText.text = "Total score: " + File.ReadAllText(GetScoreStoragePath());
            _gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
        
        private string GetScoreStoragePath()
        {
            return Path.Combine(Application.streamingAssetsPath, "Score.json");
        }
        
        public void Pause()
        {
            if (Time.timeScale == 0)
                Time.timeScale = 1;
            else
                Time.timeScale = 0;
        }
        
    }
}