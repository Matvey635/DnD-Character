using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpLevelBtn : MonoBehaviour
{

    public GameObject LevelField;
    public GameObject XPField;

    public GameObject LoaderObj;

    public void UpLevel()
    {
        if (DataHandler.Data.XP == DataHandler.Data.LevelCost[DataHandler.Data.Level + 1])
        {
            DataHandler.Data.Level += 1;
            LevelField.GetComponent<Text>().text = "Lv: " + DataHandler.Data.Level.ToString() + " / <color=#4ECCA3>+" + DataHandler.Data.CalcBM() + "</color>";
            XPField.GetComponent<Text>().text    = "XP: " + DataHandler.Data.XP.ToString() + "/" + DataHandler.Data.LevelCost[DataHandler.Data.Level + 1];
        
            LoaderObj.GetComponent<FirstSceneLoader>().LocalLoadStat();
        }
    }
}
