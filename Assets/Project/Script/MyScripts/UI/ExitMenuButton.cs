using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gazeus.DesafioMatch3
{
    public class ExitMenuButton : MonoBehaviour
    {
        [SerializeField] private AudioSource buttonAudioSource;
        public void ExitGameplay()
        {
            SceneManager.LoadScene(0);
        }
        public void OnHover()
        {
            buttonAudioSource.Play();
        }
    }
}
