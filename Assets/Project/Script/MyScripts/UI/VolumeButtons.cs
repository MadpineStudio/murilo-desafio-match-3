using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gazeus.DesafioMatch3
{
    public class VolumeButtons : MonoBehaviour
    {
        [SerializeField] private List<Sprite> icons;
        [SerializeField] private Image iconImage;
        [SerializeField] private AudioSource buttonAudioSource;
        private bool _enable;
        
        public void SwichIcon()
        {
            iconImage.sprite = icons[_enable? 0 : 1];
            _enable = !_enable;
        }

        public void OnHover()
        {
            buttonAudioSource.Play();
        }
    }
}
