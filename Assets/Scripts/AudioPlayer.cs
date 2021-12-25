using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioPlayer : MonoBehaviour
    {
        [SerializeField] private AudioClip _hit, _destroyBlock;
        private AudioSource _audioSource;

        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        public void PlayHitClip()
        {
            _audioSource.clip = _hit;
            _audioSource.Play();
        }

        public void PlayDestroyBlockClip()
        {
            _audioSource.clip = _destroyBlock;
            _audioSource.Play();
        }
    }
}