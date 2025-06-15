using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects;
    bool isTrigger = false;
  private void Update()
    {
        
            TriggerMenager.TriggerisON += destroyThisObject;
        
        
       
       
    }

     private void destroyThisObject()
    {
        if (isTrigger)
        {
            
            for (int i = 0; i < gameObjects.Length; i++) {
                if (gameObjects[i].activeSelf)
                {
                    gameObjects[i].gameObject.SetActive(false);
                }
                else
                {
                    gameObjects[i].gameObject.SetActive(true);

                }

            }

             }


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isTrigger = true;

        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isTrigger = false;

        }
    }
 
}
  
