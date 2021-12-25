using UnityEngine;

namespace Assets.Scripts.Block
{
    [RequireComponent(typeof(Collider))]
    public class Block : MonoBehaviour
    {
        [SerializeField] private BlocksStorage _storage;

        private void OnDestroy()
        {
            _storage.RemoveFromStorage(gameObject);
        }
    }
}