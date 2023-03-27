using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetNameFunc : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject NameField;

    public void SetName()
    {
        NameField.GetComponent<Text>().text = InputField.GetComponent<InputField>().text;
        DataHandler.Data.Name = InputField.GetComponent<InputField>().text;
        GetSheet.SetActive(false);
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
