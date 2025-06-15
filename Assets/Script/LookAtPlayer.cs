using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(player);
        
    }
}
