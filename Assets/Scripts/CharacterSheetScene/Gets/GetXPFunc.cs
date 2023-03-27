using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetXPFunc : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject XPField;

    public void Plus()
    {
        DataHandler.Data.XP += int.Parse(InputField.GetComponent<InputField>().text);
        if ( DataHandler.Data.XP > DataHandler.Data.LevelCost[ DataHandler.Data.Level + 1 ] )
        {
            DataHandler.Data.XP = DataHandler.Data.LevelCost[ DataHandler.Data.Level + 1 ];
        }
        XPField.GetComponent<Text>().text = "XP: " + DataHandler.Data.XP + " / " + DataHandler.Data.LevelCost[DataHandler.Data.Level + 1];
        GetSheet.SetActive(false);
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
