using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCtrl : MonoBehaviour
{
    public GameObject floor;

    // Start is called before the first frame update
    void Start()
    {
        floor.GetComponent<RectTransform>().sizeDelta = new Vector3(TitleCtrl.garoto2D, TitleCtrl.seroto2D, TitleCtrl.nophito2D);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
