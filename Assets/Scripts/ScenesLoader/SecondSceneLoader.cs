using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondSceneLoader : MonoBehaviour
{
    public GameObject Itempanel;
    public GameObject ItemPrefab;

    void Start()
    {
        Load();
    }

    public void Load()
    {
        foreach (Item Key in DataHandler.Data.Items)
        {

            var obj = Instantiate(ItemPrefab, Itempanel.transform);
            
            obj.transform.GetChild(2).transform.GetChild(0).gameObject.GetComponent<Text>().text = Key.Name;
            obj.transform.GetChild(3).gameObject.GetComponent<Text>().text                       = Key.Count.ToString();
            obj.transform.GetChild(4).gameObject.SetActive(Key.Equipped);
        }
    }
}
