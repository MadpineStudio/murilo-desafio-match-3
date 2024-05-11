using UnityEngine;

public class HoverUI : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public void OnHover()
    {
        _animator.SetBool("Hover", true);
        UIMenu.Instance.HoverBlob();
    }

    public void ExitHover()
    {
        _animator.SetBool("Hover", false);
    }
    public void OnClickPlay()
    {
        UIMenu.Instance.CloseMenuTransition();
        UIMenu.Instance.Confirm();
    }
}
