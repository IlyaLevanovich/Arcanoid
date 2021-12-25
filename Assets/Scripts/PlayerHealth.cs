using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private GameOver _gameOver;
        [SerializeField] private Text _healthText;
        private int _health = 3;

        private void Start()
        {
            PrintHealth();
        }

        public void TakeAwayHealth()
        {
            _health--;
            PrintHealth();

            if (_health <= 0)
                _gameOver.FinishGame(false);
        }

        public void AddHealth()
        {
            _health++;
            PrintHealth();
        }
        private void PrintHealth() => _healthText.text = _health.ToString();
    }
}