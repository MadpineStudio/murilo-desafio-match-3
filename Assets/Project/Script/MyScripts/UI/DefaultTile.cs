using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gazeus.DesafioMatch3.Views
{
    public class DefaultTile : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] private Shader shader;
        private Animator _animator;
        private Image _renderer;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _renderer = GetComponent<Image>();
        }

        private void Start()
        {
            _renderer.material = new Material(shader);
        }

        public void OnPointerEnter(PointerEventData pointerEventData)
        {
            _animator.Play("Hover");
            _renderer.material.SetFloat("_Thickness", 0.003f);
        }

        public void OnPointerExit(PointerEventData pointerEventData)
        {
            _renderer.material.SetFloat("_Thickness", 0f);

        }
    }
}
