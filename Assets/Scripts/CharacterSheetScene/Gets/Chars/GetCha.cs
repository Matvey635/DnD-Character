using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCha : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject ChaField;

    public GameObject SpCh;
    public GameObject Dec ;
    public GameObject Inti;
    public GameObject Perf;
    public GameObject Pers;

    public void SetCha()
    {
        if (int.Parse(InputField.GetComponent<InputField>().text) <= 30 && int.Parse(InputField.GetComponent<InputField>().text) >= 1)
        {
            ChaField.GetComponent<Text>().text = "Хар: " + InputField.GetComponent<InputField>().text + " <color=#4ECCA3>" + DataHandler.Data.ChasPlus[int.Parse(InputField.GetComponent<InputField>().text)].ToString() + "</color>";
            DataHandler.Data.Ch = int.Parse(InputField.GetComponent<InputField>().text);
            CalculateChars.Calculator.Calc();

            GetSheet.SetActive(false);
            
            SpCh.GetComponent<Text>().text = DataHandler.Data.SpCh.ToString();
            Dec.GetComponent<Text>().text = DataHandler.Data.Dec.ToString();
            Inti.GetComponent<Text>().text = DataHandler.Data.Inti.ToString();
            Perf.GetComponent<Text>().text = DataHandler.Data.Perf.ToString();
            Pers.GetComponent<Text>().text = DataHandler.Data.Pers.ToString();
        }
        InputField.GetComponent<InputField>().text = "";
    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
