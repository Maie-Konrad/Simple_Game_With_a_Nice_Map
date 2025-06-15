using UnityEngine;

public class TriggerMenager : MonoBehaviour
{
    public  bool trigger = false;


    public delegate void GameEvent(); 
    public static event GameEvent TriggerisON;
    public static event GameEvent TriggerisAwake;
    public static event GameEvent TriggerisDisable;

    private void Start()
    {
       
    }
    private void Update()
    {
        if (trigger)
        {
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                TriggerisON();
            }
            
        }
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TriggerisAwake();
            trigger = true;
         
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TriggerisDisable();
            trigger = false;
            
        }
    }
}
