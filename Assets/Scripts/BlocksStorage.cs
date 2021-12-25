using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class BlocksStorage : MonoBehaviour
    {
        [SerializeField] private GameOver _gameOver;
        [SerializeField] private List<GameObject> _blocks;
        [SerializeField] private AudioPlayer _player;
        
        public void RemoveFromStorage(GameObject block)
        {
            _blocks.Remove(block);
            _player.PlayDestroyBlockClip();

            if (_blocks.Count == 0)
                _gameOver.FinishGame(true);
        }
    }
}