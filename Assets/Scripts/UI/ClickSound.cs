using System.Collections;
using UnityEngine;

namespace Assets.Scripts.UI
{
    [RequireComponent(typeof(AudioSource))]
    public class ClickSound : MonoBehaviour
    {
        private AudioSource _audioSource;

        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        public void Play() => _audioSource.Play();
    }
}