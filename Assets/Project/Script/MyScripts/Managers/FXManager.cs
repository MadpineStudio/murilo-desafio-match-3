using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace Gazeus.DesafioMatch3.Views
{
    public class FXManager : MonoBehaviour
    {
        public static FXManager Instance { get; private set; }
        [SerializeField] private ParticleSystem explosionPSMatch3;
        [SerializeField] private ParticleSystem explosionPS;
        [SerializeField] private Material revelMaterial;
        
        private void Awake()
        {
            if(Instance != null && Instance != this)
                Destroy(gameObject);
            
            Instance = this;

            revelMaterial.SetFloat("_Transition", 0f);
            Invoke("TransiteToGameMode", 2);
        }
        private void OnDisable()
        {
            revelMaterial.SetFloat("_Transition", 6f);
        }
        public void TransiteToGameMode()
        {
            revelMaterial.DOFloat(5f, "_Transition", .3f);
        }
        public void Correct(Vector3[] positions)
        {
            TileAudioManager.Instance.PlayRandomJellyClip();
            TileAudioManager.Instance.ExplosionClip();
            
            if(positions.Length > 3)
                StartCoroutine(SpawnExplosionParticleFXAboveMatch3(positions));
            else
                StartCoroutine(SpawnExplosionParticleFX(positions));

        }
        private IEnumerator SpawnExplosionParticleFX(Vector3[] positions)
        {
            for (int i = 0; i < positions.Length; i++)
            {
                Instantiate(explosionPSMatch3, positions[i], Quaternion.Euler(-90,0,0));
                yield return new WaitForSeconds(.07f);
            }
        }
        private IEnumerator SpawnExplosionParticleFXAboveMatch3(Vector3[] positions)
        {
            for (int i = 0; i < positions.Length; i++)
            {
                Instantiate(explosionPS, positions[i], Quaternion.Euler(-90,0,0));
                yield return new WaitForSeconds(.07f);
            }
        }
        public void MoveWhip()
        {
            TileAudioManager.Instance.PlayJellyWhipClip();
        }

    }
}