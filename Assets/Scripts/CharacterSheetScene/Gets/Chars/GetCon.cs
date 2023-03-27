using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCon : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject ConField;

    public GameObject SpCon;

    public void SetCon()
    {
        if (int.Parse(InputField.GetComponent<InputField>().text) <= 30 && int.Parse(InputField.GetComponent<InputField>().text) >= 1)
        {
            ConField.GetComponent<Text>().text = "Тел: " + InputField.GetComponent<InputField>().text + " <color=#4ECCA3>" + DataHandler.Data.ChasPlus[int.Parse(InputField.GetComponent<InputField>().text)].ToString() + "</color>";
            DataHandler.Data.Con = int.Parse(InputField.GetComponent<InputField>().text);
            CalculateChars.Calculator.Calc();

            GetSheet.SetActive(false);
            
            SpCon.GetComponent<Text>().text = DataHandler.Data.SpCon.ToString();
        }
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
