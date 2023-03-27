using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInitiativeFunc : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject InitiativeField;

    public void SetInitiative()
    {
        InitiativeField.GetComponent<Text>().text = InputField.GetComponent<InputField>().text;
        DataHandler.Data.Initiative = int.Parse(InputField.GetComponent<InputField>().text);
        GetSheet.SetActive(false);
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
