using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Block;
using System.IO;
using Assets.Scripts.Board;

namespace Assets.Scripts.Ball
{
    [RequireComponent(typeof(Collider))]
    public class BallCollision : MonoBehaviour
    {
        [SerializeField] private Text _score;
        [SerializeField] private AudioPlayer _player;
        private int _scoreAmount = 0;


        private void Start()
        {
            _scoreAmount = int.Parse(File.ReadAllText(Path.Combine(Application.streamingAssetsPath, "Score.json")));
            _score.text = _scoreAmount.ToString();
        }

        private void OnCollisionEnter(Collision collision)
        {
            var block = collision.gameObject.GetComponent<Block.Block>();
            if (block != null)
            {
                Destroy(block.gameObject);
                AddScore();
            }
            collision.gameObject.GetComponent<GameOverBlock>()?.TriggerAnEvent();
            if (collision.gameObject.GetComponent<BoardMovement>())
                _player.PlayHitClip();
        }

        private void AddScore()
        {
            _scoreAmount++;
            _score.text = _scoreAmount.ToString();
            File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "Score.json"), _scoreAmount.ToString());
        }
    }
}