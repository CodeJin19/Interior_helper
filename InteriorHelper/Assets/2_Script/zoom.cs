using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoom : MonoBehaviour
{
    public GameObject floor;
    Vector2 origin;
    private Vector2 move;
    float orix;
    float oriy;

    public GameObject EventSystem;

    private void Start()
    {
        orix = floor.GetComponent<Transform>().position.x;
        oriy = floor.GetComponent<Transform>().position.y;
        EventSystem = GameObject.Find("EventSystem");
    }
        
    public void OnTouchDown()
    {
        origin = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        EventSystem.GetComponent<ButtonCtrl>().rmtrigger = false;
    }

    public void OnDrag()
    {
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            move = (Vector2)(touchZero.position + touchOne.position)/2 - (Vector2)origin;
            floor.GetComponent<Transform>().position = new Vector3(move.x + orix, move.y + oriy, 0);

        }
        
    }

    public void upp()
    {
        if (Input.touchCount == 1)
        {
            orix = floor.GetComponent<Transform>().position.x;
            oriy = floor.GetComponent<Transform>().position.y;
        }
    }
}
