using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AddNewItem : MonoBehaviour
{
    public GameObject Itempanel;
    public GameObject ItemPrefab;
    public GameObject AddMenu;

    public GameObject NameEdit;
    public GameObject CountEdit;
    public GameObject EquippedToggle;
    public GameObject DescrEdit;

    public void AddItem()
    {
        DataHandler.Data.Items.Add(new Item(NameEdit.GetComponent<Text>().text, int.Parse(CountEdit.GetComponent<Text>().text), EquippedToggle.GetComponent<Toggle>().isOn, DescrEdit.GetComponent<Text>().text));

        var obj = Instantiate(ItemPrefab, Itempanel.transform);

        obj.transform.GetChild(1).transform.GetChild(0).gameObject.GetComponent<Text>().text = DataHandler.Data.Items.Last().Name;
        obj.transform.GetChild(2).gameObject.GetComponent<Text>().text                       = DataHandler.Data.Items.Last().Count.ToString();
        obj.transform.GetChild(3).gameObject.SetActive(DataHandler.Data.Items.Last().Equipped);


        NameEdit.GetComponent<Text>().text = "";
        CountEdit.GetComponent<Text>().text = "";
        EquippedToggle.GetComponent<Toggle>().isOn = false;
        DescrEdit.GetComponent<Text>().text = "";
        AddMenu.SetActive(false);
    }

    public void CloseMenu()
    {
        AddMenu.SetActive(false);
    }
}
