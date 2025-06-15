using UnityEngine;

public class InfoNpc : MonoBehaviour
{
    [SerializeField] private Transform player;
    void Update()
    {
        transform.LookAt(player);
    }
}
