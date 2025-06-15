using UnityEngine;
using UnityEngine.EventSystems;

public class OnTiggerCursorChange : MonoBehaviour 
{

    public Texture2D interactCursor;
    public Texture2D defaultCursor;
    public LayerMask interactiveLayer; // Warstwa interaktywnych obiektów

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
            // Zmieñ kursor TYLKO jeœli trafisz na obiekt z warstwy "Interactive"
            Cursor.SetCursor(interactCursor, Vector2.zero, CursorMode.Auto);
        }
        else
        {
            Cursor.SetCursor( null, Vector2.zero, CursorMode.Auto);
        }
    }
}
