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

    // Start is called before the first frame update
    void Start()
    {
        colli = GetComponent<BoxCollider2D>();
        rt = GetComponent<RectTransform>();
        im = GetComponent<RawImage>();
        collision_count = 0;
        colli.size = new Vector2(rt.rect.width, rt.rect.height);
        this.GetComponent<RectTransform>().localScale = new Vector2(1, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTouchDown()
    {
        this.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    public void OnTouchUp()
    {

    }

    public void OnTouchDrag()
    {
        this.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision_count++;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name != "floor")
        {
            im.color = new Color32(255, 0, 0, 255);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision_count--;
        if (collision_count == 0) {
            im.color = new Color32(0, 0, 0, 255);
        }
    }
}