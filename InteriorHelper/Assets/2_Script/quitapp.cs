using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitapp : MonoBehaviour
{
    public GameObject quitpanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && quitpanel.activeSelf)
        {
            pushyesbutton();
        }
    }
    public void pushcancelbutton()
    {
        quitpanel.SetActive(false);
    }
    public void pushyesbutton()
    {
        Debug.Log("quit");
        Application.Quit();

    }

}
