using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Gazeus.DesafioMatch3.Views
{
    [RequireComponent(typeof(AudioSource))]
    public class TileAudioManager : MonoBehaviour
    {
        public static TileAudioManager Instance { get; private set; }
        [SerializeField] private List<AudioClip> jellyClips;
        [SerializeField] private AudioSource _jellyAudioSource;
        
        [SerializeField] private AudioClip whipClip;
        [SerializeField] private AudioSource _jellyWhipSource;

        [SerializeField] private AudioClip explosionClip;
        [SerializeField] private AudioSource _explosionAudioSource;
        
        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }

            Instance = this;
            DontDestroyOnLoad(Instance);

            _jellyAudioSource = GetComponent<AudioSource>();
        }
        public void PlayRandomJellyClip()
        {
            if (!_jellyAudioSource.isPlaying)
            {
                int currentJellyClip = Random.Range(0, jellyClips.Count);
                _jellyAudioSource.clip = jellyClips[currentJellyClip];
                _jellyAudioSource.Play();
            }
        }
        public void PlayJellyWhipClip()
        {
            if (!_jellyWhipSource.isPlaying)
            {
                _jellyWhipSource.clip = whipClip;
                _jellyWhipSource.Play();
            }
        }

        public void ExplosionClip()
        {
            if (!_explosionAudioSource.isPlaying)
            {
                _explosionAudioSource.clip = explosionClip;
                _explosionAudioSource.Play();
            }
        }
    }
}