using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    public static UIMenu Instance { get; private set; }
    [SerializeField] private AudioClip hoverButtonClip;
    [SerializeField] private AudioClip comfirmButtonClip;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioSource menuAudioSource;
    [SerializeField] private Material revelTransition;
    
    // occluded: 0, revel: 5
    private float _transition;
    private void Awake()
    {
        if(Instance != null && Instance != this)
            Destroy(gameObject);
        
        Instance = this;
        // DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        revelTransition.SetFloat("_Transition", 0f);
        Invoke("StartGameAnimationTransition", 5f);
    }
    public void StartGameAnimationTransition()  
    {
        revelTransition.DOFloat(5f, "_Transition", .3f);
    }
    public void CloseMenuTransition()
    {
        revelTransition.DOFloat(0f, "_Transition", .35f);
    }
    public void HoverBlob()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = hoverButtonClip;
            audioSource.Play();
        }
    }
    public void Confirm()
    {
        audioSource.clip = comfirmButtonClip;
        audioSource.Play();
        Invoke("StartGameScene", 2f);
    }
    private void OnDisable()
    {
        revelTransition.SetFloat("_Transition", 6f);
    }
    private void StartGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
