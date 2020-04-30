using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCtrl : MonoBehaviour
{
    BoxCollider2D colli;
    RectTransform rt;
    RawImage im;
    int collision_count;
    //GameObject _panel = GameObject.Find("Panel");
    private float mousex;
    private float mousey;
    GameObject EventSystem;

    GameObject can;
    private float temp;
    private Color32 origin;
    private Color32 ColorRed = new Color32(255, 0, 0, 255);

    // Start is called before the first frame update
    void Start()
    {
        colli = GetComponent<BoxCollider2D>();
        rt = GetComponent<RectTransform>();
        im = GetComponent<RawImage>();
        origin = im.color;
        collision_count = 0;
        colli.size = new Vector2(rt.rect.width, rt.rect.height);
        this.GetComponent<RectTransform>().localScale = new Vector2(1, 1);
        can = GameObject.Find("Canvas");
        temp = can.GetComponent<RectTransform>().position.x * 2 * 0.82f;
        EventSystem = GameObject.Find("EventSystem");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTouchDown()
    {
        EventSystem.GetComponent<ButtonCtrl>().rmtrigger = true;
        transform.GetChild(0).gameObject.GetComponent<removeCtrl>().isTouched = true;
        this.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    public void OnTouchUp()
    {
        transform.GetChild(0).gameObject.GetComponent<removeCtrl>().isTouched = false;
        if (mousex > temp)
        {
            this.transform.position = new Vector2(temp, mousey);
        }
        /*
        if ((int)(Input.mousePosition.x - x) % 10 >= 5)
        {
            if ((int)(Input.mousePosition.y - y) % 10 >= 5)
                //this.transform.position = new Vector2((int)(((Input.mousePosition.x - x) / 10) + 1) * 10, (int)(((Input.mousePosition.y - y) / 10) + 1) * 10);
                this.GetComponent<RectTransform>().anchoredPosition = new Vector2((int)(((Input.mousePosition.x - x) / 10) + 2) * 5, (int)(((Input.mousePosition.y - y) / 10) + 2) * 5);
            else
                //this.transform.localPosition = new Vector2((int)(((Input.mousePosition.x - x) / 10) + 1) * 10, (int)((Input.mousePosition.y - y) / 10) * 10);
                this.GetComponent<RectTransform>().anchoredPosition = new Vector2((int)(((Input.mousePosition.x - x) / 10) + 2) * 5, (int)((Input.mousePosition.y - y) / 10) * 5);
        }
        else
        {
            if ((int)(Input.mousePosition.y - y) % 10 >= 5)
                //this.transform.localPosition = new Vector2((int)(((Input.mousePosition.x - x) / 10)) * 10, (int)(((Input.mousePosition.y - y) / 10) + 1) * 10);
                this.GetComponent<RectTransform>().anchoredPosition = new Vector2((int)(((Input.mousePosition.x - x) / 10)) * 5, (int)(((Input.mousePosition.y - y) / 10) + 2) * 5);
            else
                //this.transform.localPosition = new Vector2((int)(((Input.mousePosition.x - x) / 10)) * 10, (int)((Input.mousePosition.y - y) / 10) * 10);
                this.GetComponent<RectTransform>().anchoredPosition = new Vector2((int)(((Input.mousePosition.x - x) / 10)) * 5, (int)((Input.mousePosition.y - y) / 10) * 5);
        }
        */
        Vector2 vec = new Vector2(this.transform.localPosition.x - rt.rect.width / 2, this.transform.localPosition.y + rt.rect.height / 2);

        if ((int)(vec.x + 10000) % 10 >= 5)
        {
            if ((int)(vec.y + 10000) % 10 >= 5)
                this.transform.localPosition = new Vector2(((int)((vec.x + 1000) / 10) + 1 - 100) * 10 + rt.rect.width / 2, ((int)((vec.y + 1000) / 10) + 1 - 100) * 10 - rt.rect.height / 2);
            else
                this.transform.localPosition = new Vector2(((int)((vec.x + 1000) / 10) + 1 - 100) * 10 + rt.rect.width / 2, (int)((vec.y + 1000) / 10 - 100) * 10 - rt.rect.height / 2);
        }
        else
        {
            if ((int)(vec.y + 10000) % 10 >= 5)
                this.transform.localPosition = new Vector2((int)((vec.x + 1000) / 10 - 100) * 10 + rt.rect.width / 2, ((int)((vec.y + 1000) / 10 - 100) + 1) * 10 - rt.rect.height / 2);
            else
                this.transform.localPosition = new Vector2((int)((vec.x + 1000) / 10 - 100) * 10 + rt.rect.width / 2, (int)((vec.y + 1000) / 10 - 100) * 10 - rt.rect.height / 2);
        }
        if (mousex > temp)
        {
            this.transform.position = new Vector2(temp, mousey);
        }
    }

    public void OnTouchDrag()
    {
        this.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        mousex = Input.mousePosition.x;
        mousey = Input.mousePosition.y;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision_count++;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name != "floor" && collision.name != "RemoveCol" && collision.name != "Remove")
        {
            im.color = ColorRed;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision_count--;
        if (collision_count == 1)
        {
            im.color = origin;
        }
    }
}