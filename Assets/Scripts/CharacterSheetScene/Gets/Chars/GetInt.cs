using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInt : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject IntField;

    public GameObject SpInt;
    public GameObject Magic;
    public GameObject Hs;
    public GameObject Anal;
    public GameObject Nat;
    public GameObject Reg;

    public void SetInt()
    {
        if (int.Parse(InputField.GetComponent<InputField>().text) <= 30 && int.Parse(InputField.GetComponent<InputField>().text) >= 1)
        {
            IntField.GetComponent<Text>().text = "Инт: " + InputField.GetComponent<InputField>().text + " <color=#4ECCA3>" + DataHandler.Data.ChasPlus[int.Parse(InputField.GetComponent<InputField>().text)].ToString() + "</color>";
            DataHandler.Data.Int = int.Parse(InputField.GetComponent<InputField>().text);
            CalculateChars.Calculator.Calc();

            GetSheet.SetActive(false);
            
            SpInt.GetComponent<Text>().text = DataHandler.Data.SpInt.ToString();
            Magic.GetComponent<Text>().text = DataHandler.Data.Magic.ToString();
            Hs.GetComponent<Text>().text = DataHandler.Data.Hs.ToString();
            Anal.GetComponent<Text>().text = DataHandler.Data.Anal.ToString();
            Nat.GetComponent<Text>().text = DataHandler.Data.Nat.ToString();
            Reg.GetComponent<Text>().text = DataHandler.Data.Reg.ToString();
        }
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
