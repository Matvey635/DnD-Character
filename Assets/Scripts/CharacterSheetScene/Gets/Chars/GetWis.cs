using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetWis : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject WisField;

    public GameObject SpWis;
    public GameObject AH   ;  
    public GameObject Ins  ;
    public GameObject Med  ;
    public GameObject Per  ;
    public GameObject Surv ;


    public void SetWis()
    {
        if (int.Parse(InputField.GetComponent<InputField>().text) <= 30 && int.Parse(InputField.GetComponent<InputField>().text) >= 1)
        {
            WisField.GetComponent<Text>().text = "Муд: " + InputField.GetComponent<InputField>().text + " <color=#4ECCA3>" + DataHandler.Data.ChasPlus[int.Parse(InputField.GetComponent<InputField>().text)].ToString() + "</color>";
            DataHandler.Data.Wis = int.Parse(InputField.GetComponent<InputField>().text);
            CalculateChars.Calculator.Calc();

            GetSheet.SetActive(false);
            
            SpWis.GetComponent<Text>().text = DataHandler.Data.SpWis.ToString();
            AH.GetComponent<Text>().text = DataHandler.Data.AH.ToString();
            Ins.GetComponent<Text>().text = DataHandler.Data.Ins.ToString();
            Med.GetComponent<Text>().text = DataHandler.Data.Med.ToString();
            Per.GetComponent<Text>().text = DataHandler.Data.Per.ToString();
            Surv.GetComponent<Text>().text = DataHandler.Data.Surv.ToString();
        }
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
