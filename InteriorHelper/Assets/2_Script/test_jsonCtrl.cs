using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using LitJson;
using System.IO;

public class Data
{
    public int id;
    public string floor;
    public List<string> objects;

    public Data(int id, string floor, List<string> objects)
    {
        this.id = id;
        this.floor = floor;
        this.objects = objects;
    }

    public void Addobject(string obj)
    {
        this.objects.Add(obj);
    }
}

public class test_jsonCtrl : MonoBehaviour
{
    public Data test = new Data(1, "floor", new List<string>());

    // Start is called before the first frame update
    void Start()
    {
        test.Addobject("closet");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadBtn()
    {

    }

    public void SaveBtn()
    {
        Debug.Log("저장하기");

        JsonData ItemJson = JsonMapper.ToJson(test);
        File.WriteAllText(Application.dataPath + "/Resources/data/test.json", ItemJson.ToString());

        Debug.Log(ItemJson.ToString());
        Debug.Log(Application.dataPath + "/test.json");
    }
}
