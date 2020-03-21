using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class removeCtrl : MonoBehaviour
{
    BoxCollider2D colli;
    RectTransform rt;
    //GameObject _panel = GameObject.Find("Panel");
    GameObject can;
    private float temp;
    public bool isTouched;
    public GameObject BOX;

    // Start is called before the first frame update
    void Start()
    {
        colli = GetComponent<BoxCollider2D>();
        rt = GetComponent<RectTransform>();
        this.GetComponent<RectTransform>().localScale = new Vector2(1, 1);
        can = GameObject.Find("Canvas");
        temp = can.GetComponent<RectTransform>().position.x * 2 * 0.82f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!isTouched && collision.name == "Remove")
        {
            Destroy(BOX);
        }
    }
}