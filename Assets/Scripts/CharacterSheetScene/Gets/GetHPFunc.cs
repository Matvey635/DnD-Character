using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHPFunc : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject MInputField;
    public GameObject VInputField;
    public GameObject HPField;
    

    void Awake()
    {
        VInputField.GetComponent<InputField>().text = 0.ToString();
    }

    public void SetHP()
    {
        HPField.GetComponent<Text>().text = InputField.GetComponent<InputField>().text;
        DataHandler.Data.HP = int.Parse(InputField.GetComponent<InputField>().text);
        DataHandler.Data.MaxHP = int.Parse(MInputField.GetComponent<InputField>().text);
        DataHandler.Data.VHP = int.Parse(VInputField.GetComponent<InputField>().text);
        
        GetSheet.SetActive(false);
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
