using UnityEngine;

public class TileHover : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public void OnHover()
    {
        _animator.Play("Hover");
    }
}
