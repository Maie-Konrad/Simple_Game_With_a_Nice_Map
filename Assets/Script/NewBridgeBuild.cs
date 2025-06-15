using UnityEngine;

public class NewBridgeBuild : MonoBehaviour
{
    public delegate void BridgisFixed();
    public static event BridgisFixed BridgisFix;
    [SerializeField]GameObject[] BridgeNew;
    [SerializeField] GameObject Oldbridge;
    void Start()
    {
        for (int i = 0; i < BridgeNew.Length; i++)
        {
            BridgeNew[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Deskicollect.CountofDeski += bridgeBuild;
    }
    private void bridgeBuild()
    {
        for (int i = 0; i < BridgeNew.Length; i++)
        {
            BridgeNew[i].SetActive(true);
        }
        
        Oldbridge.SetActive(false);
    }
}
