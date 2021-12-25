using UnityEngine;
using System.IO;
using Assets.Scripts.Menu;
using Assets.Scripts.Ball;

namespace Assets.Scripts.Board
{
    public class BoardSettings : MonoBehaviour
    {
        [SerializeField] private GameObject _board, _ball;
        private Vector3 _boardScale => _board.transform.localScale;

        private void Awake()
        {
            string path = Path.Combine(Application.streamingAssetsPath, "Complexity.json");
            var parameters = JsonUtility.FromJson<BoardParameters>(File.ReadAllText(path));
            SetParameters(parameters);
        }

        private void SetParameters(BoardParameters parameters)
        {
            int speed = parameters.Speed;
            var scale = new Vector3(parameters.Size, _boardScale.y, _boardScale.z);
            _board.GetComponent<BoardMovement>().SetParameters(scale);
            _ball.GetComponent<BallMovement>().SetParameters(speed);
        }

    }
}