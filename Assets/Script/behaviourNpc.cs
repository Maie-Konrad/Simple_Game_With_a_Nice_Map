using TMPro;
using UnityEngine;

public class behaviourNpc : MonoBehaviour
{

    [SerializeField] private GameObject info;
    [SerializeField] private GameObject PlayerMovementcontroller;
    [SerializeField] private GameObject CanvasDialogue;

    [TextArea(3, 10)]
    public string[] Dialog;
    public string[] DialogAfterBridge;

    [SerializeField] private string NameNPC;
    public TextMeshProUGUI dialogTextinCanvas;
    public TextMeshProUGUI NameTextinCanvas;

    private bool IsTiggered = false;
    private bool isInDialogue = false;
    private int dialogueIndex = 0;
    private string[] currentDialogue;

    void Start()
    {
        info.gameObject.SetActive(false);
        CanvasDialogue.SetActive(false);
        currentDialogue = Dialog;
        DestroyObejctAftertrigger.BridgeDestroyed += NewDialogAfterDestroyBridge;
    }

    void OnDestroy()
    {
        DestroyObejctAftertrigger.BridgeDestroyed -= NewDialogAfterDestroyBridge;
    }

    private void NewDialogAfterDestroyBridge()
    {
        currentDialogue = DialogAfterBridge;
        dialogueIndex = 0; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            info.gameObject.SetActive(true);
            IsTiggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            info.gameObject.SetActive(false);
            IsTiggered = false;
            EndDialogue();
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && IsTiggered)
        {
            if (!isInDialogue)
            {
                StartDialogue();
            }
            else
            {
                NextDialogue();
            }
        }
    }

    private void StartDialogue()
    {
        isInDialogue = true;
        PlayerMovementcontroller.SetActive(false);
        CanvasDialogue.SetActive(true);
        dialogueIndex = 0;
        dialogTextinCanvas.text = currentDialogue[dialogueIndex];
        NameTextinCanvas.text = NameNPC;
    }

    private void NextDialogue()
    {
        dialogueIndex++;

        if (dialogueIndex < currentDialogue.Length)
        {
            dialogTextinCanvas.text = currentDialogue[dialogueIndex];
        }
        else
        {
            EndDialogue();
        }
    }

    private void EndDialogue()
    {
        isInDialogue = false;
        PlayerMovementcontroller.SetActive(true);
        CanvasDialogue.SetActive(false);
    }
}
