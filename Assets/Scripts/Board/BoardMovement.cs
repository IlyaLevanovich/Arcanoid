using UnityEngine;


namespace Assets.Scripts.Board
{
    [RequireComponent(typeof(Rigidbody))]
    public class BoardMovement : MonoBehaviour
    {
        private const int _speed = 8;
        private Rigidbody _rigidbody;
        private Vector3 _direction;
        

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            if (_direction != Vector3.zero)
                _rigidbody.MovePosition(transform.position + _direction * _speed * Time.fixedDeltaTime);
        }

        public void SetDirection(Vector3 direction) => this._direction = direction;
        public void SetParameters(Vector3 size) => transform.localScale = size;

    }

}