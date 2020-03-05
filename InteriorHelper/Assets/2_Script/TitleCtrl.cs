using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class TitleCtrl : MonoBehaviour
{
    public GameObject firstpanel;
    public GameObject floorpanel;

    public InputField garo;
    public InputField sero;
    public InputField nophi;

    // Start is called before the first frame update
    void Start()
    {
        firstpanel.SetActive(true);
        floorpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // StartBtn click function
    public void LoginBtn()
    {
        //to do :: when Login button clicked
        firstpanel.SetActive(false);
        floorpanel.SetActive(true);
    }

    public void GuestBtn()
    {
        firstpanel.SetActive(false);
        floorpanel.SetActive(true);
        //SceneManager.LoadScene("2_2DScene");
    }

    public void LoadBtn()
    {
        //to do :: when LOAD_LOCAL button clicked
    }

    public void NextButton()
    {
        Debug.Log(garo.text);
        Debug.Log(sero.text);
        Debug.Log(nophi.text);
    }

    public void CancelButton()
    {
        garo.text = "";
        sero.text = "";
        nophi.text = "";
        firstpanel.SetActive(true);
        floorpanel.SetActive(false);
    }
}
