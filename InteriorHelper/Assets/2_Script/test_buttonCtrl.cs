using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

using System.Text;
using System;

public class test_buttonCtrl : MonoBehaviour
{
    public string LoginUrl;
    public string RegisterUrl;

    public InputField regid;
    public InputField logid;

    // Start is called before the first frame update
    void Start()
    {
        LoginUrl = "http://54.180.142.181/login";
        RegisterUrl = "http://54.180.142.181/register";
    }

    // Update is called once per frame
    public void LoginBtn()
    {
        StartCoroutine(LoginCo());
    }

    IEnumerator LoginCo()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", logid.text);

        WWW webRequest = new WWW(LoginUrl, form);
        yield return webRequest;

        /*
        // utf-8 인코딩
        byte[] bytesForEncoding = Encoding.UTF8.GetBytes(webRequest.text);
        string encodedString = Convert.ToBase64String(bytesForEncoding);

        // utf-8 디코딩
        byte[] decodedBytes = Convert.FromBase64String(encodedString);
        string decodedString = Encoding.UTF8.GetString(decodedBytes);
        
        Debug.Log(decodedString);
        */

        Debug.Log(webRequest.text);
    }

    public void RegisterBtn()
    {
        StartCoroutine(RegisterCo());
    }

    IEnumerator RegisterCo()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", regid.text);

        WWW webRequest = new WWW(RegisterUrl, form);
        yield return webRequest;

        /*
        // utf-8 인코딩
        byte[] bytesForEncoding = Encoding.UTF8.GetBytes(webRequest.text);
        string encodedString = Convert.ToBase64String(bytesForEncoding);

        // utf-8 디코딩
        byte[] decodedBytes = Convert.FromBase64String(encodedString);
        string decodedString = Encoding.UTF8.GetString(decodedBytes);

        Debug.Log(decodedString);
        */

        Debug.Log(webRequest.text);
    }
}
