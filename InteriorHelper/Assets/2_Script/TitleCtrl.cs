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
    public GameObject quitpanel;

    public InputField garo;
    public InputField sero;
    public InputField nophi;

    public static int garoto2D;
    public static int seroto2D;
    public static int nophito2D;

    // Start is called before the first frame update
    void Start()
    {
        firstpanel.SetActive(true);
        floorpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            quitpanel.SetActive(true);
        }
        
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
        garoto2D = int.Parse(garo.text);
        seroto2D = int.Parse(sero.text);
        nophito2D = int.Parse(nophi.text);

        SceneManager.LoadScene("2_2DScene");
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
