using UnityEngine;
using System.IO;

namespace Assets.Scripts.Menu
{
    public class Options : MonoBehaviour
    {
        public void EasyLevel() => SetLevelOfDifficulty(4, 1.5f);
        public void NormalLevel() => SetLevelOfDifficulty(5, 1f);
        public void HardLevel() => SetLevelOfDifficulty(6, 0.8f);

        private void SetLevelOfDifficulty(int ballSpeed, float boardSize)
        {
            var parameters = new BoardParameters(ballSpeed, boardSize);
            string path = Path.Combine(Application.streamingAssetsPath, "Complexity.json");
            File.WriteAllText(path, JsonUtility.ToJson(parameters));
        }
    }

    [System.Serializable]
    public class BoardParameters
    {
        public int Speed;
        public float Size;

        public BoardParameters(int speed, float size)
        {
            this.Speed = speed;
            this.Size = size;
        }
    }
}