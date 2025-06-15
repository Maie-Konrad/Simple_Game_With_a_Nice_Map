using UnityEngine;

public class TriggerCanvasE : MonoBehaviour
{
    [SerializeField] GameObject ETriggerameObject;    
    

    // Update is called once per frame
    void Update()
    {
        TriggerMenager.TriggerisAwake += TriggerShowETrigger;
        TriggerMenager.TriggerisDisable += TriggerhideETrigger;
    }
    private void TriggerShowETrigger()
    {
        ETriggerameObject.SetActive(true);
    }
    private void TriggerhideETrigger()
    {
        ETriggerameObject.SetActive(false);
    }
}
