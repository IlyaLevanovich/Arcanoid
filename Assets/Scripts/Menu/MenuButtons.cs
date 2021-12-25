using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Menu
{
    public class MenuButtons : MonoBehaviour
    {
        [SerializeField] private GameObject _options;

        private void Start()
        {
            File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "Score.json"), 0.ToString());
            Time.timeScale = 1;
        }

        public void LoadGame() => SceneManager.LoadScene(1);
        public void Exit() => Application.Quit();

        public void Options() => _options.SetActive(!_options.active);
    }
}