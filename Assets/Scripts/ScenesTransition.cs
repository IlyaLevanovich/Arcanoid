using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class ScenesTransition : MonoBehaviour
    {
        [SerializeField] private GameObject _takeBonusHealth, _bonusHealth;
        [SerializeField] private PlayerHealth _playerHealth;
        

        public void Menu() => SceneManager.LoadScene(0);
        public void NextLevel() => SceneManager.LoadScene(1);

        public void BonusHealth()
        {
            Application.OpenURL("https://www.youtube.com/watch?v=fdyuOiciwB4");
            _bonusHealth.SetActive(false);
            _takeBonusHealth.SetActive(true);
            _playerHealth.AddHealth();
        }

        public void SetNormalTimeScale() => Time.timeScale = 1;
    }
}