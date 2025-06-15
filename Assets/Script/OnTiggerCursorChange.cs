using UnityEngine;
using UnityEngine.EventSystems;

public class OnTiggerCursorChange : MonoBehaviour 
{

    public Texture2D interactCursor;
    public Texture2D defaultCursor;
    public LayerMask interactiveLayer; // Warstwa interaktywnych obiekt�w

    private Camera mainCam;

    void Start()
    {
        mainCam = Camera.main;
        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
    }

    void Update()
    {
        Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, interactiveLayer))
        {
            // Zmie� kursor TYLKO je�li trafisz na obiekt z warstwy "Interactive"
            Cursor.SetCursor(interactCursor, Vector2.zero, CursorMode.Auto);
        }
        else
        {
            Cursor.SetCursor( null, Vector2.zero, CursorMode.Auto);
        }
    }
}
