using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHitsDiceFunc : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject HitsDiceField;

    public void SetHitsDice()
    {
        HitsDiceField.GetComponent<Text>().text = InputField.GetComponent<InputField>().text;
        DataHandler.Data.HitsDice = int.Parse(InputField.GetComponent<InputField>().text);
        GetSheet.SetActive(false);
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
