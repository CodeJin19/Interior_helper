using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCtrl : MonoBehaviour
{
    private bool state = false;

   
    public GameObject floor;
    public GameObject InputFieldPanel;

    public InputField inputGaro;
    public InputField inputSero;
    public InputField inputNophi;

    public Transform RootPrefab;

    void Start()
    {
        InputFieldPanel.SetActive(false);
    }
    public void NewButtonClicked()
    {
        InputFieldPanel.SetActive(true);
    }
    public void newObject()
    {
        RootPrefab.localScale = new Vector3(int.Parse(inputGaro.text), int.Parse(inputSero.text), int.Parse(inputNophi.text));
        Instantiate(RootPrefab, new Vector3(0, 0, 0), Quaternion.identity).transform.SetParent(floor.transform);
    }   
    public void NextButtonClicked()
    {
        newObject();
        inputGaro.text = "";
        inputSero.text = "";
        inputNophi.text = "";
        InputFieldPanel.SetActive(false);
    }
}
