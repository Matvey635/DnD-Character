using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetKDFunc : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject KDField;

    public void SetKD()
    {
        KDField.GetComponent<Text>().text = InputField.GetComponent<InputField>().text;
        DataHandler.Data.KD = int.Parse(InputField.GetComponent<InputField>().text);
        GetSheet.SetActive(false);
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
