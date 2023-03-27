using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetStr : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject StrField;

    public GameObject SpStr;
    public GameObject Atl;

    public void SetStr()
    {
        if (int.Parse(InputField.GetComponent<InputField>().text) <= 30 && int.Parse(InputField.GetComponent<InputField>().text) >= 1)
        {
            StrField.GetComponent<Text>().text = "Сила: " + InputField.GetComponent<InputField>().text + " <color=#4ECCA3>" + DataHandler.Data.ChasPlus[int.Parse(InputField.GetComponent<InputField>().text)].ToString() + "</color>";
            DataHandler.Data.Str = int.Parse(InputField.GetComponent<InputField>().text);
            CalculateChars.Calculator.Calc();

            GetSheet.SetActive(false);
            
            SpStr.GetComponent<Text>().text = DataHandler.Data.SpStr.ToString();
            Atl.GetComponent<Text>().text = DataHandler.Data.Atl.ToString();
        }
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
