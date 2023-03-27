using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetClassFunc : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject ClassField;

    public void SetClass()
    {
        ClassField.GetComponent<Text>().text = InputField.GetComponent<InputField>().text;
        DataHandler.Data.Class = InputField.GetComponent<InputField>().text;
        GetSheet.SetActive(false);
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
