using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetDex : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject DexField;

    public GameObject SpDex;
    public GameObject Akb;
    public GameObject LR;
    public GameObject Ste;


    public void SetDex()
    {
        if (int.Parse(InputField.GetComponent<InputField>().text) <= 30 && int.Parse(InputField.GetComponent<InputField>().text) >= 1)
        {
            DexField.GetComponent<Text>().text = "Лвк: " + InputField.GetComponent<InputField>().text + " <color=#4ECCA3>" + DataHandler.Data.ChasPlus[int.Parse(InputField.GetComponent<InputField>().text)].ToString() + "</color>";
            DataHandler.Data.Dex = int.Parse(InputField.GetComponent<InputField>().text);
            CalculateChars.Calculator.Calc();

            GetSheet.SetActive(false);
            
            SpDex.GetComponent<Text>().text = DataHandler.Data.SpDex.ToString();
            Akb.GetComponent<Text>().text = DataHandler.Data.Akb.ToString();
            LR.GetComponent<Text>().text = DataHandler.Data.LR.ToString();
            Ste.GetComponent<Text>().text = DataHandler.Data.Ste.ToString();
        }
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
