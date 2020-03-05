using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCtrl : MonoBehaviour
{
    public Transform Prefabs;
    public GameObject floor;

    public void newObject()
    {
        Instantiate(Prefabs, new Vector3(0, 0, 0), Quaternion.identity).transform.SetParent(floor.transform);
    }
}
