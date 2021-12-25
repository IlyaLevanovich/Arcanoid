using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Ball
{
    [RequireComponent(typeof(Rigidbody))]
    public class BallMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            StartCoroutine(BeginMove());
        }

        public void SetParameters(int speed) => this._speed = speed;

        private IEnumerator BeginMove()
        {
            yield return new WaitForSeconds(3);
            
            _rigidbody.velocity = new Vector3(1.3f, 0, 1.3f) * _speed;
        }
    }
}