using UnityEngine;

public class CanvasDialogUiMenager : MonoBehaviour
{
    [SerializeField] private GameObject PlayerMovementcontroller;
    [SerializeField] private GameObject CanvasDialogue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static CanvasDialogUiMenager Instance { get; private set; }
    private void Awake()
    {
    
    
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CancelDialogue()
    {
        PlayerMovementcontroller.SetActive(true);
        CanvasDialogue.SetActive(false);
    }

    public void StartDialogue()
    {
        PlayerMovementcontroller.SetActive(false);
        CanvasDialogue.SetActive(true);
    }

}
