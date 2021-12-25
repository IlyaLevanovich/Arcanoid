using Assets.Scripts.Board;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.UI
{
    public class UIPressing : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private BoardMovement _boardMovement;
        [SerializeField] private Vector3 _direction;

        public void OnPointerDown(PointerEventData eventData)
        {
            _boardMovement.SetDirection(_direction);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _boardMovement.SetDirection(Vector3.zero);
        }
    }
}