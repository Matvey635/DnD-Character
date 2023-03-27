using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHitsLostFunc : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject LInputField;
    public GameObject HitsField;
    
    public void SetHits()
    {
        HitsField.GetComponent<Text>().text = LInputField.GetComponent<InputField>().text + "/" + InputField.GetComponent<InputField>().text;
        DataHandler.Data.Hits = int.Parse(InputField.GetComponent<InputField>().text);
        DataHandler.Data.HitsLost = int.Parse(LInputField.GetComponent<InputField>().text);
        
        GetSheet.SetActive(false);
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
