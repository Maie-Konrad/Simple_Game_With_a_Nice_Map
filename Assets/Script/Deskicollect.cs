using UnityEngine;
using UnityEngine.Rendering;

public class Deskicollect : MonoBehaviour
{
    public delegate void Collect();
    public static event Collect CountofDeski;

    [SerializeField] private GameObject[] Deski;
    private bool isTrigger = false;
    private bool alreadyCollected = false;

    private void OnEnable()
    {
        TriggerMenager.TriggerisON += CollectDeski;
    }

    private void OnDisable()
    {
        TriggerMenager.TriggerisON -= CollectDeski;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !alreadyCollected)
        {
            isTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTrigger = false;
        }
    }

    private void CollectDeski()
    {
        if (isTrigger && !alreadyCollected)
        {
            alreadyCollected = true;

            foreach (var deska in Deski)
            {
                if (deska != null)
                {
                    deska.SetActive(false);
                }
            }

            CountofDeski?.Invoke();
        }
    }
}