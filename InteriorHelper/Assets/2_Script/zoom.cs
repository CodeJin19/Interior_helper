using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoom : MonoBehaviour
{
    public float perspectiveZoomSpeed = 0.05f;
    public float orthoZoomSpeed = 0.05f;
    public GameObject temp;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            //Debug.Log(touchZero.position);

            Touch touchOne = Input.GetTouch(1);
            //Debug.Log(touchOne.position);

            Debug.Log("double touched!!!");
            /*
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude * perspectiveZoomSpeed;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude * perspectiveZoomSpeed;

            Debug.Log("aaa" + prevTouchDeltaMag);
            Debug.Log("bbb" + touchDeltaMag);

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;
            
            //Debug.Log("aaa" + deltaMagnitudeDiff);

            temp.GetComponent<RectTransform>().localScale += new Vector3(deltaMagnitudeDiff * perspectiveZoomSpeed, deltaMagnitudeDiff * perspectiveZoomSpeed);
            */
        }
    }
}
