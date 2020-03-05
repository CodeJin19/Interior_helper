using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class TitleCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // StartBtn click function
    public void LoginBtn()
    {
        //to do :: when Login button clicked
    }

    public void GuestBtn()
    {
        SceneManager.LoadScene("2_2DScene");
    }

    public void LoadBtn()
    {
        //to do :: when LOAD_LOCAL button clicked
    }
}
