using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Block
{
    [RequireComponent(typeof(Collider))]
    public class GameOverBlock : MonoBehaviour
    {
        [SerializeField] private UnityEvent _onCollision;

        public void TriggerAnEvent() => _onCollision?.Invoke();
    }
}