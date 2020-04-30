using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCtrl : MonoBehaviour
{
    public GameObject floor;
    public GameObject InputFieldPanel;

    public InputField inputGaro;
    public InputField inputSero;
    public InputField inputNophi;

    private Transform RootPrefab;

    public bool rmtrigger;

    void Start()
    {
        InputFieldPanel.SetActive(false);
        rmtrigger = true;
    }
    void CreateNewObject()
    {
        RootPrefab.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector3(int.Parse(inputGaro.text), int.Parse(inputSero.text), int.Parse(inputNophi.text));
        Instantiate(RootPrefab, new Vector3(100, 100, 0), Quaternion.identity).transform.SetParent(floor.transform);
    }   
    public void NextButtonClicked()
    {
        CreateNewObject();
        inputGaro.text = "";
        inputSero.text = "";
        inputNophi.text = "";
        InputFieldPanel.SetActive(false);
    }
    public void CancelButtonClicked()
    {
        inputGaro.text = "";
        inputSero.text = "";
        inputNophi.text = "";
        InputFieldPanel.SetActive(false);
    }
    public void NewPilarButtonClicked()
    {
        RootPrefab = Resources.Load<Transform>("2Dprefabs/Pilar");
        InputFieldPanel.SetActive(true);
    }

    public void NewDoorButtonClicked()
    {
        RootPrefab = Resources.Load<Transform>("2Dprefabs/Door");
        InputFieldPanel.SetActive(true);
    }

    public void NewWindowButtonClicked()
    {
        RootPrefab = Resources.Load<Transform>("2Dprefabs/Window");
        InputFieldPanel.SetActive(true);
    }

    public void NewClosetButtonClicked()
    {
        RootPrefab = Resources.Load<Transform>("2Dprefabs/Closet");
        InputFieldPanel.SetActive(true);
    }

    public void NewTableButtonClicked()
    {
        RootPrefab = Resources.Load<Transform>("2Dprefabs/Table");
        InputFieldPanel.SetActive(true);
    }

    public void NewDeskButtonClicked()
    {
        RootPrefab = Resources.Load<Transform>("2Dprefabs/Desk");
        InputFieldPanel.SetActive(true);
    }
    public void NewChairButtonClicked()
    {
        RootPrefab = Resources.Load<Transform>("2Dprefabs/Chair");
        InputFieldPanel.SetActive(true);
    }
    public void NewDrawerButtonClicked()
    {
        RootPrefab = Resources.Load<Transform>("2Dprefabs/Drawer");
        InputFieldPanel.SetActive(true);
    }

    public void NewBedButtonClicked()
    {
        RootPrefab = Resources.Load<Transform>("2Dprefabs/Bed");
        InputFieldPanel.SetActive(true);
    }

    public void NewCouchButtonClicked()
    {
        RootPrefab = Resources.Load<Transform>("2Dprefabs/Couch");
        InputFieldPanel.SetActive(true);
    }

    public void PlusButtonClicked()
    {
        floor.GetComponent<RectTransform>().localScale *= 1.5f;
    }
    public void MinusButtonClicked()
    {
        Vector3 temp = floor.GetComponent<RectTransform>().localScale;
        if (temp.x > 0 && temp.y > 0)
        {
            floor.GetComponent<RectTransform>().localScale /= 1.5f;
        }
    }
     
}
