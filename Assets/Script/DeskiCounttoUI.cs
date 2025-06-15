using TMPro;
using UnityEngine;

public class DeskiCounttoUI : MonoBehaviour
{
    public delegate void DeskiCountt();
    public static event DeskiCountt CountofDeski;
    private bool iscollect;

    string prefiks = "Liczba Desek :   "; 
    private int countdeski = 0;

    [SerializeField] TextMeshProUGUI DeskiCountText;

    private void Update()
    {
        if (iscollect)
        {
            countdeski++;
            iscollect = false;
        }
        if (countdeski != 0)
        {
            gameObject.SetActive(true);

            DeskiCountText.text = prefiks + countdeski.ToString();
        }
        if (countdeski == 0) { gameObject.SetActive(false); }
        

        Deskicollect.CountofDeski += intdeskifunction;
    }
    
    private void intdeskifunction()
    {
        iscollect = true;
    }
}
