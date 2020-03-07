using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector3(TitleCtrl.width, TitleCtrl.breadth, TitleCtrl.height);

        Debug.Log("width : " + TitleCtrl.width);
        Debug.Log("breadth : " + TitleCtrl.breadth);
        Debug.Log("height : " + TitleCtrl.height);

        Debug.Log("Floor created");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
