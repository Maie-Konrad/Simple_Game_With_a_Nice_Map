using UnityEngine;

public class DestroyObejctAftertrigger : MonoBehaviour
{
    public bool Triggered = false;
    Rigidbody rb;
    [SerializeField] GameObject Movement;

    public delegate void EventBridgeDestroyed();
    public static event EventBridgeDestroyed BridgeDestroyed;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Triggered = true;
            BridgeDestroyed();

        }



    }
    private void Update()
    {
        if (Triggered)
        {
            destroyThis();
        }
    }
    private void destroyThis()
    {
        
        rb.useGravity = true;
        
    }
    
}
