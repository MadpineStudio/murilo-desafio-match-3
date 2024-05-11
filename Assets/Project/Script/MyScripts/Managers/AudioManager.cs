using System;
using UnityEngine;

namespace Gazeus.DesafioMatch3
{
    public class AudioManager : MonoBehaviour
    {
        [SerializeField] private AudioSource[] _audioSources;
        private bool _muted;
        private float[] _volumes;

        private void Start()
        {
            _volumes = new float[_audioSources.Length];
        }

        public void Mute()
        {
            if(!_muted)
                MuteGame();
            else
                Unmute();
        }
        private void MuteGame()
        {
            for(int i = 0; i < _audioSources.Length; i++)
            {
                _volumes[i] = _audioSources[i].volume;
                _audioSources[i].volume = 0;
            }

            _muted = true;
        }
        private void Unmute()
        {
            for(int i = 0; i < _audioSources.Length; i++)
            {
                _audioSources[i].volume = _volumes[i];
            } 
            _muted = false;

        }
    }
}
